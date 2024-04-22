namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = " " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = " " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = " " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = " " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = " " + c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label4.Text = string.Empty;
        }
    }
}