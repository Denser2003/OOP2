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
    public class Square : Figure
    {
        public Square(int posx, int posy, int size1) : base(posx, posy, size1) { }
        public override double len
        {
            get { return size1 * 4; }
        }
        public override double area
        {
            get { return size1 * size1; }
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(Pens.Tomato, posx - size1 / 2, posy - size1 / 2, size1, size1);
            
        }
    }
}
