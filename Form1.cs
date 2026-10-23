namespace WinFormsApp1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowError(string message)
        {
            MessageBox.Show(message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void maxButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b))
            {
                ShowError("Please enter two valid numbers.");
                return;
            }
            ResultLabel.Text = $"Max({a}, {b}) = {Maximum(a, b)}";
        }


        double Maximum(double x, double y)
        {
            return Math.Max(x, y);
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b))
            {
                ShowError("Please enter two valid numbers.");
                return;
            }
            ResultLabel.Text = $"{a} ^ {b} = {Power(a, b)}";
        }

        double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        private void isPrimeButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n))
            {
                ShowError("Please enter a whole number in the first box.");
                return;
            }
            ResultLabel.Text = IsPrime(n) ? $"{n} is prime" : $"{n} is not prime";
        }

        bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n) || n < 0)
            {
                ShowError("Enter a non-negative whole number.");
                return;
            }
            ResultLabel.Text = $"{n}! = {Factorial(n)}";
        }

        long Factorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * Factorial(number - 1);
        }


        private void PowerButton_Click(object sender, EventArgs e)
        {
            powerButton_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            maxButton_Click(sender, e);
        }

        private void PrimeButton_Click(object sender, EventArgs e)
        {
            isPrimeButton_Click(sender, e);
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            factorialButton_Click(sender, e);
        }
    }
}
