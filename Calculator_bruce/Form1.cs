using System.Data;

namespace Calculator_bruce
{
    public partial class Form1 : Form
    {
        string calc;
        public Form1()
        {
            InitializeComponent();
        }

        public void button15_Click(object sender, EventArgs e)
        {
            object resultCalc = new DataTable().Compute(calc, null);
            double CalculatedValue = Convert.ToDouble(resultCalc);
             calc = CalculatedValue.ToString();
            textBox1.Text = calc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc += "1";
            textBox1.Text = calc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc += "2";
            textBox1.Text = calc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calc += "3";
            textBox1.Text = calc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calc += "4";
            textBox1.Text = calc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calc += "5";
            textBox1.Text = calc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calc += "6";
            textBox1.Text = calc;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calc += "7";
            textBox1.Text = calc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calc += "8";
            textBox1.Text = calc;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calc += "9";
            textBox1.Text = calc;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calc += "0";
            textBox1.Text = calc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            calc += "+";
            textBox1.Text = calc;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc += "-";
            textBox1.Text = calc;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calc += "X";
            textBox1.Text = calc;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calc += "/";
            textBox1.Text = calc;
        }
   
    
    
    }
}