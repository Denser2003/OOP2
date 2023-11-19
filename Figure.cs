using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    public abstract class Figure
    {
        public int posx;
        public int posy;
        public int size1;
        public int size2;
        public Figure() { }
        public Figure(int posx, int posy, int size1, int size2)
        {
            this.posx = posx;
            this.posy = posy;
            this.size1 = size1;
            this.size2 = size2;
        }
        public Figure(int posx, int posy, int size1)
        {
            this.posx = posx;
            this.posy = posy;
            this.size1 = size1;
        }
        public abstract double len { get; }
        public abstract double area { get; }
        public abstract void Draw(Graphics gr);
    }
}
