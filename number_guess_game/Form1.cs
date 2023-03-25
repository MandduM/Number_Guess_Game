using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_guess_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(txtguess.Text);
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 10);

            if (guess > 10)
            {
                MessageBox.Show("Do not enter numbers greater than 10.");
                Clear();
                txtguess.Focus();
            }
            else if (guess < 1)
            {
                MessageBox.Show("Do not enter numbers less than 1.");
                Clear();
                txtguess.Focus();
            }

            else if (guess == rndNum)
            {
                txtcomputer.Text = rndNum.ToString();
                MessageBox.Show("RIGHT GUESS");
                Clear();
                txtguess.Focus();
            }
            else
            {
                txtcomputer.Text = rndNum.ToString();
                MessageBox.Show("WRONG GUESS");
                //Clear();
                txtguess.Focus();
            }
        }

        private void txtguess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void Clear()
        {
            txtcomputer.Clear();
            txtguess.Clear();
        }
    }
}
