namespace iSintu_Bookings
{
    partial class RegisterGuest
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
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Passw_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Surname_txt
            // 
            this.Surname_txt.Location = new System.Drawing.Point(350, 136);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(100, 23);
            this.Surname_txt.TabIndex = 1;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(350, 192);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(100, 23);
            this.Email_txt.TabIndex = 2;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(350, 81);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 23);
            this.Name_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surname";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(354, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Create an account with us on Isintu Bookings ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // Passw_txt
            // 
            this.Passw_txt.Location = new System.Drawing.Point(350, 251);
            this.Passw_txt.Name = "Passw_txt";
            this.Passw_txt.Size = new System.Drawing.Size(100, 23);
            this.Passw_txt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirm Password";
            // 
            // Confirm_txt
            // 
            this.Confirm_txt.Location = new System.Drawing.Point(350, 311);
            this.Confirm_txt.Name = "Confirm_txt";
            this.Confirm_txt.Size = new System.Drawing.Size(100, 23);
            this.Confirm_txt.TabIndex = 15;
            // 
            // RegisterGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passw_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Surname_txt);
            this.Name = "RegisterGuest";
            this.Text = "RegisterGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Surname_txt;
        private TextBox Email_txt;
        private TextBox Name_txt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label2;
        private Label label6;
        private TextBox Passw_txt;
        private Label label1;
        private TextBox Confirm_txt;
    }
}