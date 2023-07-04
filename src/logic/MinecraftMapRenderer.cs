using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftMapRenderer
    {
        #region Class Constants
        private const int MAP_SIZE = 128;
        #endregion

        #region Class Variables

        #endregion

        public static Bitmap DrawMap(Byte[] MapBytes, int Width, int Size)
        {
            Bitmap _ = new Bitmap(Width, Size);

            int EmptyPixelCounter = 0;
            int PixelPerBlock = 1;
            int TempWidth = Width;

            while ((TempWidth /= 2) >= MAP_SIZE) PixelPerBlock *= 2;

            for (int column = 0; column < MAP_SIZE; column++)
            {
                for(int row = 0; row < MAP_SIZE; row++)
                {
                    using(Graphics g = Graphics.FromImage(_))
                    {
                        bool Sucess;
                        int id;
                        Byte PixelValue;
                        Color PixelColor;

                        id = column + row * MAP_SIZE;

                        PixelValue = MapBytes[id];

                        Sucess = MinecraftColorsTable.ColorDictionary.TryGetValue(PixelValue, out PixelColor);
                        
                        if (!Sucess)
                        {
                            EmptyPixelCounter++;
                            continue;
                        }

                        using(SolidBrush brush = new SolidBrush(PixelColor))
                        {
                            g.FillRectangle(brush,
                                            column * PixelPerBlock,
                                            row * PixelPerBlock,
                                            PixelPerBlock,
                                            PixelPerBlock);
                        }

                    }
                }
            }

            return _;
        }
        
    }
}
