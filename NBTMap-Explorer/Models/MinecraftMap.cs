using NBTMap_Explorer.Helpers;
using System.Windows.Controls;

namespace NBTMap_Explorer.Models
{
    public class MinecraftMap
    {
        public required string Name { get; set; }
        public required string Path { get; set; }
        public required string Dimension { get; set; }
        public byte Locked { get; set; }
        public byte Scale { get; set; }
        public byte TrackingPosition { get; set; }
        public byte UnlimitedTracking { get; set; }
        public int XCenter { get; set; }
        public int ZCenter { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image? Image { get; set; }
        public byte[] Data = new byte[Minecraft.MAP_BYTE_SIZE];
    }
}
