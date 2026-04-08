namespace Bmi_Calculator
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
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(220, 357);
            progressBar1.Maximum = 40;
            progressBar1.Minimum = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 45);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(437, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 32);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(219, 84);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Height [m]";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(219, 183);
            button1.Name = "button1";
            button1.Size = new Size(330, 45);
            button1.TabIndex = 3;
            button1.Text = "Calculate BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(220, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 32);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(437, 84);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 5;
            label2.Text = "Weight [kg]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(229, 313);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 6;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(219, 264);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 7;
            label4.Text = "BMI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(229, 313);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AccessibleName = "label3";
            label6.Cursor = Cursors.No;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(290, 264);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AccessibleName = "label3";
            label7.Cursor = Cursors.No;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(290, 264);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
