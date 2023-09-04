using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace iSintu_Bookings
{
    public partial class ManageBookings : Form
    {
        public ManageBookings()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B74G1VM;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        int i = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "";
            if (Name_txt.Text != "")
            {
                query = "UPDATE Guests SET guest_name = '" + Name_txt.Text;
                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.ExecuteNonQuery();
            }
            else if (Surname_txt.Text != "")
            {
                query = "UPDATE Guests SET guest_surname = '" + Surname_txt.Text;
                SqlCommand cmd2 = new SqlCommand(query,con);
                cmd2.ExecuteNonQuery();
            }
            else if (Passw_txt.Text != "")
            {
                query = "UPDATE Guests SET guest_password = '" + Passw_txt.Text;
                SqlCommand cmd3 = new SqlCommand(query, con);
                cmd3.ExecuteNonQuery();
            }
            else if (Email_Txt.Text != "")
            {
                query = "UPDATE Guests SET guest_email = '" + Email_Txt.Text;
                SqlCommand cmd4 = new SqlCommand(query, con);
                cmd4.ExecuteNonQuery();
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("DELETE Guest WHERE guest_id ='" + i + "' ", con);
            comm.ExecuteNonQuery();
            MessageBox.Show("Delete succesfuly executed");

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["guest_Id"].FormattedValue.ToString());
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            Cost_Summary cost = new Cost_Summary();
            cost.Show();
        }

        private void Display_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Guest", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Guest WHERE [guest_name] LIKE @Search + '%",con);
                cmd.Parameters.AddWithValue("@Search", textBox1.Text.Trim());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds;
                textBox1.Focus();
                con.Close();
            }
        }

        private void ASC_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Guest WHERE guest_surname ORDER BY ASC";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sorted in ascending order succesfuly executed");
            con.Close();

        }

        private void DESC_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Guest WHERE guest_surname ORDER BY DESC";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sorted in decending order succesfuly executed");
            con.Close();
        }
    }
}
