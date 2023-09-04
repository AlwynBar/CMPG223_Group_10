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
        public static float housePrice = 0;
        public static float areaPrice = 0;
        public static float totalPrice = 0;
        public static string guestHName = "";
        public static string areaType = "";

        public Booking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B74G1VM;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.Open();
            string query = "";

            query = "INSERT INTO Booking (booking_checkIn, booking_checkOut, booking_payment, guest_Id, activity_Id, house_number) VALUES (@DateIn, @DateOut, @Payment, @Guest, @Activity, @House)";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.Parameters.AddWithValue("@DateIn", dateTimePicker1.Value);
            cmd1.Parameters.AddWithValue("@DateOut", dateTimePicker2.Value);
            cmd1.Parameters.AddWithValue("@Payment", totalPrice);
            cmd1.Parameters.AddWithValue("@Guest", Log1.username);
            cmd1.Parameters.AddWithValue("@Activity", Activities.selectedTotal);
            cmd1.Parameters.AddWithValue("@House", guestHName);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (expG_chb.Checked)
            {
                housePrice = 600;
                totalPrice = totalPrice + housePrice;

                if (resE_rdb.Checked)
                {
                    areaPrice = 150;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Resedential Area";
                }
                else if (riverE_rdb.Checked)
                {
                    areaPrice = 200;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Next To River";
                }
                else if (mtnE_rdb.Checked)
                {
                    areaPrice = 250;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Mountain Side";
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                guestHName = "Explorer Guesthouse";
            }
            else if (wbG_chb.Checked) 
            {
                housePrice = 800;
                totalPrice = totalPrice + housePrice;

                if (resE_rdb.Checked)
                {
                    areaPrice = 150;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Resedential Area";
                }
                else if (riverE_rdb.Checked)
                {
                    areaPrice = 200;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Next To River";
                }
                else if (mtnE_rdb.Checked)
                {
                    areaPrice = 250;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Mountain Side";
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                guestHName = "Willow Brooke Guesthouse";
            }  
            else if (ndG_chb.Checked)
            {
                housePrice = 950;
                totalPrice = totalPrice + housePrice;

                if (resE_rdb.Checked)
                {
                    areaPrice = 150;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Resedential Area";
                }
                else if (riverE_rdb.Checked)
                {
                    areaPrice = 200;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Next To River";
                }
                else if (mtnE_rdb.Checked)
                {
                    areaPrice = 250;
                    totalPrice = totalPrice + areaPrice;
                    areaType = "Mountain Side";
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                guestHName = "Ndlunkulu Guesthouse";
            }
            else if (mtG_chb.Checked)
            {
                housePrice = 1200;
                totalPrice = totalPrice + housePrice;
                guestHName = "Mountain Villa";
            }
            else
            {
                MessageBox.Show("Please select a guesthouse type. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            

            Cost_Summary cost_Summary = new Cost_Summary();
            cost_Summary.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (expG_chb.Checked)
            {
                expGuest = 600;
                totalPrice = totalPrice + expGuest;

                if (resE_rdb.Checked)
                {
                    resArea = 150;
                    totalPrice = totalPrice + resArea;
                }
                else if (riverE_rdb.Checked)
                {
                    riverArea = 200;
                    totalPrice = totalPrice + riverArea;
                }
                else if (mtnE_rdb.Checked)
                {
                    mtnArea = 250;
                    totalPrice = totalPrice + mtnArea;
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (wbG_chb.Checked)
            {
                wbGuest = 800;
                totalPrice = totalPrice + wbGuest;

                if (resW_rdb.Checked)
                {
                    resArea = 150;
                    totalPrice = totalPrice + resArea;
                }
                else if (riverW_rdb.Checked)
                {
                    riverArea = 200;
                    totalPrice = totalPrice + riverArea;
                }
                else if (mtnW_rdb.Checked)
                {
                    mtnArea = 250;
                    totalPrice = totalPrice + mtnArea;
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ndG_chb.Checked)
            {
                ndGuest = 950;
                totalPrice = totalPrice + ndGuest;

                if (resN_rdb.Checked)
                {
                    resArea = 150;
                    totalPrice = totalPrice + resArea;
                }
                else if (riverN_rdb.Checked)
                {
                    riverArea = 200;
                    totalPrice = totalPrice + riverArea;
                }
                else if (mtnN_rdb.Checked)
                {
                    mtnArea = 250;
                    totalPrice = totalPrice + mtnArea;
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mtG_chb.Checked)
            {
                mtGuest = 1200;
                totalPrice = totalPrice + mtGuest;
            }
            else
            {
                MessageBox.Show("Please select a guesthouse type. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            Activities activities = new Activities();
            activities.Show();
        }
    }
}
