using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSintu_Bookings
{
    public partial class Cost_Summary : Form
    {
        public Cost_Summary()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Total_lbl.Text = "Total: " + Booking.totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void Cost_Summary_Load_1(object sender, EventArgs e)
        {
            User_lbl.Text = Log1.username;
            House_lbl.Text = Booking.guestHName;
            Area_lbl.Text = Booking.areaType;
            Act_lbl.Text = Activities.activityType;
            CostH_lbl.Text = Booking.housePrice.ToString();
            costA_lbl.Text = Booking.areaPrice.ToString();
            costAct_lbl.Text= Activities.costOfActivities.ToString();
        }
    }
}
