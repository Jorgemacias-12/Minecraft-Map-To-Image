using NBTMap_Explorer.Models;
using NBTMap_Explorer.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBTMap_Explorer.Services
{
    public class JavaWorldLoader : IWorldLoader
    {
        public Task<MinecraftMap[]> LoadMapsAsync(string worldPaths)
        {
            throw new NotImplementedException();
        }
    }
}
