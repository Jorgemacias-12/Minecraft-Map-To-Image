namespace NBTMap_Explorer.Config
{
    public static class PreferencesManager
    {
        public static string CustomMinecraftJavaEditionPath
        {
            get => Properties.Settings.Default.CustomMinecraftPath;
            set
            {
                Properties.Settings.Default.CustomMinecraftPath = value;
                Properties.Settings.Default.Save();
            }
        }

        public static void ResetCustomMinecraftJavaEditionPath()
        {
            Properties.Settings.Default.CustomMinecraftPath = string.Empty;
            Properties.Settings.Default.Save();
        }
    }
}
