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
    public class Triangle : Figure
    {
        public Triangle(int posx, int posy, int size1) : base(posx, posy, size1) { }
        public override double len
        {
            get { return size1 * 3; }
        }
        public override double area
        {
            get { return (Math.Sqrt(3)/4)*(size1 * size1); }
        }
        public override void Draw(Graphics gr)
        {
            Point[] P =
            {
              new Point(posx, posy),
              new Point(posx + size1 , posy),
              new Point(posx , posy + size1),
            };
            gr.DrawPolygon(Pens.Tomato, P);
        }
    }
}
