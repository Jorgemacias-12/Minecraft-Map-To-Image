using NBTMap_Explorer.Helpers;
using NBTMap_Explorer.Models;
using NBTMap_Explorer.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBTMap_Explorer.Services
{
    public class JavaMapLoader : IMapLoader
    {
        public Task<IEnumerable<MinecraftWorld>> LoadAllWorldsAsync(MinecraftEdition edition)
        {
            throw new NotImplementedException();
        }

        public Task<MinecraftWorld?> LoadWorldAsync(string worldPath)
        {
            throw new NotImplementedException();
        }
    }
}
