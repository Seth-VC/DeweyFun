using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DeweyFun
{
    public partial class Form1 : Form
    {
        private EventHandler timer_Tick;

        public Form1()
        {
            this.BackgroundImage = Properties.Resources.Picture;
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer();
            //change the background image every 1.5s  
            timer.Interval = 1500;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            //adding images in list, from resource file
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.Picture);
            lisimage.Add(Properties.Resources.Picture1);
            lisimage.Add(Properties.Resources.Picture2);
            lisimage.Add(Properties.Resources.Picture3);
            lisimage.Add(Properties.Resources.Picture4);
            lisimage.Add(Properties.Resources.Picture5);
            lisimage.Add(Properties.Resources.Picture6);
            lisimage.Add(Properties.Resources.Picture7);
            lisimage.Add(Properties.Resources.Picture8);
            lisimage.Add(Properties.Resources.Picture9);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }

        //replace books game
        private void ReplaceBooksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome...lets show you how to work with the Dewey Decimal System !!!");
            ReplaceBooks rb = new ReplaceBooks();
            rb.Show();
            this.Hide();
        }

        //Identifying Area's game
        private void Identifyingbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome...Lets play a game with idenetifying Areas !!!");
            IdentifyingAreas ia = new IdentifyingAreas();
            ia.Show();
            this.Hide();
        }
        //Quiz game
        private void Quizbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Get Ready!...");
            CallNumbers cc = new CallNumbers();
            cc.Show();
            this.Hide();
        }

        //Learning page for users to review what the dewey decimal system looks like before playing
        private void Learnbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lets have a look at what the Dewey decimal system is... :)");
            LearnDewey ld = new LearnDewey();
            ld.Show();
            this.Hide();
        }
    }
}

