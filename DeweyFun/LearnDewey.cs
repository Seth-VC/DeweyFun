using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyFun
{
    public partial class LearnDewey : Form
    {
        public LearnDewey()
        {
            InitializeComponent();
        }

        //back button to return to main window
        private void Backbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I Hope you paid attention !!!");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
