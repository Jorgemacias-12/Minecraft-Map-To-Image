using fNbt;
using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMapReader
    {
        private NbtFile MapFile;
        private NbtCompound Root;
        private NbtCompound Data;
        private MinecraftMap Map;
        private Version MinecraftVersion = new Version("1.16");
        private Version CurrentVersion;
        private const int NOT_USED_IN_VERSION = 100;
        
        public async Task<List<MinecraftMap>> LoadMaps(string SavePath, string version)
        {
            List<MinecraftMap> maps = new List<MinecraftMap>();

            string MinecraftMapsPath = Path.Combine(SavePath, "data");

            string[] MapsPath = await Task.Run(() => Directory.GetFiles(MinecraftMapsPath, "map_*.dat"));

            foreach(string MapFilePath in MapsPath)
            {
                MapFile = new NbtFile();

                MapFile.LoadFromFile(MapFilePath);

                Root = MapFile.RootTag;

                Data = Root.Get<NbtCompound>("data");

                Map = new MinecraftMap(Path.GetFileNameWithoutExtension(MapFilePath),
                                       MapFilePath,
                                       ReadDimension(version),
                                       ReadLocked(version),
                                       ReadScale(),
                                       ReadTrackingPosition(),
                                       ReadUnlimitedTracking(),
                                       ReadXCenter(),
                                       ReadZCenter(),
                                       ReadColors());
                maps.Add(Map);
            }

            return maps;
        }

        private string ReadDimension(string version)
        {
            // Delete any letters from version
            version = Regex.Replace(version, @"[^0-9.]", "");

            CurrentVersion = Version.Parse(version);

            int result = CurrentVersion.CompareTo(MinecraftVersion);

            if (result == -1)
            {
                NbtInt IDimension = Data.Get<NbtInt>("dimension");

                string _;

                MinecraftDimensions.dimensions.TryGetValue(IDimension.IntValue, out _);

                return _;
            }

            if (result > 0)
            {
                NbtString SDimension = Data.Get<NbtString>("dimension");

                return SDimension.StringValue;
            }

            return "";
        }

        private int ReadWidth()
        {
            NbtInt Width = Data.Get<NbtInt>("width");
            
            return Width.IntValue;
        }

        private int ReadHeight() 
        {
            NbtInt Height = Data.Get<NbtInt>("height");

            return Height.IntValue;
        }

        private byte ReadLocked(string version)
        {
            version = Regex.Replace(version, @"[^0-9.]", "");

            CurrentVersion = Version.Parse(version);

            int result = CurrentVersion.CompareTo(MinecraftVersion);

            if (result > 0)
            {
                NbtByte Locked = Data.Get<NbtByte>("locked");

                return Locked.ByteValue;
            }

            return NOT_USED_IN_VERSION;
        }

        private byte ReadScale()
        {

            NbtByte Scale;

            Scale = Data.Get<NbtByte>("scale");

            return Scale.ByteValue;
        }

        private byte ReadTrackingPosition()
        {
            NbtByte TrackingPosition;

            TrackingPosition = Data.Get<NbtByte>("trackingPosition");

            return TrackingPosition.ByteValue;
        }

        private byte ReadUnlimitedTracking()
        {
            NbtByte UnlimitedTracking;

            UnlimitedTracking = Data.Get<NbtByte>("unlimitedTracking");

            return UnlimitedTracking.ByteValue;
        }

        private int ReadXCenter()
        {
            NbtInt XCenter;

            XCenter = Data.Get<NbtInt>("xCenter");

            return XCenter.IntValue;
        }

        private int ReadZCenter()
        {
            NbtInt ZCenter;

            ZCenter = Data.Get<NbtInt>("zCenter");

            return ZCenter.IntValue;
        }

        private byte[] ReadColors()
        {
            NbtByteArray Colors;

            Colors = Data.Get<NbtByteArray>("colors");

            return Colors.ByteArrayValue;
        }
    }
}
