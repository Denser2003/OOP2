using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Round
{
    public class Round : Figure
    {
        public Round(int posx, int posy, int size1) : base(posx, posy, size1) { }
        public override double len
        {
            get { return Math.PI * size1 * 2; }
        }
        public override double area
        {
            get { return Math.PI * (size1 * size1); }
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pens.Tomato, posx - size1, posy - size1, size1 * 2, size1 * 2);
        }
    }
}
