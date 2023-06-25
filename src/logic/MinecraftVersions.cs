using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftVersions
    {
        #region Class Variables
        public readonly List<MinecraftVersion> Versions = new List<MinecraftVersion>();
        #endregion

        #region Class Constructor
        public MinecraftVersions() 
        { 
            MinecraftVersionReader MinecraftVersionReader =  new MinecraftVersionReader();

            MinecraftVersionReader.LoadMinecraftVersions(Versions);
        }
        #endregion
    }
}
