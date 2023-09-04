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
    public partial class RegisterGuest : Form
    {
       
        public RegisterGuest()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B74G1VM;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.Open();
            string query = "INSERT INTO Guest (guest_id, guest_name, guest_surname, guest_password) VALUES (@Pass, @Name, @Surname, @Email)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Passw_txt.Text);
            cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
            cmd.Parameters.AddWithValue("@Surname", Surname_txt.Text);
            cmd.Parameters.AddWithValue("@Email", Email_txt.Text);

            //Not sure what to do with the check in checkbox just enter recommended code here.
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
