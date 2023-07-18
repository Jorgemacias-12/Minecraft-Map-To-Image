using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public class CustomPanel : Panel
    {
        private Border _Border;
        

        [Browsable(true)]
        public Border Border;

        public CustomPanel()
        {
            Border = new Border();

            Border.AllSize = 0;
            Border.AllColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics,
                                    ClientRectangle,
                                    Border.LeftColor,
                                    Border.LeftSize,
                                    ButtonBorderStyle.Solid,
                                    Border.TopColor,
                                    Border.TopSize,
                                    ButtonBorderStyle.Solid,
                                    Border.RightColor,
                                    Border.RightSize,
                                    ButtonBorderStyle.Solid,
                                    Border.BottomColor,
                                    Border.BottomSize,
                                    ButtonBorderStyle.Solid);
        }
    }
}
