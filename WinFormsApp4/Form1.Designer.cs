namespace WinFormsApp4
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
            buttonSetInitial = new Button();
            buttonIncrement = new Button();
            labelCount = new Label();
            textBoxInitialCount = new TextBox();
            SuspendLayout();
            // 
            // buttonSetInitial
            // 
            buttonSetInitial.Location = new Point(165, 116);
            buttonSetInitial.Name = "buttonSetInitial";
            buttonSetInitial.Size = new Size(108, 26);
            buttonSetInitial.TabIndex = 0;
            buttonSetInitial.Text = "button1";
            buttonSetInitial.UseVisualStyleBackColor = true;
            buttonSetInitial.Click += buttonSetInitial_Click;
            // 
            // buttonIncrement
            // 
            buttonIncrement.Location = new Point(340, 116);
            buttonIncrement.Name = "buttonIncrement";
            buttonIncrement.Size = new Size(142, 26);
            buttonIncrement.TabIndex = 1;
            buttonIncrement.Text = "button2";
            buttonIncrement.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(258, 177);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(38, 15);
            labelCount.TabIndex = 2;
            labelCount.Text = "label1";
            // 
            // textBoxInitialCount
            // 
            textBoxInitialCount.Location = new Point(165, 78);
            textBoxInitialCount.Name = "textBoxInitialCount";
            textBoxInitialCount.Size = new Size(317, 23);
            textBoxInitialCount.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInitialCount);
            Controls.Add(labelCount);
            Controls.Add(buttonIncrement);
            Controls.Add(buttonSetInitial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSetInitial;
        private Button buttonIncrement;
        private Label labelCount;
        private TextBox textBoxInitialCount;
    }
}
