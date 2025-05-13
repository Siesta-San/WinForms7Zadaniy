namespace WinFormsApp6
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
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            listBoxTasks = new ListBox();
            buttonDelete = new Button();
            buttonComplete = new Button();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(220, 110);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(312, 23);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Введите вашу задачу...";
            textBoxTask.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(387, 139);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить задачу";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(304, 241);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(111, 19);
            listBoxTasks.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(220, 139);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить задачу";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(293, 181);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(159, 23);
            buttonComplete.TabIndex = 4;
            buttonComplete.Text = "Сделано";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonComplete);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxTasks);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private Button buttonAdd;
        private ListBox listBoxTasks;
        private Button buttonDelete;
        private Button buttonComplete;
    }
}
