namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string greeting = "Привет, " + name + "!";
            labelGreeting.Text = greeting;
        }
    }
}
