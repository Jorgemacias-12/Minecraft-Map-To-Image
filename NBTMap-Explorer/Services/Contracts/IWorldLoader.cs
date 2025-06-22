using NBTMap_Explorer.Models;

namespace NBTMap_Explorer.Services.Contracts
{
    public interface IWorldLoader
    {
        Task<MinecraftMap[]> LoadMapsAsync(string worldPaths);
    }
}
