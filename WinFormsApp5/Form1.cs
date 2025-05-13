namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            double fahrenheit = double.Parse(textBoxTemperature.Text);
            double celsius = (fahrenheit - 32) * 5 / 9;
            labelResult.Text = $"{celsius:F2} °C";
        }

        private void buttonCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textBoxTemperature.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            labelResult.Text = $"{fahrenheit:F2} °F";
        }
    }
}
