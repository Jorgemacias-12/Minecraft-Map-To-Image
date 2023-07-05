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
        #region Class Variables
        #endregion

        #region Class Constants 
        private readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private readonly static string MINECRAFT_SAVES_PATH = Path.Combine(APPDATA_PATH, ".minecraft", "saves");
        #endregion

        #region Class Constructor
        public MinecraftSavesReader()
        {

        }
        #endregion


        #region Class Methods

        public async Task LoadSaves(List<MinecraftSave> MinecraftSavesList)
        {
            if (!Directory.Exists(MINECRAFT_SAVES_PATH))
            {
                throw new FileNotFoundException("Minecraft path not found");
            }

            string[] MinecraftSavesPath = await Task.Run(() => Directory.GetDirectories(MINECRAFT_SAVES_PATH));

            foreach (string MinecraftSavePath in MinecraftSavesPath)
            {
                MinecraftSave minecraftSave = new MinecraftSave(
                    ReadSaveVersion(MinecraftSavePath),
                    Path.GetFileName(MinecraftSavePath),
                    MinecraftSavePath,
                    ReadSaveSplashImage(MinecraftSavePath)
                );

                MinecraftSavesList.Add(minecraftSave);
            }
        }


        private string ReadSaveVersion(string MinecraftSavePath)
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

        private Image ReadSaveSplashImage(string MinecraftSavePath)
        {
            return Image.FromFile($"{MinecraftSavePath}\\icon.png");
        }
        #endregion
    }
}
