namespace WinFormsApp5
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
            buttonFahrenheitToCelsius = new Button();
            textBoxTemperature = new TextBox();
            buttonCelsiusToFahrenheit = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // buttonFahrenheitToCelsius
            // 
            buttonFahrenheitToCelsius.Location = new Point(217, 186);
            buttonFahrenheitToCelsius.Name = "buttonFahrenheitToCelsius";
            buttonFahrenheitToCelsius.Size = new Size(96, 29);
            buttonFahrenheitToCelsius.TabIndex = 0;
            buttonFahrenheitToCelsius.Text = "F to C";
            buttonFahrenheitToCelsius.UseVisualStyleBackColor = true;
            buttonFahrenheitToCelsius.Click += buttonFahrenheitToCelsius_Click;
            // 
            // textBoxTemperature
            // 
            textBoxTemperature.Location = new Point(218, 132);
            textBoxTemperature.Name = "textBoxTemperature";
            textBoxTemperature.Size = new Size(234, 23);
            textBoxTemperature.TabIndex = 1;
            textBoxTemperature.Text = "Введите температуру";
            textBoxTemperature.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCelsiusToFahrenheit
            // 
            buttonCelsiusToFahrenheit.Location = new Point(346, 186);
            buttonCelsiusToFahrenheit.Name = "buttonCelsiusToFahrenheit";
            buttonCelsiusToFahrenheit.Size = new Size(106, 29);
            buttonCelsiusToFahrenheit.TabIndex = 2;
            buttonCelsiusToFahrenheit.Text = "C to F";
            buttonCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            buttonCelsiusToFahrenheit.Click += buttonCelsiusToFahrenheit_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(311, 254);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(buttonCelsiusToFahrenheit);
            Controls.Add(textBoxTemperature);
            Controls.Add(buttonFahrenheitToCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFahrenheitToCelsius;
        private TextBox textBoxTemperature;
        private Button buttonCelsiusToFahrenheit;
        private Label labelResult;
    }
}
