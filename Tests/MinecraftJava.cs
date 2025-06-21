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
    }
}
