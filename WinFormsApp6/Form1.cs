namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxTasks.Items.Add(textBoxTask.Text);
            textBoxTask.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex); 
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxTasks.SelectedIndex;
            string task = listBoxTasks.SelectedItem.ToString();

            Font strikeoutFont = new Font(listBoxTasks.Font, FontStyle.Strikeout);

            listBoxTasks.Items[selectedIndex] = task; 
            listBoxTasks.Font = strikeoutFont; 
        }
    }
}
