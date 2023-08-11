using Minecraft_Map_Renderer.src.ui.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MinecraftSplashScreenForm form = new MinecraftSplashScreenForm();

            form.Show();

            Application.Run();
        }
    }
}
