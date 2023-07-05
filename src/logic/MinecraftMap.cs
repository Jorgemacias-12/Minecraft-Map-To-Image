using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMap
    {
        private const int MAP_BYTE_SIZE = 16384;

        public string Name { get; set; } 
        public string Path { get; set; }
        public string Dimension { get; set; }
        public byte Locked { get; set; }
        public byte Scale { get; set; }
        public byte TrackingPosition { get; set; }
        public byte UnlimitedTracking { get; set; }
        public int XCenter { get; set; } 
        public int ZCenter { get; set; }
        public byte[] Colors = new byte[MAP_BYTE_SIZE];

        public MinecraftMap(string name,
                            string path,
                            string dimension,
                            byte locked, 
                            byte scale, 
                            byte trackingPosition, 
                            byte unlimitedTracking, 
                            int xCenter, 
                            int zCenter, 
                            byte[] colors)
        {
            Name = name;
            Path = path;
            Dimension = dimension;
            Locked = locked;
            Scale = scale;
            TrackingPosition = trackingPosition;
            UnlimitedTracking = unlimitedTracking;
            XCenter = xCenter;
            ZCenter = zCenter;
            Colors = colors;
        }
    }
}
