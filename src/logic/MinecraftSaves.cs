using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSaves
    {
        #region Singleton Implementation
        private static MinecraftSaves _Instance;
        private static readonly object _Lock = new object();
        private MinecraftSavesReader _Reader;

        public static MinecraftSaves Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_Lock)
                    {
                        _Instance = new MinecraftSaves();
                    }
                }

                return _Instance;
            }
        }
        #endregion

        #region Class Variables
        public readonly List<MinecraftSave> Saves = new List<MinecraftSave>();
        #endregion

        #region Class Constructor
        private MinecraftSaves()
        {
            _Reader = new MinecraftSavesReader();
        }
        #endregion

        #region Class Methods
        public async Task ReadSavesAsync()
        {
            await _Reader.LoadSaves(Saves);
        }
        #endregion
        
    }
}
