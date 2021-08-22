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
    public partial class TicTacToeForm : Form
    {
         char who = 'o';
         short movement = 0;
        public TicTacToeForm()
        {
            InitializeComponent();
     //Allows to play only after pressing the "new game button"
            tableLayoutPanel1.Enabled = false;
        }

        private void NewGaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'o';
            movement = 0;
            Button[,] buttonsarray = new Button[,] { { B1, B2, B3 }, { B4, B5, B6 }, { B7, B8, B9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttonsarray[i, j].Enabled = true;
                    buttonsarray[i, j].Text = "";
                    buttonsarray[i, j].BackColor = Color.White;
                }
            }
           
            tableLayoutPanel1.Enabled = true;
        }

      // Info about the game
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game is AWSOME!!!");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // The logic needed to establish the winner.

            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.DarkViolet;
            if (who == 'o')
            {
                bt.Text = "o"; 
                if (B1.Text == B2.Text && B2.Text == B3.Text && B2.Text != "" ||
                     B4.Text == B5.Text && B5.Text == B6.Text && B4.Text != "" ||
                     B7.Text == B8.Text && B8.Text == B9.Text && B8.Text != "" ||
                     B1.Text == B4.Text && B4.Text == B7.Text && B4.Text != "" ||
                     B2.Text == B5.Text && B5.Text == B8.Text && B2.Text != "" ||
                     B3.Text == B6.Text && B6.Text == B9.Text && B6.Text != "" ||
                     B1.Text == B5.Text && B5.Text == B9.Text && B5.Text != "" ||
                     B3.Text == B5.Text && B5.Text == B7.Text && B5.Text != "")
                {
                    MessageBox.Show($"The winner is the {who.ToString().ToUpper()}!!! ");
                  // Dosen t  allow to continue playing after one player has won the game
                    tableLayoutPanel1.Enabled = false;
                    return;
                }
                who = 'x';
                movement++;

            }
            else if (who == 'x')
            {
                 bt.Text = "x";
                if (B1.Text == B2.Text && B2.Text == B3.Text && B2.Text != "" ||
                    B4.Text == B5.Text && B5.Text == B6.Text && B4.Text != "" ||
                    B7.Text == B8.Text && B8.Text == B9.Text && B8.Text != "" ||
                    B1.Text == B4.Text && B4.Text == B7.Text && B4.Text != "" ||
                    B2.Text == B5.Text && B5.Text == B8.Text && B2.Text != "" ||
                    B3.Text == B6.Text && B6.Text == B9.Text && B6.Text != "" ||
                    B1.Text == B5.Text && B5.Text == B9.Text && B5.Text != "" ||
                    B3.Text == B5.Text && B5.Text == B7.Text && B5.Text != "")
                {
                    MessageBox.Show($"The winner is the {who.ToString().ToUpper()}!!! ");
                    tableLayoutPanel1.Enabled = false;
                    return;
                }
                who = 'o';
                movement++;
            }
            if (movement == 9)
            {
                MessageBox.Show("The Game is Draw!");
            }
              

            
        }
    }
}
