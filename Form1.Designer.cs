namespace LogFormApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Fullname = new TextBox();
            UserName = new TextBox();
            Password = new TextBox();
            Enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 0;
            label1.Text = "FIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 177);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 107);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // Fullname
            // 
            Fullname.Location = new Point(238, 41);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(422, 31);
            Fullname.TabIndex = 3;
            // 
            // UserName
            // 
            UserName.Location = new Point(238, 107);
            UserName.Name = "UserName";
            UserName.Size = new Size(422, 31);
            UserName.TabIndex = 4;
            // 
            // Password
            // 
            Password.Location = new Point(238, 177);
            Password.Name = "Password";
            Password.Size = new Size(422, 31);
            Password.TabIndex = 5;
            // 
            // Enter
            // 
            Enter.Location = new Point(116, 272);
            Enter.Name = "Enter";
            Enter.Size = new Size(598, 34);
            Enter.TabIndex = 6;
            Enter.Text = "Register";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Enter);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(Fullname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Fullname;
        private TextBox UserName;
        private TextBox Password;
        private Button Enter;
    }
}
