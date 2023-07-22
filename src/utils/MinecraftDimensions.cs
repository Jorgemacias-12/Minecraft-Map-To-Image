using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.utils
{
    public class MinecraftDimensions
    {
        public static Dictionary<int, string> dimensions = new Dictionary<int, string>()
        {
            {-1, "Nether" },
            {0, "Overworld" },
            {1, "The end" }
        };
    }
}
