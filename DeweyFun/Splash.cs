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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            label1.Parent = loading;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loading.Dispose();
            label1.Dispose();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
