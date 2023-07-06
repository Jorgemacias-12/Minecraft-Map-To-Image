using fNbt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSavesReader
    {
        private MinecraftSaves MSaves;
        private MinecraftSave Save;
        private MinecraftMapReader MapsReader;
        private readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private readonly static string MINECRAFT_SAVES_PATH = Path.Combine(APPDATA_PATH, ".minecraft", "saves");
    
        public MinecraftSavesReader()
        {

        }

        public async Task LoadSaves(List<MinecraftSave> Saves)
        {
            MapsReader = new MinecraftMapReader();

            try
            {
                string[] MinecraftSavesPath = await Task.Run(() => Directory.GetDirectories(MINECRAFT_SAVES_PATH));

                foreach(string MinecraftSavePath in MinecraftSavesPath)
                {
                    Save = new MinecraftSave(Path.GetFileName(MinecraftSavePath),
                                             MinecraftSavePath,
                                             ReadVersion(MinecraftSavePath),
                                             ReadSplashIcon(MinecraftSavePath), null);
                    // Read maps here
                    Save.Maps = await MapsReader.LoadMaps(MinecraftSavePath, Save.Version);
                    
                    Saves.Add(Save);

                    Save.HasMaps = true;
                }

            }

            catch(FileNotFoundException)
            {
                Save.HasMaps = false;
            }
        }

        private string ReadVersion(string MinecraftSavePath)
        {
            string LevelDatPath = Path.Combine(MinecraftSavePath, "level.dat");

            NbtFile nbtFile = new NbtFile(LevelDatPath);

            try
            {
                nbtFile.LoadFromFile(LevelDatPath);

                NbtCompound rootCompound = nbtFile.RootTag;

                NbtCompound dataCompound = rootCompound.Get<NbtCompound>("Data");

                NbtCompound versionCompound = dataCompound.Get<NbtCompound>("Version");

                NbtString Version = versionCompound.Get<NbtString>("Name");

                return Version.StringValue;
            }
            catch (Exception) { }

            return "";
        }

        private Image ReadSplashIcon(string MinecraftSavePath)
        {
            return Image.FromFile($"{MinecraftSavePath}\\icon.png");
        }
    }
}
