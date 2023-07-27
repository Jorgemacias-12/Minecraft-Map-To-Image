using System;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.forms
{
    public partial class MinecraftMapToImageForm : BaseForm
    {
        public MinecraftMapToImageForm()
        {
            InitializeComponent();
        }

        private void MinecraftMapToImageForm_Load(object sender, EventArgs e)
        {
            Dashboard.ButtonClicked += Dashboard_ButtonClicked;
        }

        private void Dashboard_ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            MapsView.Save = btn.Text;
        }
    }
}
