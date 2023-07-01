using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMaps
    {
        #region Class Variables
        public readonly Dictionary<string, List<MinecraftMap>> Maps = new Dictionary<string, List<MinecraftMap>>();
        private readonly MinecraftMapsReader MapsReader;

        public MinecraftMaps()
        {
            MapsReader = new MinecraftMapsReader();

            MapsReader.LoadMaps(Maps);
        }
        #endregion
    }
}
