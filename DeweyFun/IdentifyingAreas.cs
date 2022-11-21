using System.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace DeweyFun
{
    public partial class IdentifyingAreas : Form
    {
        //variables
        public int correctCount = 0;

        public IdentifyingAreas()
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

        //method to return to the main application screen
        private void BackButtton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        //method to compare answers to the correct answers in  dictionary
        private void CompareButton_Click(object sender, EventArgs e)
        {
            //clearing items when selecting play
            NumberView.Items.Clear();
            NameView.Items.Clear();

            //new instance of the DeweyDictionary class
            DeweyDictionary dew = new DeweyDictionary();

            //dictionary to store questions
            Dictionary<string, string> questions = new Dictionary<string, string>();

            //variables
            Random rand = new Random(); // Creating a variable using the Random class
            
            int AvalCateg = dew.deweyCategories.Count;
            int totalQuestions = 7;
            int number = 0;
            int diff = AvalCateg - totalQuestions;

            //new function to shuffle through the strings and values stored in DeweyDictionary class (Dictionary)
            //store the values in a new dictionary
            Dictionary<string, string> shuffle = dew.deweyCategories.OrderBy(
            x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);

            //using the shuffle function to add the 4 randomized strings to the question side
            for (int i = 0; i < shuffle.Count - diff; i++)
            {
                questions.Add(shuffle.ElementAt(i).Key, shuffle.ElementAt(i).Value);
            }

            //switching the values with a list
            List<int> randNumberList = new List<int>();
            int randNumber;

            //for statement to check no duplicated question are added
            for (int i = 0; i < questions.Count; i++)
            {
                do
                {
                    randNumber = rand.Next(questions.Count);
                }
                while (randNumberList.Contains(randNumber));
                randNumberList.Add(randNumber);
            }

           //interate over 
            for (int i = 0; i < questions.Count; i++)
            {
                for (int j = i; j < randNumberList.Count;)
                {
                    // only 4 numbers are added to listView
                    if (number++ <= 3)
                    {
                        //random numbers to listView
                        NumberView.Items.Add(questions.ElementAt(i).Key.ToString());
                    }
                    
                    //random descriptions to listView
                    NameView.Items.Add(questions.ElementAt(j).Value.ToString());

                    break;
                }
            }

            //list to store the call numbers
            var callNumbers = new List<string>();

            //assisting the selected call numbers to list
            foreach (ListViewItem s in NumberView.Items)
            {
                //addding call numbers to the list
                callNumbers.Add(s.Text);
            }

            //ordering
            callNumbers = callNumbers.OrderBy(x => Guid.NewGuid()).ToList();

            //clearning numbers 
            NumberView.Items.Clear();

            foreach (var item in callNumbers)
            {
                NumberView.Items.Add(item);
            }

        }
        private void MatchButton_Click(object sender, EventArgs e)
        {

            // Error handling to ensure the user has selected an item from each column
            if (NumberView.SelectedItems.Count > 0 && NameView.SelectedItems.Count > 0)
            {
                // Creating a new instance of the Dictionary class
                DeweyDictionary Deweycategory = new DeweyDictionary();

                // Variables to store the currently selected item in each column            
                var numberCall = NumberView.SelectedItems[0].Text;
                var description = NameView.SelectedItems[0].Text;

                if (numberCall == null || description == null)
                {
                    MessageBox.Show("Please Select One Item From Both Sides To Be Able To Match The Columns");
                }

                //variable to store the matched description with number in the located disctionary
                var mDescription = Deweycategory.deweyCategories[numberCall];

                //determines selected number matches selected description
                if (description == mDescription)
                {
                    //incrementing count of answers the user has correct
                    correctCount++;

                    //iterate over the number column, removes correctly matched items
                    for (int i = NumberView.Items.Count - 1; i >= 0; i--)
                    {
                        //selected number
                        if (NumberView.Items[i].Selected)
                        {
                            //removing selected form listView
                            NumberView.Items[i].Remove();
                        }
                    }

                    // Removing the selected item from the second column to indicate that the answer was correct
                    for (int i = NameView.Items.Count - 1; i >= 0; i--)
                    {
                        // If statement to see the selected description
                        if (NameView.Items[i].Selected)
                        {
                            // Removing the selected item in the listView
                            NameView.Items[i].Remove();
                        }
                    }

                    MessageBox.Show("That is Correct: " + mDescription + " " + numberCall + "\n" + "Your score: " + correctCount.ToString() + "/14");

                    //incrementing the progress bar 
                    PlayerProgressBar.Increment(correctCount);

                    // If statement to clear the columns until the game ends
                    if (correctCount == 4) //|| correctCount == 8 || correctCount == 12 || correctCount == 13)
                    {
                        NumberView.Items.Clear();
                        NameView.Items.Clear();
                        MessageBox.Show("Continue playing to complete the progress bar, Come on? You can do it!!!");
                        badge.Image = Image.FromFile(@"G:\Varsity\3rd year\Semester 2\PROG7312\ST10084107 Seth Pretorius PROG7312 Task 2\ST10084107 Seth Pretorius PROG7312 Task 2\DeweyFun v2.0\DeweyFun\Resources\badgeimage2.jpg");
                    }

                    if (correctCount == 8)
                    {
                        NumberView.Items.Clear();
                        NameView.Items.Clear();
                        MessageBox.Show("Continue playing to complete the progress bar, Come on? You can do it!!!");
                        badge.Image = Image.FromFile(@"G:\Varsity\3rd year\Semester 2\PROG7312\ST10084107 Seth Pretorius PROG7312 Task 2\ST10084107 Seth Pretorius PROG7312 Task 2\DeweyFun v2.0\DeweyFun\Resources\badgeimage.jpg");
                    }


                    if (correctCount == 12)
                    {
                        MessageBox.Show("Well Done!!!...You filled the Bar.");
                        badge.Image = Image.FromFile(@"G:\Varsity\3rd year\Semester 2\PROG7312\ST10084107 Seth Pretorius PROG7312 Task 2\ST10084107 Seth Pretorius PROG7312 Task 2\DeweyFun v2.0\DeweyFun\Resources\badgeimage1");
                    }

                    if (correctCount == 14)
                    {
                        MessageBox.Show("Well done you wone, Please play again!!!");
                    }
                }
                else
                {
                    MessageBox.Show("This is Incorrect, try again");
                }
            }
            else
            {
                MessageBox.Show("Make sure you Only select one item from each column at a time!...When all answers are correct start game again to continue your progress :)");
            }
        }

        //how to Play
        private void HowToButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                "1st: Generate the 2 columns by selecting lets start.\n\n" +
                "Your aim is to Match the colums together, the category description and its decimal. You can do this starting with eitehr side.\n\n +" +
                "The progress bar will fill with each correct match.\n\n" +
                "2nd: Select from either side and once you have selected 1 from each side , select Match.\n\n" +
                "3rd: After x4 correct matches, reselect Lets Start to continue and gaining more in your progress bar in order to fill it. 14 correct will give you the win!"
                );
        }

       
    }
}
