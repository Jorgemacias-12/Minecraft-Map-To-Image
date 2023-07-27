using fNbt;
using Minecraft_Map_Renderer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.utils
{
    public class MinecraftSaveReader
    {

        public static bool TryReadVersion(string SavePath, out string Version)
        {
            string LevelDatPath = Path.Combine(SavePath, "level.dat");

            NbtFile nbtFile = new NbtFile();

            nbtFile.LoadFromFile(LevelDatPath);

            NbtCompound rootCompound = nbtFile.RootTag;

            NbtCompound dataCompound = rootCompound.Get<NbtCompound>("Data");

            if (!dataCompound.Contains("Version"))
            {
                Version = "Unknown";

                return false;
            }

            NbtCompound versionCompound = dataCompound.Get<NbtCompound>("Version");

            Version = versionCompound.Get<NbtString>("Name").StringValue;

            return true;
        }

        public static bool TryReadSplashIcon(string SavePath, out Image Icon)
        {
            try
            {
                Icon = Image.FromFile($"{SavePath}\\icon.png");
                return true;
            }

            catch(Exception)
            {
                Icon = Resources.grass_block;
                return false;
            }
        }
    }
}
