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
        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*if (Name_txt.Text != "")
            {
                string query = "";

                query = "UPDATE Guests SET guest_name = '" + Name_txt.Text;
                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.ExecuteNonQuery();

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
        }*/
        }
    }
}
