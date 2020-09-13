using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class frmTicTacToe : Form
    {
        bool turn = true;//if true =X,else it is O
        int turnCount = 0;//To keep track of number of button click
        public frmTicTacToe()
        {
            InitializeComponent();
            
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnA1.Text = "";
            btnA1.Enabled = true;
            btnA2.Text = "";
            btnA2.Enabled = true;
            btnA3.Text = "";
            btnA3.Enabled = true;
            btnB1.Text = "";
            btnB1.Enabled = true;
            btnB2.Text = "";
            btnB2.Enabled = true;
            btnB3.Text = "";
            btnB3.Enabled = true;
            btnC1.Text = "";
            btnC1.Enabled = true;
            btnC2.Text = "";
            btnC2.Enabled = true;
            btnC3.Text = "";
            btnC3.Enabled = true;

        }

        private void abountMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Tic Tac Toe game written by grewal", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnA1_Click(object sender, EventArgs e)
        {

        }
        private void click_Button(object sender, EventArgs e)

        {
            Button btn = (Button)sender;
            if (turn)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O";
            }
            turn = !turn;
            turnCount++;
            btn.Enabled = false;
            check_For_winner();
        }
        private void check_For_winner()
        {
            string winnerChar = "";
            bool winner = false;

            //To check each row

            if ((btnA1.Text == btnB1.Text) && (btnC1.Text == btnB1.Text) && (btnA1.Text != ""))
            {
                winner = true;
                winnerChar = btnA1.Text;
            }
            else if ((btnA2.Text == btnB2.Text) && (btnC2.Text == btnB2.Text) && (btnA2.Text != ""))
            {
                winner = true;
                winnerChar = btnA2.Text;
            }
            else if ((btnA3.Text == btnB3.Text) && (btnC3.Text == btnB3.Text) && (btnA3.Text != ""))
            {
                winner = true;
                winnerChar = btnA3.Text;
            }
            //To check each column

            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (btnA1.Text != ""))

            {
                winner = true;
                winnerChar = btnA1.Text;
            }
            if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (btnB1.Text != ""))

            {
                winner = true;
                winnerChar = btnB2.Text;
            }
            if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (btnC1.Text != ""))

            {
                winner = true;
                winnerChar = btnC1.Text;
            }
            //To check diag
            if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (btnA1.Text != ""))

            {
                winner = true;
                winnerChar = btnA1.Text;
            }

            if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (btnC1.Text != ""))

            {
                winner = true;
                winnerChar = btnA3.Text;
            }
            if (winner == true)

            {
                MessageBox.Show(winnerChar + " won the game", "Yay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableButtons();
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("No one won the game", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void disableButtons()

        {
            try
            {
                foreach (Control c in Controls)

                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
    }

}