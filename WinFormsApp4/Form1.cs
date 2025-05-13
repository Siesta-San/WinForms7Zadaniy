namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            labelCount.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            count += 1;
            labelCount.Text = count.ToString();
        }

        private void buttonSetInitial_Click(object sender, EventArgs e)
        {
            count = int.Parse(textBoxInitialCount.Text);
            labelCount.Text = count.ToString();
        }
    }
}
