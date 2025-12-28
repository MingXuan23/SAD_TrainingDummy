using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training20251224
{
    public partial class reward : Form1

    {
        public static int option = 0;
        public reward(bool show)
        {
            InitializeComponent();
            button4.Visible = show;
            option = 0;
        }

        private void reward_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            option = 1;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            option = 2;
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = 3;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
