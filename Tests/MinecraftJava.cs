using NBTMap_Explorer.Config;
using NBTMap_Explorer.Services;

namespace Tests
{
    public class MinecraftJava
    {
        [Fact] 
        public void IsInstalled()
        {
            // For this test we assume that Minecraft Java is installed on the System.
            var expected = true;

            var actual = MinecraftInstallation.IsMinecraftJavaInstalled;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UserCanChooseMinecraftInstallationPath()
        {
            var expected = true;
            var customPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString(), ".minecraft");

            Directory.CreateDirectory(customPath);

            try
            {
                PreferencesManager.CustomMinecraftJavaEditionPath = customPath;

                Assert.Equal(expected, MinecraftInstallation.IsCustomMinecraftJavaEditionPathSet());
                Assert.Equal(customPath, PreferencesManager.CustomMinecraftJavaEditionPath);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Failed to create custom Minecraft installation path: {ex.Message}");
            }
            finally
            {
                Directory.Delete(customPath, true);
                PreferencesManager.CustomMinecraftJavaEditionPath = "";
            }
        }
    }
}
