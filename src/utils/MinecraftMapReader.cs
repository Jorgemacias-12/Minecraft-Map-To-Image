using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using fNbt;
using Minecraft_Map_Renderer.src.logic;

namespace Minecraft_Map_Renderer.src.utils
{

    public class MinecraftMapReader
    {
        private const int MAP_WIDTH = 128;
        private const int MAP_HEIGHT = 128;
        private const int NOT_USED_IN_VERSION = 100;

        private static string FormatDimensionName(string Dimension)
        {
            Dimension = Regex.Replace(Dimension, @"^minecraft:", "", RegexOptions.IgnoreCase);
            Dimension = Regex.Replace(Dimension, @"_+", " ");

            CultureInfo _ = CultureInfo.InvariantCulture;

            return _.TextInfo.ToTitleCase(Dimension);
        }

        public static string ReadDimension(NbtCompound MapData)
        {
            MinecraftDimension MapDimension;

            bool containsDimension = MapData.Contains("dimension");

            if (!containsDimension) return "Unkown";

            switch (MapData["dimension"].TagType)
            {
                case NbtTagType.String:

                    return FormatDimensionName(MapData.Get<NbtString>("dimension").StringValue);

                case NbtTagType.Int:
                case NbtTagType.Byte:

                    MapDimension = (MinecraftDimension)MapData.Get<NbtByte>("dimension").ByteValue;

                    return FormatDimensionName($"{MapDimension}");

                default:

                    return "Not found";
            }
        }

        public static int ReadWidth(NbtCompound MapData)
        {
            if (MapData != null &&
                !MapData.Contains("width"))
            {
                return MAP_WIDTH;
            }

            NbtInt Width = MapData.Get<NbtInt>("width");

            return Width.IntValue;
        }

        public static int ReadHeight(NbtCompound MapData)
        {
            if (MapData != null &&
                !MapData.Contains("height"))
            {
                return MAP_HEIGHT;
            }

            NbtInt Height = MapData.Get<NbtInt>("height");

            return Height.IntValue;
        }

        public static byte ReadIsLocked(NbtCompound MapData)
        {
            if (!MapData.Contains("locked"))
            {
                return NOT_USED_IN_VERSION;
            }

            NbtByte Locked = MapData.Get<NbtByte>("locked");

            return Locked.ByteValue;
        }

        public static byte ReadScale(NbtCompound MapData)
        {
            return MapData.Get<NbtByte>("scale").ByteValue;
        }

        public static byte ReadTrackingPosition(NbtCompound MapData)
        {
            return MapData.Get<NbtByte>("trackingPosition").ByteValue;
        }

        public static byte ReadUnlimitedTracking(NbtCompound MapData)
        {
            if (MapData.TryGet<NbtByte>("unlimitedTracking", out var uTracking)) 
            {
                return uTracking.ByteValue; 
            }

            return NOT_USED_IN_VERSION;
        }

        public static int ReadXCenter(NbtCompound MapData)
        {
            return MapData.Get<NbtInt>("xCenter").IntValue;
        }

        public static int ReadZCenter(NbtCompound MapData)
        {
            return MapData.Get<NbtInt>("zCenter").IntValue;
        }

        public static byte[] ReadColors(NbtCompound MapData)
        {
            return MapData.Get<NbtByteArray>("colors").ByteArrayValue;
        }
    }
}
