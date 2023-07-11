using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Minecraft_Map_Renderer.src.utils
{
    public class Border
    {
        private Color _AllColor;
        private Color _TopColor;
        private Color _BottomColor;
        private Color _LeftColor;
        private Color _RightColor;

        private int _AllSize;
        private int _TopSize;
        private int _BottomSize;
        private int _LeftSize;
        private int _RightSize;

        public Color AllColor
        {
            get
            {
                return _AllColor;
            }
            set
            {
                _AllColor = value;
                _TopColor = value;
                _BottomColor = value;
                _LeftColor = value;
                _RightColor = value;
            }
        }

        public Color TopColor
        {
            get
            {
                return _TopColor;
            }
            set
            {
                if (_AllColor != Color.Transparent) _AllColor = Color.Transparent;

                _TopColor = value;
            }
        }

        public Color BottomColor
        {
            get
            {
                return _BottomColor;
            }
            set
            {
                if (_AllColor != Color.Transparent) _AllColor = Color.Transparent;

                _BottomColor = value;
            }
        }

        public Color LeftColor
        {
            get
            {
                return _LeftColor;
            }
            set
            {
                if (_AllColor != Color.Transparent) _AllColor = Color.Transparent;

                _LeftColor= value;
            }
        }

        public Color RightColor
        {
            get
            {
                return _RightColor;
            }
            set
            {
                if (_AllColor != Color.Transparent) _AllColor = Color.Transparent;

                _RightColor= value;
            }
        }

        public int AllSize
        {
            get
            {
                return _AllSize;
            }
            set
            {
                _TopSize = value;
                _BottomSize = value;
                _LeftSize = value;
                _RightSize = value;
                _AllSize = value;
            }
        }

        public int TopSize
        {
            get
            {
                return _TopSize;
            }
            set
            {
                if (_AllSize != -1) _AllSize = -1;

                _TopSize = value;
            }
        }

        public int BottomSize
        {
            get
            {
                return _BottomSize;
            }
            set
            {
                if (_AllSize != -1) _AllSize = -1;

                _BottomSize = value;
            }
        }

        public int LeftSize
        {
            get
            {
                return _LeftSize;
            }
            set
            {
                if (_AllSize != -1) _AllSize = -1;

                _LeftSize = value;
            }
        }
        public int RightSize
        {
            get
            {
                return _RightSize;
            }
            set
            {
                if (_AllSize != -1) _AllSize = -1;

                _RightSize = value;
            }
        }

        public Border()
        {
        }

        public Border(Color topColor, 
                      Color bottomColor, 
                      Color leftColor, 
                      Color rightColor, 
                      int topSize, 
                      int bottomSize, 
                      int leftSize, 
                      int rightSize)
        {
            TopColor = topColor;
            BottomColor = bottomColor;
            LeftColor = leftColor;
            RightColor = rightColor;
            TopSize = topSize;
            BottomSize = bottomSize;
            LeftSize = leftSize;
            RightSize = rightSize;
        }
    }
}
