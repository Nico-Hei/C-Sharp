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
        public static int draw_counter = 0;
        public static int[] state_list = new int[9];

        public static int State
        {
            get => state;
            set
            {
                if (value > 2) state = 1;
                else state = value;
            }
        }

        public static bool checkForWin(int state)
        {
            // Horizontal
            if (state_list[0] == state && state_list[1] == state && state_list[2] == state) return true;
            if (state_list[3] == state && state_list[4] == state && state_list[5] == state) return true;
            if (state_list[6] == state && state_list[7] == state && state_list[8] == state) return true;

            // Diagonal
            if (state_list[0] == state && state_list[4] == state && state_list[8] == state) return true; // top-left to bottom-right
            if (state_list[2] == state && state_list[4] == state && state_list[6] == state) return true; // top-right to bottom-left

            return false;
        }

        public static bool checkForDraw()
        {
            if (draw_counter == 9) return true;
            else return false;
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 20;
            int temp_pos = 0;

            for(int i = 1; i <= 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    FieldTile tile = new FieldTile(temp_pos);
                    tile.Location = new Point(x,y);
                    this.Controls.Add(tile);
                    y += 110;
                    temp_pos++;
                }
                x += 110;
                y = 20;
            }
        }
    }
}
