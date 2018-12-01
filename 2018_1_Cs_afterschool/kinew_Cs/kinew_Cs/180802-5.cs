using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class ppp
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) width = value;
                else throw new Exception("width is integer\n");
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else throw new Exception("height is integer\n");
            }
        }
        public void Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Area() { return this.height * this.width; }
    }
    class _180802_5
    {
    }
}