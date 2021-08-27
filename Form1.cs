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
        char var = 'o';
        short movement = 0;
        public TicTacToeForm()
        {
            InitializeComponent();
            //Allows to play only after pressing the "new game button"
            tableLayoutPanel1.Enabled = false;
        }

        private void NewGaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var = 'o';
            movement = 0;
            Button[,] btns1 = new Button[,] { { B1, B2, B3 }, { B4, B5, B6 }, { B7, B8, B9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btns1[i, j].Enabled = true;
                    btns1[i, j].Text = "";
                    btns1[i, j].BackColor = Color.White;
                }
            }
            tableLayoutPanel1.Enabled = true;
        }

        // Info about the game
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game is AWSOME asa si asa!!!");
        }
        private void Button_Click(object sender, EventArgs e)
        {
            // The logic needed to establish the winner.
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.DarkViolet;
            if (var == 'o')
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
                    MessageBox.Show($"The winner is the {var.ToString().ToUpper()}!!! ");
                    // Dosen t  allow to continue playing after one player has won the game
                    tableLayoutPanel1.Enabled = false;
                    return;
                }
                var = 'x';
                movement++;

            }
            else if (var == 'x')
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
                    MessageBox.Show($"The winner is the {var.ToString().ToUpper()}!!! ");
                    tableLayoutPanel1.Enabled = false;
                    return;
                }
                var = 'o';
                movement++;
            }
            if (movement == 9)
            {
                MessageBox.Show("The Game is Draw!");
            }

           // Bellow is another way to write the check for 'WIn/lose/tie' code. it s better code 
            //but dor this situation i wll keep the above
            // bt.Enabled = false;
            //var = 'x'; }

            //if (var == 'x')
            //{
            //    bt.Text = "x";
            //    bt.Enabled = false;
            //bt.BackColor = Color.DarkViolet;
            //    var = 'o';
            //}
            //Button[] h1 = new[] { B1, B2, B3 };
            //Button[] h2 = new[] { B4, B5, B6 }; 
            //Button[] h3=new [] { B7, B8, B9 };
            //Button[] V1 = new[] { B1, B4, B7 };
            //Button[] v2 = new[] { B2, B5, B8 };
            //Button[] v3=new []{ B3, B6, B9 };
            //Button[] diag1 = new[] { B1, B5, B9 };
            //Button [] daig2=new[]{ B3, B5, B7 };
            //Button firstitem = h1[0];
            //bool AllEqual = h1.Skip(1).All(b => Button.Equals(firstitem, b));

        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {

        }
    }
}