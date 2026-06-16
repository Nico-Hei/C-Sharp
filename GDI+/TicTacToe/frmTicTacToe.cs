using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void frmTicTacToe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen p = new Pen(Color.Blue, 0);

            Brush b = new SolidBrush(Color.Blue);

            Size rectangle = new Size(80, 80);
            Rectangle[] rectangles = {
                new Rectangle(10, 20, rectangle.Width, rectangle.Height), new Rectangle(100, 20, rectangle.Width, rectangle.Height), new Rectangle(190, 20, rectangle.Width, rectangle.Height),
                new Rectangle(10, 110, rectangle.Width, rectangle.Height), new Rectangle(100, 110, rectangle.Width, rectangle.Height), new Rectangle(190, 110, rectangle.Width, rectangle.Height),
                new Rectangle(10, 200, rectangle.Width, rectangle.Height), new Rectangle(100, 200, rectangle.Width, rectangle.Height), new Rectangle(190, 200, rectangle.Width, rectangle.Height)
            };

            
            g.DrawRectangles(p, rectangles);
            g.FillRectangles(b, rectangles);
        }
    }
}
