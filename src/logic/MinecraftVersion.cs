using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftVersion
    {
        #region Class Variables
        private string Name;
        private string Path;
        #endregion

        #region Class Constructor
        public MinecraftVersion(string Name, string Path)
        {
            this.Name = Name;
            this.Path = Path;   
        }
        #endregion
    }
}
