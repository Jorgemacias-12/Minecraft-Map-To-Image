using fNbt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMapsReader
    {
        #region Class Variables 
        private readonly MinecraftSaves MinecraftSaves;
        private NbtFile MapFile;
        private NbtCompound Root;
        private NbtCompound Data;

        #endregion

        #region Class Constructor
        public MinecraftMapsReader()
        {
            
        }
        #endregion

        #region Class Methods

        public void LoadMaps(Dictionary<string, List<MinecraftMap>> Maps)
        {
            MinecraftSaves MS = new MinecraftSaves();

            MinecraftMap Map;

            foreach(MinecraftSave Save in MS.Saves)
            {
                string MinecraftMapDataPath = Path.Combine(Save.SavePath, "data");

                
                string[] MapsPath = Directory.GetFiles(MinecraftMapDataPath, "map_*.dat");

                foreach (string MinecraftMapPath in MapsPath)
                {
                    // Load NBT File
                    MapFile = new NbtFile();
                    MapFile.LoadFromFile(MinecraftMapPath);

                    Root = MapFile.RootTag;
                    Data = Root.Get<NbtCompound>("data");

                    Map = new MinecraftMap(ReadDimension(),
                                           ReadLocked(),
                                           ReadScale(),
                                           ReadTrackingPosition(),
                                           ReadUnlimitedTracking(),
                                           ReadXCenter(),
                                           ReadZCenter(),
                                           ReadColors(),
                                           Path.GetFileNameWithoutExtension(MinecraftMapPath));

                    if (Maps.ContainsKey(Save.SaveName))
                    {
                        Maps[Save.SaveName].Add(Map);
                    }

                    if (!Maps.ContainsKey(Save.SaveName))
                    {
                        List<MinecraftMap> MapList = new List<MinecraftMap>();
                        
                        MapList.Add(Map);

                        Maps.Add(Save.SaveName, MapList);
                    }

                }
            }
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

        #endregion
    }
}
