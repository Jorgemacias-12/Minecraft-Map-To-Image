using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public class MinecraftSaveView : Button
    {
        #region Class Variables
        private int _BorderRadius = 1;

        public int BorderRadius
        {
            get { return _BorderRadius; }
            set
            {
                _BorderRadius = value;
                Invalidate();
            }
        }

        private Color _BorderColor = Color.Transparent;
        public Color BorderColor
        {
            get { return _BorderColor; }
            set
            {
                _BorderColor = value;
                Invalidate();
            }
        }

        #endregion

        public MinecraftSaveView(Image splashImage, string Name)
        {
            BackgroundImage = splashImage;
            BackgroundImageLayout = ImageLayout.None;
            Text = Name;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            
            path.AddArc(0, 0, _BorderRadius, _BorderRadius, 180, 90);
            path.AddArc(Width - _BorderRadius, 0, _BorderRadius, _BorderRadius, 270, 90);
            path.AddArc(Width - _BorderRadius, Height - _BorderRadius, _BorderRadius, _BorderRadius, 0, 90);
            path.AddArc(0, Height - _BorderRadius, _BorderRadius, _BorderRadius, 90, 90);
            
            Region = new Region(path);

            ControlPaint.DrawBorder(e.Graphics,
                                    ClientRectangle,
                                    _BorderColor,
                                    ButtonBorderStyle.Solid);

            base.OnPaint(e);
        }


    }
}
