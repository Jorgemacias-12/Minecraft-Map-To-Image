using Minecraft_Map_Renderer.src.logic;
using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public partial class MinecraftMapCard : UserControl
    {
        private string _Name;
        public byte[] Colors = new byte[16384];

        public MinecraftMapCard(string name, byte[] data)
        {
            InitializeComponent();
            
            _Name = name;
            Colors = data;

            Lbl_MapName.Cursor = Cursors.Hand;
            Pbx_MapPreview.Cursor = Cursors.Hand;

            Lbl_MapName.Click += HandleShowMapInfo;
            Pbx_MapPreview.Click += HandleShowMapInfo;

            HandleDrawMapView();
        }

        private void MinecraftMapCard_Load(object sender, EventArgs e)
        {
            Lbl_MapName.Text = _Name;
        }

        private void HandleDrawMapView()
        {
            Pbx_MapPreview.BackgroundImage = MinecraftMapRenderer.DrawMap(Colors, 
                                                                          Pbx_MapPreview.Width,
                                                                          Pbx_MapPreview.Height);
            
            Pbx_MapPreview.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void HandleShowMapInfo(object sender, EventArgs e)
        {
            /* 
             * Todo:
             * Invoke MapInfo Form (and create it)
             */
            //MessageBox.Show(_Colors.Length.ToString());}
            
        }

    }
}
