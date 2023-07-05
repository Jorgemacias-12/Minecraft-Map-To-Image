using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMaps
    {
        #region Singleton Implementation

        private static MinecraftMaps _Instance;
        private static readonly object _Lock = new object();

        public static MinecraftMaps Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_Lock)
                    {
                        _Instance = new MinecraftMaps();
                    }
                }

                return _Instance;
            }
        }

        #endregion

        #region Class Variables
        public static readonly Dictionary<string, List<MinecraftMap>> Maps = new Dictionary<string, List<MinecraftMap>>();
        private readonly MinecraftMapsReader MapsReader;
        #endregion

        #region Class Constructor 

        private MinecraftMaps()
        {
            MapsReader = new MinecraftMapsReader();

            MapsReader.LoadMaps(Maps);
        }

        #endregion

        #region Class Methods

        public static MinecraftMap GetMap(string MinecraftSaveName, string MinecraftMapName)
        {
            //MinecraftMap map;
            //Maps.TryGetValue(MinecraftMapName, out map);

            List<MinecraftMap> maps;
            bool Sucess;

            Sucess = Maps.TryGetValue(MinecraftSaveName, out maps);

            if (!Sucess) throw new FileNotFoundException("Mapa(s) no encontrados");

            return maps.FirstOrDefault(map => map.Name == MinecraftSaveName);
        }

        #endregion

    }
}
