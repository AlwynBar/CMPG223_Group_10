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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = User_txt.Text;
            string password = Passw_txt.Text;

            string connectionString = "Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand("CheckUser", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("Username", User_txt.Text);
            SqlParameter p2 = new SqlParameter("Username", Passw_txt.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                MessageBox.Show("Login successfull.");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}