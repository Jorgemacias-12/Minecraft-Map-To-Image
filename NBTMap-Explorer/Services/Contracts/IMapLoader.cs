using NBTMap_Explorer.Helpers;
using NBTMap_Explorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBTMap_Explorer.Services.Contracts
{
    public interface IMapLoader
    {
        Task<MinecraftWorld?> LoadWorldAsync(string worldPath);
        Task<IEnumerable<MinecraftWorld>> LoadAllWorldsAsync(MinecraftEdition edition);
    }
}
