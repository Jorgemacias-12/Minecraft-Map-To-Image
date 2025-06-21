using System.IO;
using NBTMap_Explorer.Helpers;

namespace NBTMap_Explorer.Services
{
    public static class MinecraftInstallation
    {
        public static bool IsMinecraftJavaInstalled => Directory.Exists(Minecraft.JAVA_INSTALLATION_PATH);
        public static bool IsMinecraftBedrockInstalled => Directory.Exists(Minecraft.BEDROCK_INSTALLATION_PATH);

        public static string JavaEditionError = string.Empty;
        public static string BedrockEditionError = string.Empty;

        public static bool JavaEditionHasSaves()
        {
            try
            {
                string[] saves = Directory.GetDirectories(Minecraft.JAVA_SAVES_PATH);

                return IsMinecraftJavaInstalled && saves.Length > 0;
            }
            catch (Exception ex)
            {
                JavaEditionError = ex.Message;
                return false;
            }
        }


        public static bool BedrockEditionHasSaves()
        {
            try
            {
                string[] saves = Directory.GetDirectories(Minecraft.BEDROCK_SAVES_PATH);

                return IsMinecraftBedrockInstalled && saves.Length > 0;
            }
            catch (Exception ex)
            {
                BedrockEditionError = ex.Message;
                return false;
            }
        }


    }
}
