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
    public partial class ReplaceBooks : Form
    {
        //variables
        public static Random r = new Random();
        private EventHandler timer_Tick;

        public ReplaceBooks()
        {
            this.BackColor = Color.Black;
            InitializeComponent();
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

            private void GenerateRandomNumberButton_Click(object sender, EventArgs e)
        {
            numberList.Clear();
            listView1.Clear();
            progressBar1.Value = 0;

            //list for random calls
            LinkedList<string> numberCalls = new LinkedList<string>();

            //iterate over
            for (int i = 0; i < 10; i++)
            {
                //concatinating the calls
                string numCall = GetRandomNumber() + "." + GetRandomNumberTwo() + " " + GetRandomAuthor();
                numberCalls.AddLast(numCall);
            }

            foreach (var item in numberCalls)
            {
                numberList.Items.Add(item);
            }
        }

        //generate the alphanumerals
        public static string GetRandomAuthor()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[3];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[r.Next(chars.Length)];
            }

            var fString = new String(stringChars);
            return fString;
        }
        //generate the numerals
        public static string GetRandomNumber()
        {
            var chars = "1234567890";
            var stringChars = new char[3];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[r.Next(chars.Length)];
            }

            var fString = new String(stringChars);
            return fString;
        }

        //generate the second call
        public static string GetRandomNumberTwo()
        {
            var chars = "1234567890";
            var stringChars = new char[2];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[r.Next(chars.Length)];
            }

            var fString = new String(stringChars);
            return fString;
        }
        
        private void sendBTN_Click(object sender, EventArgs e)
        {
            //making sure that the user selects a number call - error handling
            if (numberList.SelectedItems.Count == 0)
            {
                MessageBox.Show("selet a call from the list");
            }
            else
            {
                //adding items to second list
                var item = numberList.SelectedItems[0];
                numberList.Items.Remove(item);
                listView1.Items.Add(item);
            }
        }
        //results check method
        private void checkResultsButton_Click(object sender, EventArgs e)
        {
            //check for users, using all 10 calls
            if (listView1.Items.Count == 10)
            {
                //list to store answers
                LinkedList<string> userAnswers = new LinkedList<string>();

                foreach (ListViewItem item in listView1.Items)
                {
                    //selected items then add to list 
                    userAnswers.AddLast(item.Text);
                }

                string[] answerArray = userAnswers.ToArray();

                //sorting and comparing calls
                BubbleSort.Sort(answerArray);

                int correctCount = 0;
                
                //count for user ansers
                for (int i = 0; i < userAnswers.Count; i++)
                {
                    if (userAnswers.ElementAt(i) == answerArray[i])
                    {
                         //count for correct answers
                        correctCount++;
                    }
                }
                //count for progress bar
                for (int i = 0; i < userAnswers.Count; i++)
                {
                    if (userAnswers.ElementAt(i) == answerArray[i])
                    {
                        //progression of progress bar
                        progressBar1.Increment(correctCount);
                    }
                }

                //scoring for the user (message)
                if (correctCount < 7)
                {
                    MessageBox.Show("You scored " + correctCount.ToString() + " out of 10" + "\n" + "Good Effort.");
                }
                else if (correctCount == 8 || correctCount == 9)
                {
                    MessageBox.Show("You scored " + correctCount.ToString() + " out of 10" + "\n" + "Your good at this...");
                }
                else
                {
                    MessageBox.Show("You got " + correctCount.ToString() + " out of 10" +"\n" + "Good Effort!!!");
                }
            }
            else
            {
                MessageBox.Show("Please use all 10 numbers or regenerate.");
            }
        }

        //how to play
        private void InformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1st generate " + "\n\n" +
                "2nd select call to move across " + "\n\n" +
                "3rd to start again click generate again" + "\n\n" +
                "4th click submit to veiw your results and see viual on progress bar");
        }

        //allow user to go back to the main screen
        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        //allow the user to undo selection
        private void UndoButton_Click(object sender, EventArgs e)
        {
            //handles that the user selects a number call - error handling
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please selet an item from the bottom bar");
            }
            else
            {
                //adding the selected item to second list view, removing it from the first list
                var item = listView1.SelectedItems[0];
                listView1.Items.Remove(item);
                numberList.Items.Add(item);
            }
        }

    }
}
