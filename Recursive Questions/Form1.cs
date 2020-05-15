using System;
using System.Diagnostics;
using System.Windows.Forms;
/// <summary>
/// Recursive Questions Seamus Kittmer May 15 2020
/// </summary>
namespace Recursive_Questions
{
    public partial class Form1 : Form
    {
        Stopwatch myWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            recursiveSumLabel.Text = recursiveFibonnacciLabel.Text = nonRecursiveFibonnacciLabel.Text = "";
            try
            {
                int entry = Convert.ToInt32(inputTextBox.Text);
                int recursiveSum = RecursiveSum(entry);
                recursiveSumLabel.Text = $"The sum of all the values up to {entry} is {recursiveSum}";
            }
            catch
            {
                recursiveSumLabel.Text = "Please enter a numerical value";
                inputTextBox.Text = "";
            }
        }

        private void fibonnacciButton_Click(object sender, EventArgs e)
        {

            recursiveSumLabel.Text = recursiveFibonnacciLabel.Text = nonRecursiveFibonnacciLabel.Text = "";
            try
            {
                int entry = Convert.ToInt32(inputTextBox.Text);

                myWatch.Start();

                int Fibonnacci = RecursiveFibonnacci(entry);

                myWatch.Stop();
                TimeSpan elapsed = myWatch.Elapsed;

                recursiveFibonnacciLabel.Text = $"The recursive interative search for F({entry}) is {Fibonnacci}, \n completed in {elapsed.TotalMilliseconds}";

                myWatch.Reset();
                myWatch.Start();

                Fibonnacci = nonRecursiveFibonnacci(entry);
                myWatch.Stop();
                elapsed = myWatch.Elapsed;

                nonRecursiveFibonnacciLabel.Text = $"The non-recursive interative search for F({entry}) is {Fibonnacci}, \n completed in {elapsed.TotalMilliseconds}";
            }
            catch
            {
                recursiveSumLabel.Text = "Please enter a numerical value";
                inputTextBox.Text = "";
            }
        }

        public int RecursiveFibonnacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                return (RecursiveFibonnacci(n - 1) + RecursiveFibonnacci(n - 2));
            }
        }
        public int nonRecursiveFibonnacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                int[] f = new int[n + 2];

                f[0] = 0;
                f[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
                return (f[n]);
            }
        }

        public int RecursiveSum(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {//very similar to the factorial method simply change to addition symbol
                return (n + RecursiveSum(n - 1));
            }
        }
    }
}
