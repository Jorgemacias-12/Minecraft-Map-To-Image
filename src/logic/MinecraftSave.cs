using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSave
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Version { get; set; } 
        public Image SplashIcon { get; set; } 
        public bool HasMaps { get; set; }

        public List<MinecraftMap> Maps = new List<MinecraftMap>();

        public MinecraftSave(string name, 
                             string path, 
                             string version,
                             Image splashIcon, 
                             List<MinecraftMap> maps)
        {
            Name = name;
            Path = path;
            SplashIcon = splashIcon;
            Maps = maps;
            Version = version;
        }

    }
}
