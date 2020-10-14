using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gate
{
    public partial class AdminHome : Form
    {



        //Globle Variables 
        //int uid;


        public AdminHome()
        {
            
            InitializeComponent();
        }







        // // // // // // //             Begining Basic Design             // // // // // // //

        private void AdminHome_Load(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(70, 0, 0, 0);    // panel transparent
            pnlBox1.BackColor = Color.FromArgb(100, 0, 0, 0);   // panel transparent


            lblDate.Text = DateTime.Now.ToLongDateString();  // Date Settings
        }



        // // // // // // //             End Basic Design             // // // // // // //



        // // // // // // //             Begining Timer             // // // // // // //
        
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }
        // // // // // // //             End Timer             // // // // // // //








        // // // // // // //             Begining Of Menu Items             // // // // // // //


        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Update u = new Update(1);
            u.Show();
        }

        private void btnVehicle_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            VehicleSettings vs = new VehicleSettings();
            vs.Show();
        }

        private void btnSO_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            SecurityOfficerSettings sos = new SecurityOfficerSettings();
            sos.Show();
        }

        private void btnLogOut_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            LogOut lo = new LogOut(1);
            lo.Show();
        }

        private void btnHistory_MouseClick(object sender, MouseEventArgs e)
        {
            History h = new History(1);
            h.Show();
        }




        // // // // // // //             End Of Menu Items             // // // // // // //


    }
}
