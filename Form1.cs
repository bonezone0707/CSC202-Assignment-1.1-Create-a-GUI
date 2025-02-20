namespace First_Project_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox textBox1 = new();
        private TextBox textBox2 = new();
        private TextBox textBox3 = new();
        private Button button1 = new();
        private Button button2 = new();
        private Button button3 = new();
        private Button button4 = new();

        private void InitializeComponent()
        {
            
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(445, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(314, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(176, 244);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(276, 244);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(376, 244);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(476, 244);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(839, 464);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
