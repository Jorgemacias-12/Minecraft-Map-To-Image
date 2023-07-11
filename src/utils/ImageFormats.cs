using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.utils
{
    public class ImageFormats
    {
        private static Dictionary<string, ImageFormat> _Formats;
        
        public static Dictionary<string, ImageFormat> Formats
        {
            get
            {
                if (_Formats == null) HandleLoadFormats();

                return _Formats;
            }

        }

        private static void HandleLoadFormats()
        {
            _Formats = new Dictionary<string, ImageFormat>
            {
                { "bmp", ImageFormat.Bmp },
                { "gif", ImageFormat.Gif },
                { "jpeg", ImageFormat.Jpeg },
                { "jpg", ImageFormat.Jpeg },
                { "png", ImageFormat.Png }
            };
        }
    }
}
