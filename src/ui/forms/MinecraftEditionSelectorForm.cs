using Minecraft_Map_Renderer.Properties;
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
    public partial class MinecraftEditionSelectorForm : Form
    {
        public MinecraftEditionSelectorForm()
        {
            InitializeComponent();
        }


        private void SetUpEditions()
        {
            Mev_Bedrock.Image = Resources.bedrock_block;
            Mev_Java.Image = Resources.glass_block_3d;

            Mev_Bedrock.EditionName = "Bedrock";
            Mev_Java.EditionName = "Java";

            Mev_Bedrock.Edition = MinecraftEdition.Bedrock;
            Mev_Java.Edition = MinecraftEdition.Java;
        }
        
        private void VerifyMinecraftInstalations()
        {
            if (!Minecraft.Instance.IsMinecraftJavaInstalled)
            {
                // Disappear here Mev_Java
                Mev_Java.Dispose();

                // Show a modal to ask for the Java instalation path
            }

            if (!Minecraft.Instance.IsMinecraftBedrockInstalled)
            {
                // Disappear here Mev_Bedrock
                Mev_Bedrock.Dispose();

                // Show a modal to ask for the Bedrock instalation path
            }
        }

        private void MinecraftEditionSelectorForm_Load(object sender, EventArgs e)
        {
            SetUpEditions();
            VerifyMinecraftInstalations();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
