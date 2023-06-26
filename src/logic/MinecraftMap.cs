using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMap
    {
        #region Class Constants
        private const int MINECRAFT_MAP_COLORS_SIZE = 16384;
        #endregion

        #region Class Variables
        public string Dimension { get; private set; }
        public Byte Locked { get; private set; }
        public Byte Scale { get; private set; }
        public Byte TrackingPosition { get; private set; }
        public Byte UnlimitedTracking { get; private set; }
        public int XCenter { get; private set; }
        public int ZCenter { get; private set; }
        public Byte[] Colors = new byte[MINECRAFT_MAP_COLORS_SIZE];
        public string Name { get; private set; }

        public MinecraftMap(string dimension, byte locked, byte scale, byte trackingPosition, byte unlimitedTracking, int xCenter, int zCenter, byte[] colors, string name)
        {
            Dimension = dimension ?? throw new ArgumentNullException(nameof(dimension));
            Locked = locked;
            Scale = scale;
            TrackingPosition = trackingPosition;
            UnlimitedTracking = unlimitedTracking;
            XCenter = xCenter;
            ZCenter = zCenter;
            Colors = colors ?? throw new ArgumentNullException(nameof(colors));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        #endregion

        #region Class Constructor

        #endregion
    }
}
