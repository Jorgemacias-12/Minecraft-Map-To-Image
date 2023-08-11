using Minecraft_Map_Renderer.src.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.forms
{
    public partial class MinecraftEditionMapViewerForm : BaseForm
    {
        private MinecraftEdition _Edition;
        public MinecraftEdition Edition
        {
            get
            {
                return _Edition;
            }
            set
            {
                _Edition = value;
            }
        }

        public MinecraftEditionMapViewerForm()
        {
            InitializeComponent();
        }

        private void Dashboard_ButtonClicked(object sender, EventArgs e)
        {
            // Get selected save 
            Button btn = (Button)sender;

            MinecraftMaps.Save = btn.Text;
        }

        private void MinecraftEditionMapViewerForm_Load(object sender, EventArgs e)
        {
        }
    }
}
