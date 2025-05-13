namespace WinFormsApp1
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
            if (radioButton1.Checked)
                textBox3.Text = $"{a} + {b} = {a + b} ";
            else if (radioButton2.Checked)
                textBox3.Text = $"{a} - {b} = {a - b}";
            else if (radioButton3.Checked)
                textBox3.Text = $"{a} * {b} = {a * b} ";
            else if (radioButton4.Checked)
                textBox3.Text = $"{a} / {b} = {(double)a / b}";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) button1.Text = "Сложить";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) button1.Text = "Вычетание";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) button1.Text = "Умножение";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) button1.Text = "Деление";
        }
    }
}
