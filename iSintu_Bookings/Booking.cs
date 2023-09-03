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

namespace iSintu_Bookings
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.Open();
                string query = "";

                query = "UPDATE Booking SET Check-In_Date = '" + dateTimePicker1.Value;
                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.ExecuteNonQuery();

                query = "UPDATE Booking SET Check-Out_Date = '" + dateTimePicker2.Value;
                SqlCommand cmd2 = new SqlCommand(query, con);
                cmd2.ExecuteNonQuery();

                if (checkBox1.Checked)
                {
                    query = "UPDATE Booking SET House_name = 'Explorer Guesthouse'";
                }
                else if (checkBox2.Checked)
                {
                    query = "UPDATE Booking SET House_name = 'Willow Brooke Guesthouse'";
                }
                else if (checkBox3.Checked)
                {
                    query = "UPDATE Booking SET House_name = 'Ndlunkulu Guesthouse'";
                }
                else if (checkBox4.Checked)
                {
                    query = "UPDATE Booking SET House_name = ''";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            con.Close();
        }
    }
}
