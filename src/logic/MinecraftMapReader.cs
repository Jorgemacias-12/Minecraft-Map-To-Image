using fNbt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMapReader
    {
        private NbtFile MapFile;
        private NbtCompound Root;
        private NbtCompound Data;
        private MinecraftMap Map;
        
        public async Task<List<MinecraftMap>> LoadMaps(string SavePath)
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
                                       ReadDimension(),
                                       ReadLocked(),
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

        private string ReadDimension()
        {
            NbtString Dimension;

            Dimension = Data.Get<NbtString>("dimension");

            return Dimension.StringValue;
        }

        private byte ReadLocked()
        {
            NbtByte Locked;

            Locked = Data.Get<NbtByte>("locked");

            return Locked.ByteValue;
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
