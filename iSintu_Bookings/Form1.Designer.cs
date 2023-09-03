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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Passw_txt = new System.Windows.Forms.TextBox();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Hide_cbx = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.Hide_cbx);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Passw_txt);
            this.groupBox1.Controls.Add(this.User_txt);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Location = new System.Drawing.Point(315, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 518);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(99, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Create An Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "New to Isintu Bookings?   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sign in to Isintu Bookings ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // Passw_txt
            // 
            this.Passw_txt.Location = new System.Drawing.Point(226, 195);
            this.Passw_txt.Name = "Passw_txt";
            this.Passw_txt.Size = new System.Drawing.Size(121, 23);
            this.Passw_txt.TabIndex = 12;
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(226, 125);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(121, 23);
            this.User_txt.TabIndex = 11;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(260, 310);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(102, 36);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Clear";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // Hide_cbx
            // 
            this.Hide_cbx.AutoSize = true;
            this.Hide_cbx.Location = new System.Drawing.Point(353, 197);
            this.Hide_cbx.Name = "Hide_cbx";
            this.Hide_cbx.Size = new System.Drawing.Size(104, 19);
            this.Hide_cbx.TabIndex = 17;
            this.Hide_cbx.Text = "Hide Password";
            this.Hide_cbx.UseVisualStyleBackColor = true;
            this.Hide_cbx.CheckedChanged += new System.EventHandler(this.Hide_cbx_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 672);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private CheckBox Hide_cbx;
    }
}