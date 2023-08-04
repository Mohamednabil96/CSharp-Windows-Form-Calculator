namespace Calculator
{
    public partial class Form1 : Form
    {
        string oper = "";
        double res = 0;
        bool isOper = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0" || isOper == true)
            {
                textBox1.Clear();
            };

            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                };
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
            isOper = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            oper = btn.Text;
            res = double.Parse(textBox1.Text);
            isOper = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    textBox1.Text = (res + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (res - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (res * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (res / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            res = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Height = 70;
        }
    }
}