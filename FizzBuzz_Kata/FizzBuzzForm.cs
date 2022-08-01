// Function Kata „FizzBuzz“
// Ferdinand Marx - KATA01 - 01.08.22
// This is for training purposes

namespace FizzBuzz_Kata
{
    public partial class FizzBuzzKata : Form
    {
        public FizzBuzzKata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FizzBuzz();
        }

        public void FizzBuzz()
        {
            //Initializing vars 
            int FizzBuzzCounter = 1;
            bool FizzBuzzMatch = false;

            while(FizzBuzzCounter < 101)
            {
                //Setting Matchswitch to false
                FizzBuzzMatch = false;

                //Return Fizz - condition 1
                if (FizzBuzzCounter % 3 == 0)
                {
                    mainTextbox.Text = mainTextbox.Text + "Fizz" + Environment.NewLine;
                    FizzBuzzMatch = true;
                }

                //Return Buzz - condition 2
                if (FizzBuzzCounter % 5 == 0)
                {
                    mainTextbox.Text = mainTextbox.Text + "Buzz" + Environment.NewLine;
                    FizzBuzzMatch = true;
                }

                //Return FizzBuzz - condition 3
                if (FizzBuzzCounter % 3 == 0 && FizzBuzzCounter % 5 == 0)
                {
                    mainTextbox.Text = mainTextbox.Text + "FizzBuzz" + Environment.NewLine;
                    FizzBuzzMatch = true;
                }

                //Return normal digit
                if (FizzBuzzMatch == false)
                {
                    mainTextbox.Text = mainTextbox.Text + FizzBuzzCounter.ToString() + Environment.NewLine;
                }

                //Increase Counter 
                FizzBuzzCounter += 1;

            }

        }


    }
}