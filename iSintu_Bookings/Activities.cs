using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace iSintu_Bookings
{
    public partial class Activities : Form
    {
        public Activities()
        {
            InitializeComponent();
        }

        public static float quad = 300;
        public static float paint = 150;
        public static float river = 600;
        public static float hike = 400;
        public static float karting = 250;
        public static float horse = 300;
        public static float price = 0;
        public static int selectedTotal = 1;
        public static string activityType = "";
        public static float costOfActivities = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Quad_chb.Checked)
            {
                price = price + quad;
                activityType = activityType + " Quad Biking ";
                selectedTotal++;
                costOfActivities = costOfActivities + quad;
            }
            else if (Paint_chb.Checked)
            {
                price = price + paint;
                activityType = activityType + " Paint Balling ";
                selectedTotal++;
                costOfActivities = costOfActivities + paint;
            }
            else if (River_chb.Checked)
            {
                price = price + river;
                activityType = activityType + " River Rafting ";
                selectedTotal++;
                costOfActivities = costOfActivities + river;
            }
            else if (Hike_chb.Checked)
            {
                price = price + hike;
                activityType = activityType + " Mountain Hiking ";
                selectedTotal++;
                costOfActivities = costOfActivities + hike;
            }
            else if (Karting_chb.Checked)
            {
                price = price + karting;
                activityType = activityType + " Go Karting ";
                selectedTotal++;
                costOfActivities = costOfActivities + karting;
            }
            else if (Horse_chb.Checked)
            {
                price = price + horse;
                activityType = activityType + " Horseback Riding ";
                selectedTotal++;
                costOfActivities = costOfActivities + horse;
            }

            Booking.totalPrice = price;

            Cost_Summary cost_Summary = new Cost_Summary();
            cost_Summary.Show();
        }

        private void Activities_Load(object sender, EventArgs e)
        {
            price = Booking.totalPrice;
        }
    }
}
