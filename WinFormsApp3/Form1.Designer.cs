namespace WinFormsApp3
{
    partial class Form1
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
            buttonGreet = new Button();
            labelGreeting = new Label();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonGreet
            // 
            buttonGreet.Location = new Point(297, 278);
            buttonGreet.Name = "buttonGreet";
            buttonGreet.Size = new Size(153, 23);
            buttonGreet.TabIndex = 0;
            buttonGreet.Text = "ПОПРИВЕТСТВОВАТЬ";
            buttonGreet.UseVisualStyleBackColor = true;
            buttonGreet.Click += buttonGreet_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(302, 314);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(38, 15);
            labelGreeting.TabIndex = 1;
            labelGreeting.Text = "label1";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(297, 237);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(153, 23);
            textBoxName.TabIndex = 2;
            textBoxName.Text = "ВВЕДИТЕ ИМЯ ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxName);
            Controls.Add(labelGreeting);
            Controls.Add(buttonGreet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGreet;
        private Label labelGreeting;
        private TextBox textBoxName;
    }
}
