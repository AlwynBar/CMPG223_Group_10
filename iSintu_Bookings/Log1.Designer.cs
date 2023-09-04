namespace iSintu_Bookings
{
    partial class Log1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hide_cbx = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Passw_txt = new System.Windows.Forms.TextBox();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.Login_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Passw_txt);
            this.groupBox1.Controls.Add(this.User_txt);
            this.groupBox1.Controls.Add(this.Clear_btn);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 441);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.Create_btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(105, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(143, 11);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(121, 32);
            this.Create_btn.TabIndex = 20;
            this.Create_btn.Text = "Create An Account";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
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
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(105, 253);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(120, 36);
            this.Login_btn.TabIndex = 15;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
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
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(261, 253);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(102, 36);
            this.Clear_btn.TabIndex = 10;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Log1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 514);
            this.Controls.Add(this.groupBox1);
            this.Name = "Log1";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Hide_cbx;
        private GroupBox groupBox2;
        private Button Create_btn;
        private Label label5;
        private Label label3;
        private Button Login_btn;
        private Label label2;
        private Label label1;
        private TextBox Passw_txt;
        private TextBox User_txt;
        private Button Clear_btn;
    }
}