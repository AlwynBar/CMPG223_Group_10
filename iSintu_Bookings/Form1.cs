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
    }
}
/*string username = txtLoginUsername.Text;
string password = txtLoginPassword.Text;

string sql = "SELECT * FROM tblUsers WHERE userUsername = '" + username + "'";

using (OleDbConnection connection = new OleDbConnection(connectionString))
{
    adapter = new OleDbDataAdapter(sql, connectionString);
    dataTable = new DataTable();
    dataTable.Clear();
    adapter.Fill(dataTable);
}

if (dataTable.Rows.Count == 1)
{
    DataRow row;
    row = dataTable.Rows[0];
    if ((string)row["userPassword"] == password)
    {
        loadMessages();
        fillMessages();
        changeScroller();

        accountLoggedIn = (string)row["userUsername"];
        accountLoggedID = (int)row["userID"];
        lblMessageboardAccount.Text = "User: " + accountLoggedIn;
        lblNewmessageAccount.Text = "User: " + accountLoggedIn;

        if ((bool)row["userAdmin"] == true)
            btnMessageboardAdminPage.Visible = true;
        else
            btnMessageboardAdminPage.Visible = false;

        pnlfrmMessageboard.Visible = true;
        pnlfrmLogin.Visible = false;
    }
    else
        MessageBox.Show("The password you have entered is incorrect!", "Error");
}
else
    MessageBox.Show("Account does not exist", "Error");
        }*/