using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBTMap_Explorer.Helpers
{
    public enum MinecraftEdition
    {
        Java,
        Bedrock
    }

    public enum MinecraftDimension
    {
        Overworld,
        Nether,
        End
    }

    public class Minecraft
    {
        public readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public readonly static string LOCAL_APPLICATION_DATA = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public readonly static string JAVA_INSTALLATION_PATH = Path.Combine(APPDATA_PATH, ".minecraft");
        public readonly static string JAVA_VERSIONS_PATH = Path.Combine(JAVA_INSTALLATION_PATH, "versions");
        public readonly static string BEDROCK_INSTALLATION_PATH = Path.Combine(LOCAL_APPLICATION_DATA,
                                                                              "Packages",
                                                                              "Microsoft.MinecraftUWP_8wekyb3d8bbwe");

        public readonly static string JAVA_SAVES_PATH = Path.Combine(JAVA_INSTALLATION_PATH, "saves");
        public readonly static string BEDROCK_SAVES_PATH = Path.Combine(BEDROCK_INSTALLATION_PATH,
                                                                                  "LocalState",
                                                                                  "games",
                                                                                  "com.mojang",
                                                                                  "minecraftWorlds");
    }
}
