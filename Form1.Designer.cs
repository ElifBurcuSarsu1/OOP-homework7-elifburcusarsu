namespace WinFormsApp1._1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            MaxButton = new Button();
            PowerButton = new Button();
            PrimeButton = new Button();
            FactorialButton = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // MaxButton
            // 
            MaxButton.Location = new Point(121, 130);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(94, 29);
            MaxButton.TabIndex = 2;
            MaxButton.Text = "MAX";
            MaxButton.UseVisualStyleBackColor = true;
            MaxButton.Click += MaxButton_Click;
            // 
            // PowerButton
            // 
            PowerButton.Location = new Point(221, 130);
            PowerButton.Name = "PowerButton";
            PowerButton.Size = new Size(94, 29);
            PowerButton.TabIndex = 3;
            PowerButton.Text = "POWER";
            PowerButton.UseVisualStyleBackColor = true;
            PowerButton.Click += PowerButton_Click;
            // 
            // PrimeButton
            // 
            PrimeButton.Location = new Point(321, 130);
            PrimeButton.Name = "PrimeButton";
            PrimeButton.Size = new Size(94, 29);
            PrimeButton.TabIndex = 4;
            PrimeButton.Text = "ISPRIME";
            PrimeButton.UseVisualStyleBackColor = true;
            PrimeButton.Click += PrimeButton_Click;
            // 
            // FactorialButton
            // 
            FactorialButton.Location = new Point(421, 130);
            FactorialButton.Name = "FactorialButton";
            FactorialButton.Size = new Size(94, 29);
            FactorialButton.TabIndex = 5;
            FactorialButton.Text = "FACTORIAL";
            FactorialButton.UseVisualStyleBackColor = true;
            FactorialButton.Click += FactorialButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(291, 225);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(58, 20);
            ResultLabel.TabIndex = 6;
            ResultLabel.Text = "RESULT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(FactorialButton);
            Controls.Add(PrimeButton);
            Controls.Add(PowerButton);
            Controls.Add(MaxButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button MaxButton;
        private Button PowerButton;
        private Button PrimeButton;
        private Button FactorialButton;
        private Label ResultLabel;
    }
}
