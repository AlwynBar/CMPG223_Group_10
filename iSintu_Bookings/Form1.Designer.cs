namespace iSintu_Bookings
{
    partial class Login
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            Passw_txt = new TextBox();
            User_txt = new TextBox();
            btn_Login = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Passw_txt);
            groupBox1.Controls.Add(User_txt);
            groupBox1.Controls.Add(btn_Login);
            groupBox1.Location = new Point(315, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 518);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(99, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 49);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(143, 11);
            button2.Name = "button2";
            button2.Size = new Size(121, 32);
            button2.TabIndex = 20;
            button2.Text = "Create An Account";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 19;
            label5.Text = "New to Isintu Bookings?   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 42);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 16;
            label3.Text = "Sign in to Isintu Bookings ";
            // 
            // button1
            // 
            button1.Location = new Point(99, 310);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 195);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 125);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // Passw_txt
            // 
            Passw_txt.Location = new Point(226, 195);
            Passw_txt.Name = "Passw_txt";
            Passw_txt.Size = new Size(121, 23);
            Passw_txt.TabIndex = 12;
            // 
            // User_txt
            // 
            User_txt.Location = new Point(226, 125);
            User_txt.Name = "User_txt";
            User_txt.Size = new Size(121, 23);
            User_txt.TabIndex = 11;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(260, 310);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(102, 36);
            btn_Login.TabIndex = 10;
            btn_Login.Text = "Clear";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 672);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox Passw_txt;
        private TextBox User_txt;
        private Button btn_Login;
        private GroupBox groupBox2;
        private Label label5;
        private Button button2;
    }
}