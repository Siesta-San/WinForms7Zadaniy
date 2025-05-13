using System.Text;

namespace WinFormsApp7
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Load += SettingsForm_Load;
            btnSave.Click += btnSave_Click;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            cmbLanguage.Items.Clear();
            cmbLanguage.Items.AddRange(new object[] { "English", "Русский" });
            cmbLanguage.SelectedIndex = 0; 

            LoadSettings(); 
            ApplyTheme(chkTheme.Checked);


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            ApplyTheme(chkTheme.Checked);
            MessageBox.Show("Настройки сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cmbLanguage.SelectedItem.ToString() == "English")
            {
                chkTheme.Text = "Dark theme";
            }
            else
            {
                chkTheme.Text = "Темная тема";
            }
        }

        private void ApplyTheme(bool isDark)
        {
            var backColor = isDark ? Color.FromArgb(40, 40, 40) : SystemColors.Control;
            var foreColor = isDark ? Color.White : SystemColors.ControlText;

            this.BackColor = backColor;
            this.ForeColor = foreColor;

            ApplyThemeToControls(this.Controls, backColor, foreColor);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, Color backColor, Color foreColor)
        {
            foreach (Control control in controls)
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;

                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls, backColor, foreColor);
            }
        }

        private void SaveSettings()
        {
            var sb = new StringBuilder();
            sb.AppendLine("[Settings]");
            sb.AppendLine($"Theme={(chkTheme.Checked ? "Dark" : "Light")}");
            sb.AppendLine($"Language={cmbLanguage.SelectedItem}");

            File.WriteAllText("settings.ini", sb.ToString(), Encoding.UTF8);
        }

        private void LoadSettings()
        {
            if (File.Exists("settings.ini"))
            {
                var lines = File.ReadAllLines("settings.ini", Encoding.UTF8);
                foreach (var line in lines)
                {
                    if (line.StartsWith("Theme="))
                        chkTheme.Checked = line.Split('=')[1] == "Dark";
                    else if (line.StartsWith("Language="))
                        cmbLanguage.SelectedItem = line.Split('=')[1];
                }
            }
        }
    }
}
