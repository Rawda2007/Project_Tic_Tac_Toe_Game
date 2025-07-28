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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool Human = true;
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // الخطوط الأفقيّة
            e.Graphics.DrawLine(pen, 400, 250, 850, 250);
            e.Graphics.DrawLine(pen, 400, 400, 850, 400);

            // الخطوط العموديّة
            e.Graphics.DrawLine(pen, 550, 100, 550, 550);
            e.Graphics.DrawLine(pen, 700, 100, 700, 550);
        }
        void Play_computer()
        {
            int counter = 1;
            Random Num = new Random();
           int num=  Num.Next(1, 9);
            foreach(Control c in this.Controls)
            {
                if(c is Button  btn)
                {
                    if (btn.Enabled == true&&btn.Text!="Reset")
                        { btn.Text = "x";
                            btn.Enabled = false;
                            return;
                        }
                  
                }
            }
         
        }
        void DisableAllButtons()
        {
            foreach(Control c in this.Controls)
            {
                if(c is Button btn&&btn.Text!="Reset")
                {
                    btn.Enabled = false;
                }
            }
        }
        void Reset()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Name != "bReset")
                {
                    btn.Text = "?";
                    btn.Enabled = true;
                }
            }

            Winner.Text = "In Progress";
            TurnPlayer.Text = "Human";
           
        }

        void ClickAnyButton(Button btn)
        {
            
                btn.Text = "o";
                btn.Enabled = false;
            if(status_Player_Winner())
            {
                Winner.Text = TurnPlayer.Text;

                MessageBox.Show("Successfully " + TurnPlayer.Text);
                TurnPlayer.Text = " ";
                DisableAllButtons();
                return;
            }
            TurnPlayer.Text = "Computer";
            Play_computer();
            if (status_Player_Winner())
            {
                Winner.Text = TurnPlayer.Text;

                MessageBox.Show("Successfully " + TurnPlayer.Text);
                TurnPlayer.Text = " ";
                DisableAllButtons();
                return;
            }
            TurnPlayer.Text = "Human";
         
        }
        private bool status_Player_Winner()
        {
            // تحقق من كل حالات الفوز
            if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "?") return true;
            if (b4.Text == b5.Text && b5.Text == b6.Text && b4.Text != "?") return true;
            if (b7.Text == b8.Text && b8.Text == b9.Text && b7.Text != "?") return true;

            if (b1.Text == b4.Text && b4.Text == b7.Text && b1.Text != "?") return true;
            if (b2.Text == b5.Text && b5.Text == b8.Text && b2.Text != "?") return true;
            if (b3.Text == b6.Text && b6.Text == b9.Text && b3.Text != "?") return true;

            if (b1.Text == b5.Text && b5.Text == b9.Text && b1.Text != "?") return true;
            if (b3.Text == b5.Text && b5.Text == b7.Text && b3.Text != "?") return true;

            return false;
        }

        //void Player_Winner()
        //{
        //    if (status_Player_Winner())
        //    {
        //        string winner = Player1 ? "Player 1" : "Player 2";

        //        MessageBox.Show("Successfully " + winner);
        //        Winner.Text = winner + " Wins!";
        //        DisableAllButtons();
        //    }
        //    else
        //    {
        //        // تغيير الدور
        //        Player1 = !Player1;
        //        TurnPlayer.Text = Player1 ? "Player 1" : "Player 2";
        //    }
        //}
        private void b1_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b1);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b9);

        }

        private void b8_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b8);

        }

        private void b4_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b4);

        }

        private void b3_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b3);

        }

        private void b6_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b6);

        }

        private void b5_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b5);

        }

        private void b2_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b2);

        }

        private void b7_Click(object sender, EventArgs e)
        {
            ClickAnyButton(b7);

        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
