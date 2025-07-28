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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fro = new Form1();
            fro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fro = new Form2();
            fro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
