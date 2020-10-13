using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            de1.LancerDe(random.Next(1, 4));
            de2.LancerDe(random.Next(1, 4));
            de3.LancerDe(random.Next(1, 4));
        }

        private void de1_Click(object sender, EventArgs e)
        {
            de1.LancerDe(random.Next(1, 4));
        }

        private void de2_Click(object sender, EventArgs e)
        {
            de2.LancerDe(random.Next(1, 4));
        }

        private void de3_Click(object sender, EventArgs e)
        {
            de3.LancerDe(random.Next(1, 4));
        }
    }
}
