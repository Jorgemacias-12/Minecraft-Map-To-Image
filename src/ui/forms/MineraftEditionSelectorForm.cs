using Minecraft_Map_Renderer.Properties;
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
    public partial class MinecraftEditionSelectorForm : Form
    {
        public MinecraftEditionSelectorForm()
        {
            InitializeComponent();
        }

        private void MinecraftEditionSelectorForm_Load(object sender, EventArgs e)
        {
            Mev_Bedrock.Image = Resources.bedrock_block;
            Mev_Java.Image = Resources.glass_block_3d;

            Mev_Bedrock.EditionName = "Bedrock";
            Mev_Java.EditionName = "Java";

            Mev_Bedrock.Edition = logic.MinecraftEdition.Bedrock;
            Mev_Java.Edition = logic.MinecraftEdition.Java;
        }
    }
}
