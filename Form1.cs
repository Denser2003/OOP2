using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Round
{
    public partial class Form1 : Form
    {
        public static List<Figure> figures = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(1007, 661);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void ViewElemntChanger(bool view)
        {
            textBox2.Visible = view;
            label2.Visible = view;
            
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Round round = new Round(e.X, e.Y, int.Parse(textBox1.Text));
                    round.Draw(graph);
                    figures.Add(round);
                    break;
                case 1:
                    
                    Round round1 = new Round(e.X, e.Y, int.Parse(textBox1.Text));
                    Round round2 = new Round(e.X, e.Y, int.Parse(textBox2.Text));
                    round1.Draw(graph);
                    round2.Draw(graph);
                    figures.Add(round1);
                    figures.Add(round2);
                    break;
                case 2:
                    Rectangle rectangle = new Rectangle(e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    rectangle.Draw(graph);
                    figures.Add(rectangle);
                    break;

                case 3:
                    ViewElemntChanger(false);
                    Square square = new Square(e.X, e.Y, int.Parse(textBox1.Text));
                    square.Draw(graph);
                    figures.Add(square);
                    break;
                case 4:
                    Triangle triangle = new Triangle(e.X, e.Y, int.Parse(textBox1.Text));
                    triangle.Draw(graph);
                    figures.Add(triangle);
                    break;
                case 5:
                    ViewElemntChanger(false) ;
                    Rectangle line = new Rectangle(e.X, e.Y, int.Parse(textBox1.Text), 1);
                    line.Draw(graph);
                    figures.Add(line);
                    break;
            }
            pictureBox1.Refresh();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(1007, 661);
        }

        private void Out_Button_Click(object sender, EventArgs e)
        {
            foreach (Figure f in figures)
            {
                Debug.WriteLine("=========================");
                Debug.WriteLine(f.GetType());
                Debug.WriteLine($"x: {f.posx}");
                Debug.WriteLine($"y: {f.posy}");
                Debug.WriteLine($"size1: {f.size1}");
                if (f.size2 != 0)
                {
                    Debug.WriteLine($"size2: {f.size2}");
                }
                Debug.WriteLine($"Площадь: {f.area}");
                Debug.WriteLine($"Длина: {f.len}");
                Debug.WriteLine("=========================");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
