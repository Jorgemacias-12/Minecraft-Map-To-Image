using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSaves
    {
        #region Class Variables
        
        public readonly List<MinecraftSave> Saves = new List<MinecraftSave>();
        private MinecraftSavesReader SavesReader;
        
        #endregion
        
        public MinecraftSaves()
        {
            SavesReader = new MinecraftSavesReader();

            SavesReader.LoadSaves(Saves);
        }
    }
}
