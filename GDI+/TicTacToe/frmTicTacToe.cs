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
using static System.Windows.Forms.AxHost;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        static int state = 0;

        public static int State
        {
            get => state;
            set
            {
                if (value > 2) state = 1;
                else state = value;
            }
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 20;

            for(int i = 1; i <= 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    FieldTile tile = new FieldTile();
                    tile.Location = new Point(x,y);
                    this.Controls.Add(tile);
                    y += 110;
                }
                x += 110;
                y = 20;
            }
        }
    }
}
