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
    public partial class FieldTile : UserControl
    {
        public FieldTile()
        {
            InitializeComponent();
        }

        string[] states = new string[] { "?", "X", "O" };
        private void lblField_Click(object sender, EventArgs e)
        {
            if (frmTicTacToe.State == 0) frmTicTacToe.State++;
            lblField.Text = states[frmTicTacToe.State];
            frmTicTacToe.State++;
        }
    }
}
