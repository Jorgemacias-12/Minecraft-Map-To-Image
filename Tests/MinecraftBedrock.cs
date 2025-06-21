using NBTMap_Explorer.Services;

namespace Tests
{
    public class MinecraftBedrock
    {
        [Fact]
        public void IsInstalled()
        {
            // For this test we assume that Minecraft Bedrock is installed on the System.
            var expected = true;
            var actual = MinecraftInstallation.IsMinecraftBedrockInstalled;
            Assert.Equal(expected, actual);
        }
    }
}
