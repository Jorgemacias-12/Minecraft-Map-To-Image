using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftVersionReader
    {
        #region Class Constants
        private readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private readonly static string MINECRAFT_SAVES_VERSIONS_PATH = Path.Combine(APPDATA_PATH, ".minecraft", "versions");
        #endregion

        #region Class Constructor
        public MinecraftVersionReader()
        { 
        }
        #endregion

        #region Class Methods
        public void LoadMinecraftVersions(List<MinecraftVersion> MinecraftVersions)
        {
            try
            {
                string[] MinecraftSaveVersions = Directory.GetDirectories(MINECRAFT_SAVES_VERSIONS_PATH);

                foreach (string MinecraftSaveVersion in MinecraftSaveVersions)
                {
                    MinecraftVersion MinecraftVersion;

                    MinecraftVersion = new MinecraftVersion(Path.GetFileName(MinecraftSaveVersion), MinecraftSaveVersion);

                    MinecraftVersions.Add(MinecraftVersion);
                }
            }
            catch (Exception) { }
        }
        #endregion
    }
}
