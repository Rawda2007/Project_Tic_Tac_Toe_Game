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
        static bool Player1 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
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

        void XORO(Button button)
        {
            if (button.Text != "?") return; // لا تسمح بالضغط مرة ثانية

            if (Player1)
                button.Text = "o";
            else
                button.Text = "x";

            button.Enabled = false;
        }

        void DisableAllButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Name != "bReset")
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
            TurnPlayer.Text = "Player 1";
            Player1 = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TurnPlayer.Text = "Player 1";
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

        void Player_Winner()
        {
            if (status_Player_Winner())
            {
                string winner = Player1 ? "Player 1" : "Player 2";

                MessageBox.Show("Successfully " + winner);
                Winner.Text = winner + " Wins!";
                DisableAllButtons();
            }
            else
            {
                // تغيير الدور
                Player1 = !Player1;
                TurnPlayer.Text = Player1 ? "Player 1" : "Player 2";
            }
        }

        // أحداث الأزرار

        private void b1_Click(object sender, EventArgs e)
        {
            XORO(b1);
            Player_Winner();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            XORO(b2);
            Player_Winner();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            XORO(b3);
            Player_Winner();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            XORO(b4);
            Player_Winner();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            XORO(b5);
            Player_Winner();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            XORO(b6);
            Player_Winner();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            XORO(b7);
            Player_Winner();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            XORO(b8);
            Player_Winner();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            XORO(b9);
            Player_Winner();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // أحداث غير مستخدمة
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
