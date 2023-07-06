using Minecraft_Map_Renderer.src.logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public class MinecraftMapsView : FlowLayoutPanel
    {
        private event EventHandler<EventArgs> MapSelected;
        private MinecraftSaves minecraftSaves = MinecraftSaves.Instance;

        private string _Save;

        public string Save
        {
            get { return _Save; }
            set
            {
                _Save = value;
                HandleLoadMinecraftMaps();
            }
        }

        public MinecraftMapsView()
        {
            AutoScroll = true;
            Padding = new Padding(20);
        }

        private void HandleLoadMinecraftMaps()
        {
            Controls.Clear();

            if (Save == "") return;

            foreach(MinecraftSave Save in minecraftSaves.Saves)
            {
                if (Save.Name != _Save) continue;

                foreach(MinecraftMap map in Save.Maps)
                {

                    MinecraftMapCard MapCard = new MinecraftMapCard(map)
                    {
                        Width = 128,
                        Height = 128,
                        BackColor = Color.FromArgb(52, 58, 64),
                    };

                    Controls.Add(MapCard);
                }
            }
        }

    }
}
