namespace WinFormsApp7
{
    partial class SettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            chkTheme = new CheckBox();
            cmbLanguage = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(194, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(247, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить настройки";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // chkTheme
            // 
            chkTheme.AutoSize = true;
            chkTheme.Location = new Point(194, 244);
            chkTheme.Name = "chkTheme";
            chkTheme.Size = new Size(95, 19);
            chkTheme.TabIndex = 1;
            chkTheme.Text = "Темная тема";
            chkTheme.UseVisualStyleBackColor = true;
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "" });
            cmbLanguage.Location = new Point(317, 242);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(124, 23);
            cmbLanguage.TabIndex = 2;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbLanguage);
            Controls.Add(chkTheme);
            Controls.Add(btnSave);
            Name = "SettingsForm";
            Text = "Form1";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private CheckBox chkTheme;
        private ComboBox cmbLanguage;
    }
}
