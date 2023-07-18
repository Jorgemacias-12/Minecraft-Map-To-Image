using fNbt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSavesReader
    {
        private MinecraftSave Save;
        private MinecraftMapReader MapsReader;
        private readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string MINECRAFT_SAVES_PATH = Path.Combine(APPDATA_PATH, ".minecraft", "saves");
    
        public MinecraftSavesReader()
        {

        }

        // TODO: Implement a configurable way to 
        // read any saves in any folder
        // I might use a custom form to do that.
        public async Task LoadSaves(List<MinecraftSave> Saves)
        {
            MapsReader = new MinecraftMapReader();

            try
            {
                if (!Directory.Exists(MINECRAFT_SAVES_PATH))
                {
                    return;
                }

                string[] MinecraftSavesPath = await Task.Run(() => Directory.GetDirectories(MINECRAFT_SAVES_PATH));

                foreach(string MinecraftSavePath in MinecraftSavesPath)
                {
                    Save = new MinecraftSave(Path.GetFileName(MinecraftSavePath),
                                             MinecraftSavePath,
                                             ReadVersion(MinecraftSavePath),
                                             ReadSplashIcon(MinecraftSavePath), 
                                             null);

                    if (Save is null) return;

                    Save.Maps = await MapsReader.LoadMaps(MinecraftSavePath, Save.Version);

                    Saves.Add(Save);

                    Save.HasMaps = true;
                }
            }

            catch (Exception)
            {
                Save.HasMaps = false;
            }
        }

        private string ReadVersion(string MinecraftSavePath)
        {
            string LevelDatPath = Path.Combine(MinecraftSavePath, "level.dat");

            try
            {
                NbtFile nbtFile = new NbtFile(LevelDatPath);
                
                nbtFile.LoadFromFile(LevelDatPath);

                NbtCompound rootCompound = nbtFile.RootTag;

                NbtCompound dataCompound = rootCompound.Get<NbtCompound>("Data");

                NbtCompound versionCompound = dataCompound.Get<NbtCompound>("Version");

                NbtString Version = versionCompound.Get<NbtString>("Name");

                return Version.StringValue;
            }
            catch (Exception) 
            {
                return "Save corrupted";
            }
        }

        private Image ReadSplashIcon(string MinecraftSavePath)
        {
            try
            {
                return Image.FromFile($"{MinecraftSavePath}\\icon.png");
            }
            catch (Exception) { return null; }
        }
    }
}
