using fNbt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minecraft_Map_Renderer.src.utils;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMapsLoader
    {
        private static NbtFile Level;
        private static NbtCompound Root;
        private static NbtCompound Data;

        private static MinecraftMap Map;

        private static readonly string DATA_FOLDER = "data";
        private static readonly string MAP_DATA_FILE_PATTERN = "map_*.dat";

        public static async Task<List<MinecraftMap>> LoadMaps(string SavePath, string version)
        {
            List<MinecraftMap> maps = new List<MinecraftMap>();

            string MinecraftMapsPath = Path.Combine(SavePath, DATA_FOLDER);

            if (!Directory.Exists(MinecraftMapsPath)) return null;

            string[] MapsPath = await Task.Run(() =>
            {
                return Directory.GetFiles(MinecraftMapsPath, MAP_DATA_FILE_PATTERN);
            });

            foreach(string MapPath in MapsPath)
            {
                Level = new NbtFile();

                Level.LoadFromFile(MapPath);

                Root = Level.RootTag;

                Data = Root.Get<NbtCompound>("data");

                Map = new MinecraftMap(Path.GetFileNameWithoutExtension(MapPath),
                                       MapPath,
                                       MinecraftMapReader.ReadDimension(Data),
                                       MinecraftMapReader.ReadIsLocked(Data),
                                       MinecraftMapReader.ReadScale(Data),
                                       MinecraftMapReader.ReadTrackingPosition(Data),
                                       MinecraftMapReader.ReadUnlimitedTracking(Data),
                                       MinecraftMapReader.ReadXCenter(Data),
                                       MinecraftMapReader.ReadZCenter(Data),
                                       MinecraftMapReader.ReadColors(Data));
                
                maps.Add(Map);
            }

            return maps;
        }
    }
}
