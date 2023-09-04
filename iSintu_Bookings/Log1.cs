using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSintu_Bookings
{
    public partial class Log1: Form
    {
        public Log1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B74G1VM;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;
        public static string username, password;

        private void Login_btn_Click(object sender, EventArgs e)
        {
            username = User_txt.Text;
            password = Passw_txt.Text;
            try
            {
                con.Open();
                SqlCommand commG = new SqlCommand("SELECT * FROM Guest WHERE guest_name = '" + User_txt.Text + "' AND guest_password = '" + Passw_txt.Text + "'", con);
                SqlCommand commE = new SqlCommand("SELECT * FROM Employees WHERE employee_name = '" + User_txt.Text + "' AND employee_password = '" + Passw_txt.Text + "'", con);
                myAdapter = new SqlDataAdapter();
                mydataSet = new DataTable();

                myAdapter.SelectCommand = commG;
                myAdapter.SelectCommand = commE;
                myAdapter.Fill(mydataSet);

                if (mydataSet.Rows.Count > 0)
                {
                    username = User_txt.Text;
                    password = Passw_txt.Text;

                    Booking booking = new Booking();
                    booking.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    User_txt.Clear();
                    Passw_txt.Clear();
                    //to focus on username
                    User_txt.Focus();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            con.Close();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Passw_txt.Clear();
            User_txt.Clear();
        }

        private void Hide_cbx_CheckedChanged(object sender, EventArgs e)
        {

            if (Hide_cbx.Checked)
            {
                Passw_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Passw_txt.UseSystemPasswordChar = true;
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            RegisterGuest register = new RegisterGuest();
            register.Show();
            this.Hide();
        }
    }
}
