using Microsoft.SqlServer.Server;
using System;
using System.IO;

namespace Minecraft_Map_Renderer.src.logic
{
    public class Minecraft
    {
        private static Minecraft _Instance;

        public static Minecraft Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Minecraft();
                }

                return _Instance;
            }
        }

        public readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public readonly static string LOCAL_APPLICATION_DATA = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        
        public readonly static string JAVA_INSTALATION_PATH = Path.Combine(APPDATA_PATH, ".minecraft");
        public readonly static string BEDROCK_INSTALATION_PATH = Path.Combine(LOCAL_APPLICATION_DATA,
                                                                              "Packages",
                                                                              "Microsoft.MinecraftUWP_8wekyb3d8bbwe");

        public readonly static string MINECRAFT_JAVA_SAVES_PATH = Path.Combine(JAVA_INSTALATION_PATH, "saves");
        public readonly static string MINECRAFT_BEDROCK_SAVES_PATH = Path.Combine(BEDROCK_INSTALATION_PATH,
                                                                                  "LocalState",
                                                                                  "games",
                                                                                  "com.mojang",
                                                                                  "minecraftWorlds");

        public bool IsMinecraftJavaInstalled
        {
            get
            {
                return Directory.Exists(JAVA_INSTALATION_PATH);
            }
        }

        public bool IsMinecraftBedrockInstalled
        {
            get
            {
                return Directory.Exists(BEDROCK_INSTALATION_PATH);
            }
        }

        public bool HasSavesJava
        {
            get
            {
                return Directory.Exists(MINECRAFT_JAVA_SAVES_PATH);
            }
        }

        public bool HasSavesBedrock
        {
            get
            {
                return Directory.Exists(MINECRAFT_BEDROCK_SAVES_PATH);
            }
        } 

        private Minecraft()
        {
        }

    }
}
