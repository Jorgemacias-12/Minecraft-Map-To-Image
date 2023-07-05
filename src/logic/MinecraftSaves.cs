using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSaves
    {
        private static MinecraftSaves _Instance;
        private static readonly object _Lock = new object();
        private MinecraftSavesReader _Reader;
        
        public List<MinecraftSave> Saves { get; set; } = new List<MinecraftSave>();

        private MinecraftSaves() 
        { 
            _Reader = new MinecraftSavesReader();
        }

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

        public async Task ReadSaves()
        {
            await _Reader.LoadSaves(Saves);
        }

    }
}
