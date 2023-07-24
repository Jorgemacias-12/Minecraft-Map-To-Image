using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_Renderer.src.logic
{
    public class MinecraftSavesLoader
    {
        public MinecraftSavesLoader()
        {

        }

        public async Task LoadSaves(List<MinecraftSave> Saves, MinecraftEdition edition)
        {
            string[] MinecraftSavesPath;
            MinecraftSave Save;

            switch(edition)
            {
                case MinecraftEdition.Java:

                    MinecraftSavesPath = await Task.Run(() =>
                    {
                        return Directory.GetDirectories(Minecraft.JAVA_SAVES_PATH);
                    });
                    
                    foreach(string SavePath in MinecraftSavesPath)
                    {
                        Save = new MinecraftSave(Path.GetFileName(SavePath),
                                                 SavePath);

                        if (Save is null) continue;

                        Saves.Add(Save);
                    }

                    break;

                case MinecraftEdition.Bedrock:

                    MinecraftSavesPath = await Task.Run(() =>
                    {
                        return Directory.GetDirectories(Minecraft.BEDROCK_SAVES_PATH);
                    });

                    // Implement this later :P
                    break;
            }
        } 
    }
}
