using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeweyFun.CallClass;

namespace DeweyFun
{
    public partial class CallNumbers : Form
    {

        // form controls
        private Button[] optionButtons;
        private Label toFind;
        public static Random r = new Random();
        private EventHandler timer_Tick;

        public CallNumbers()
        {
            InitializeComponent();
            StartGame();
            this.BackColor = Color.Black;
            var timer = new System.Windows.Forms.Timer();
            //change colour every 3s
            timer.Interval = 3000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            //set color in background  
            var colors = new[] { Color.Black, Color.Gray, Color.Teal, Color.Aqua, Color.Brown, Color.BlueViolet, Color.Turquoise };
            var index = DateTime.Now.Second % colors.Length;
            this.BackColor = colors[index];
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        private void StartGame()
        {
            // resetting scoring
            seconds = 0;
            sessionPoints = 0;
            lblTime.Text = seconds.ToString();
            lblHighScore.Text = highScore.ToString();

            // form controls
            optionButtons = new Button[] { btnOption1, btnOption2, btnOption3, btnOption4 };
            toFind = lblToFind;

            PopulateRandomLevel1();
            PopulateNodes(optionButtons);
            SetToFindLabel(toFind);
            lblCurrentPoints.Text = sessionPoints.ToString();
            timer1.Start();
        }

        //-----------------------------------------------------------------------------------------------------------------------
        // Button clicks
        //-----------------------------------------------------------------------------------------------------------------------
        #region
        private void btnOption1_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, optionButtons, lblCurrentPoints))
            {
                StartGame();
               
            };
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, optionButtons, lblCurrentPoints))
            {
                StartGame();
            };
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, optionButtons, lblCurrentPoints))
            {
                StartGame();
            };
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, optionButtons, lblCurrentPoints))
            {
                StartGame();
            };
        }

        /// <summary>
        /// Reset game button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //restart game
            StartGame();
        }

        /// <summary>
        /// Help button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Select the call number and description that is a " +
                "\nhigher level version of the description" +
                "\nlisted at the top of the page", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
            timer1.Start();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------
        // Button clicks
        //-----------------------------------------------------------------------------------------------------------------------

        private void FormFindCallNumbers_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Timer, used to calculate points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = seconds.ToString();
        }

        private void lblToFind_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblHighScore_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentPoints_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            if (highScore <= 1000)
            {
                MessageBox.Show("Continue playing, Try Harder to gain a badge...");
            };

            if (highScore >= 1000)
            {
                MessageBox.Show("Continue playing to complete and get a high score, Come on? You can do it!!!");
                pictureBox1.Image = Image.FromFile(@"G:\Varsity\3rd year\Semester 2\PROG7312\ST10084107 Seth Pretorius PROG7312 Task 2\ST10084107 Seth Pretorius PROG7312 Task 2\DeweyFun v2.0\DeweyFun\Resources\badgeimage.jpg");
            };

            if (highScore >= 2000)
            {
                MessageBox.Show("Continue playing to beat your high score, Come on? You can do it!!!");
                pictureBox1.Image = Image.FromFile(@"G:\Varsity\3rd year\Semester 2\PROG7312\ST10084107 Seth Pretorius PROG7312 Task 2\ST10084107 Seth Pretorius PROG7312 Task 2\DeweyFun v2.0\DeweyFun\Resources\badgeimage1.jpg");
            };

        }
    }
}
