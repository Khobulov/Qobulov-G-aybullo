namespace LogFormApplication
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 0;
            label1.Text = "FIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 114);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 180);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(270, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(454, 31);
            textBox3.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(169, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(534, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnLogin;
    }
}