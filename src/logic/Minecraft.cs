using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public enum MinecraftEdition
    {
        Java,
        Bedrock
    }

    public enum MinecraftDimension
    {
        Nether = -1,
        Overworld = 0,
        The_End = 1
    }

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
        public readonly static string JAVA_VERSIONS_PATH = Path.Combine(JAVA_INSTALATION_PATH, "versions");
        public readonly static string BEDROCK_INSTALATION_PATH = Path.Combine(LOCAL_APPLICATION_DATA,
                                                                              "Packages",
                                                                              "Microsoft.MinecraftUWP_8wekyb3d8bbwe");

        public readonly static string JAVA_SAVES_PATH = Path.Combine(JAVA_INSTALATION_PATH, "saves");
        public readonly static string BEDROCK_SAVES_PATH = Path.Combine(BEDROCK_INSTALATION_PATH,
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
                return Directory.Exists(JAVA_SAVES_PATH);
            }
        }

        public bool HasSavesBedrock
        {
            get
            {
                return Directory.Exists(BEDROCK_SAVES_PATH);
            }
        }

        private List<MinecraftSave> _JavaSaves;
        private List<MinecraftSave> _BedrockSaves;

        public List<MinecraftSave> JavaSaves
        {
            get
            {
                if (_JavaSaves == null) 
                {
                    _JavaSaves = new List<MinecraftSave>();
                }

                return _JavaSaves;
            }
        }

        public List<MinecraftSave> BedrockSaves
        {
            get
            {
                if (_BedrockSaves == null)
                {
                    _BedrockSaves = new List<MinecraftSave>();
                }

                return _BedrockSaves;
            }
        }

        private Minecraft()
        {
            
        }

        public async Task LoadMinecraftData(MinecraftEdition edition)
        {
            MinecraftSavesLoader _Loader = new MinecraftSavesLoader();

            switch (edition)
            {
                case MinecraftEdition.Java:

                    await _Loader.LoadSaves(JavaSaves, edition);

                    foreach(MinecraftSave save in JavaSaves)
                    {
                        save.Maps = await MinecraftMapsLoader.LoadMaps(save.Path, save.Version);
                    }

                    break;

                case MinecraftEdition.Bedrock:

                    await _Loader.LoadSaves(BedrockSaves, edition);
                    
                    break;
            }

        }

    }
}
