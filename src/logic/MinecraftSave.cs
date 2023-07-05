using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSave
    {
        #region Class Variables

        /*
         * To read the SaveVersion from a Minecraft Save I need to 
         * go to the level.dat file and read the Version object,
         * and access to the Name property
         */
        public string Version { get; set; } 
        public string Name { get; set; }
        public string Path { get; set; }
        public Image SplashImage { get; set; }

        #endregion


        #region Class Constructor
        public MinecraftSave(string saveVersion, string saveName, string savePath, Image saveSplashImage)
        {
            Version = saveVersion;
            Name = saveName;
            Path = savePath;
            SplashImage = saveSplashImage;
        }

        #endregion
    }
}
