namespace iSintu_Bookings
{
    partial class ManageBookings
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Display_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Report_btn = new System.Windows.Forms.Button();
            this.ASC_btn = new System.Windows.Forms.Button();
            this.DESC_btn = new System.Windows.Forms.Button();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Passw_txt = new System.Windows.Forms.TextBox();
            this.Email_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(712, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(197, 302);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(98, 35);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Display_btn
            // 
            this.Display_btn.Location = new System.Drawing.Point(323, 302);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(98, 35);
            this.Display_btn.TabIndex = 3;
            this.Display_btn.Text = "Display All";
            this.Display_btn.UseVisualStyleBackColor = true;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search for name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(656, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Report_btn
            // 
            this.Report_btn.Location = new System.Drawing.Point(657, 302);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(126, 35);
            this.Report_btn.TabIndex = 7;
            this.Report_btn.Text = "Detailed Report";
            this.Report_btn.UseVisualStyleBackColor = true;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // ASC_btn
            // 
            this.ASC_btn.Location = new System.Drawing.Point(439, 302);
            this.ASC_btn.Name = "ASC_btn";
            this.ASC_btn.Size = new System.Drawing.Size(98, 35);
            this.ASC_btn.TabIndex = 8;
            this.ASC_btn.Text = "Sort(ASC)";
            this.ASC_btn.UseVisualStyleBackColor = true;
            this.ASC_btn.Click += new System.EventHandler(this.ASC_btn_Click);
            // 
            // DESC_btn
            // 
            this.DESC_btn.Location = new System.Drawing.Point(553, 302);
            this.DESC_btn.Name = "DESC_btn";
            this.DESC_btn.Size = new System.Drawing.Size(98, 35);
            this.DESC_btn.TabIndex = 9;
            this.DESC_btn.Text = "Sort(DESC)";
            this.DESC_btn.UseVisualStyleBackColor = true;
            this.DESC_btn.Click += new System.EventHandler(this.DESC_btn_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(195, 350);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 23);
            this.Name_txt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Edit/Delete Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Surname_txt
            // 
            this.Surname_txt.Location = new System.Drawing.Point(195, 379);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(100, 23);
            this.Surname_txt.TabIndex = 13;
            // 
            // Passw_txt
            // 
            this.Passw_txt.Location = new System.Drawing.Point(195, 408);
            this.Passw_txt.Name = "Passw_txt";
            this.Passw_txt.Size = new System.Drawing.Size(100, 23);
            this.Passw_txt.TabIndex = 14;
            // 
            // Email_Txt
            // 
            this.Email_Txt.Location = new System.Drawing.Point(195, 437);
            this.Email_Txt.Name = "Email_Txt";
            this.Email_Txt.Size = new System.Drawing.Size(100, 23);
            this.Email_Txt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edit/Delete email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Edit/Delete Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Edit/Delete Surname";
            // 
            // ManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email_Txt);
            this.Controls.Add(this.Passw_txt);
            this.Controls.Add(this.Surname_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.DESC_btn);
            this.Controls.Add(this.ASC_btn);
            this.Controls.Add(this.Report_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageBookings";
            this.Text = "Manage Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button Delete_btn;
        private Button Display_btn;
        private Label label1;
        private TextBox textBox1;
        private Button Report_btn;
        private Button ASC_btn;
        private Button DESC_btn;
        private TextBox Name_txt;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Surname_txt;
        private TextBox Passw_txt;
        private TextBox Email_Txt;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}