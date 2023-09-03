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
            /*string username = User_txt.Text;
            string password = Passw_txt.Text;
            string Output = ""; 

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

            while (rd.Read())
            {
                    Output =    Output + rd.GetValue(0);
            }
            MessageBox.Show(Output);


            if (rd.HasRows)
            {
                rd.Read();
                MessageBox.Show("Login successfull.");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
            */

            string username, password;
            username = User_txt.Text;
            password = Passw_txt.Text;
            try
            {
                con.Open();
                SqlCommand comm1 = new SqlCommand("SELECT * FROM Guest WHERE guest_name = '" + User_txt.Text + "' AND guest_password = '" + Passw_txt.Text + "'", con);
                SqlCommand comm2 = new SqlCommand("SELECT * FROM Employees WHERE employees_name = '" + User_txt.Text + "' AND employees_password = '" + Passw_txt.Text + "'", con);
                myAdapter = new SqlDataAdapter();
                mydataSet = new DataTable();

                myAdapter.SelectCommand = comm1;
                myAdapter.Fill(mydataSet);

                if (mydataSet.Rows.Count > 0)
                {
                    username = User_txt.Text;
                    password = Passw_txt.Text;
                    SqlParameter myParameter = new SqlParameter("guest_name", User_txt.Text);
                    comm1.Parameters.Add(myParameter);
                    SqlParameter myParameter1 = new SqlParameter("guest_password", Passw_txt.Text);
                    comm1.Parameters.Add(myParameter1);
                    SqlDataReader rd = comm1.ExecuteReader();
                    SqlDataReader rd2 = comm2.ExecuteReader();
                    string Output = "";

                    int I = 0;
                    while (rd.Read())
                    {

                        if ((rd.GetValue(I) == myParameter) && (rd.GetValue(I) == myParameter1))
                        {
                            MessageBox.Show("Login successful");

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            User_txt.Clear();
                            Passw_txt.Clear();
                            //to focus on username
                            User_txt.Focus();
                        }

                        I++;
                    }



                    /*Dashboard myfrmDashboard = new Dashboard();
                    myfrmDashboard.Show();
                    this.Hide();*/
                }


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            con.Close();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Passw_txt.Clear();
            User_txt.Clear();

        }
    }
}