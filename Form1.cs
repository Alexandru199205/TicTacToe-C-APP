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
         // The logig needed to establish the winner.
            who = 'o';
            movement = 0;
            B1.Enabled = true; B1.Text = ""; B1.BackColor = Color.White;
            B2.Enabled = true; B2.Text = ""; B2.BackColor = Color.White;
            B3.Enabled = true; B3.Text = ""; B3.BackColor = Color.White;
            B4.Enabled = true; B4.Text = ""; B4.BackColor = Color.White;
            B5.Enabled = true; B5.Text = ""; B5.BackColor = Color.White;
            B6.Enabled = true; B6.Text = ""; B6.BackColor = Color.White;
            B7.Enabled = true; B7.Text = ""; B7.BackColor = Color.White;
            B8.Enabled = true; B8.Text = ""; B8.BackColor = Color.White;
            B9.Enabled = true; B9.Text = ""; B9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
        }

      // Info about the game
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game is AWSOME!!!");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Orange;
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
