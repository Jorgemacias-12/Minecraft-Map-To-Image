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
    public partial class MinecraftEditionView : UserControl
    {
        private Image _Image;
        private String _EditionName;
        private MinecraftEdition _Edition;
        private MinecraftEditionMapViewerForm _Form;

        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;

                SetImage();
            }
        }

        public string EditionName
        {
            get
            {
                return _EditionName;
            }
            set
            {
                _EditionName = value;

                SetName();
            }
        }
        
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

        public MinecraftEditionView()
        {
            InitializeComponent();
        }

        private void SetImage()
        {
            Pbx_Edition.BackgroundImage = _Image;
            Pbx_Edition.BackgroundImageLayout = ImageLayout.Zoom;
        }
 
        private void SetName()
        {
            Lbl_Title.Text = _EditionName;
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            // Refactor this to implement a form that has in count
            // The MinecraftEdition value.

            Form parent = FindForm();

            switch(_Edition)
            {
                case MinecraftEdition.Java:

                    //new MinecraftEditionMapViewerForm().Show();
                    _Form = new MinecraftEditionMapViewerForm();

                    _Form.Show();

                    _Form.Edition = MinecraftEdition.Java;

                    parent.Close();

                    break;
                case MinecraftEdition.Bedrock:


                    break;
            }
        }
    }
}
