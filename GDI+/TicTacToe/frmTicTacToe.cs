using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Rectangle[] rectangles = {
                new Rectangle(10, 20, 80, 80), new Rectangle(100, 20, 80, 80), new Rectangle(190, 20, 80, 80),
                new Rectangle(10, 110, 80, 80), new Rectangle(100, 110, 80, 80), new Rectangle(190, 110, 80, 80),
                new Rectangle(10, 200, 80, 80), new Rectangle(100, 200, 80, 80), new Rectangle(190, 200, 80, 80)
            };

            //Rectangle r = new Rectangle(10, 20, 80, 80);
            //g.DrawRectangle(p, r);
            //g.FillRectangle(b, r);
            g.DrawRectangles(p, rectangles);
            g.FillRectangles(b, rectangles);
        }
    }
}
