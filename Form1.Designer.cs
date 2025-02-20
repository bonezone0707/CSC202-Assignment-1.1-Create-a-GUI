#nullable enable

using System;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        public Form1()
        {
            InitializeComponent();
            if (button1 != null) button1.Click += (sender, e) => PerformOperation("+");
            if (button2 != null) button2.Click += (sender, e) => PerformOperation("-");
            if (button3 != null) button3.Click += (sender, e) => PerformOperation("*");
            if (button4 != null) button4.Click += (sender, e) => PerformOperation("/");
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(50, 20);
            this.textBox1.Size = new System.Drawing.Size(100, 20);

            // textBox2
            this.textBox2.Location = new System.Drawing.Point(50, 60);
            this.textBox2.Size = new System.Drawing.Size(100, 20);

            // textBox3 (Result)
            this.textBox3.Location = new System.Drawing.Point(50, 140);
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.ReadOnly = true;

            // button1 (Addition)
            this.button1.Text = "+";
            this.button1.Location = new System.Drawing.Point(50, 100);

            // button2 (Subtraction)
            this.button2.Text = "-";
            this.button2.Location = new System.Drawing.Point(100, 100);

            // button3 (Multiplication)
            this.button3.Text = "*";
            this.button3.Location = new System.Drawing.Point(150, 100);

            // button4 (Division)
            this.button4.Text = "/";
            this.button4.Location = new System.Drawing.Point(200, 100);

            // Add controls to Form
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);

            this.ResumeLayout(false);
            this.PerformLayout(); // Ensure proper layout
        }

        private void PerformOperation(string operation)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = operation switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "*" => num1 * num2,
                    "/" => num2 == 0 ? double.NaN : num1 / num2,
                    _ => 0
                };

                if (double.IsNaN(result))
                {
                    MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox3.Text = result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}