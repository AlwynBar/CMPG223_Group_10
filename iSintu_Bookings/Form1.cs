using System.Data;

namespace iSintu_Bookings
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        private void button1_Click(object sender, EventArgs e)
        {
            //Log in window where members can log in
            string username, password;
            username = User_txt.Text;
            password = Passw_txt.Text;
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Guest WHERE guest_name = '" + User_txt.Text + "' AND guest_password = '" + Passw_txt.Text + "'", con);
                myAdapter = new SqlDataAdapter();
                mydataSet = new DataTable();

                myAdapter.SelectCommand = comm;
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
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void btn_Login_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {

        }
    }
}
