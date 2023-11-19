using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Round
{
    public class Rectangle : Figure
    {
        public Rectangle(int posx, int posy, int size1, int size2) : base(posx, posy, size1, size2) { }
        public override double len
        {
            get { return size1 * 2 + size2 * 2; }
        }
        public override double area
        {
            get { return size1 * size2; }
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(Pens.Tomato, posx - size1 / 2, posy - size2 / 2, size1, size2);
        }
    }
}
