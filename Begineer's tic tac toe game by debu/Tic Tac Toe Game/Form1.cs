using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public enum player 
        {
            X, O
        }
        player currentplayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            RestartGame();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentplayer = player.O;
                buttons[index].Text = currentplayer.ToString();
                buttons[index].BackColor = Color.Brown;
                buttons.RemoveAt(index);
                checkGame();
                CpuTimer.Stop();
      
            }
        }

        private void Playerclickbutton(object sender, EventArgs e)
        {
            var button =(Button)sender;
            currentplayer = player .X;
            button.Text = currentplayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Green;
            buttons.Remove(button);
            checkGame();
            CpuTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void checkGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button7.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")

            {
                CpuTimer.Stop();
                MessageBox.Show("Player wins", "Tic Tac Toe");
                playerWinCount++;
                label1.Text = "Player wins: " + playerWinCount;
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                        || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                        || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                        || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                        || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                        || button3.Text == "O" && button7.Text == "O" && button9.Text == "O"
                        || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                        || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                CpuTimer.Stop();
                MessageBox.Show("CPU wins", "Tic Tac Toe");
                CPUWinCount++;
                label2.Text = "CPU wins: " + CPUWinCount;
                RestartGame();
            }
        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6,
                button7, button8, button9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = ".";
                x.BackColor = DefaultBackColor;

            }
        }
    }
}
