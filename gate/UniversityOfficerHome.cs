using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gate
{
    public partial class UniversityOfficerHome : Form
    {



        //Globle Variables 
        int uid;
        String sid;
        int intSID = 0;

        String secID;
        String name;
        String tel;
        String nic;

        

        public UniversityOfficerHome()
        {
           
            InitializeComponent();
        }





        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database







        // // // // // // //             Begining Basic Design             // // // // // // //


        private void UniversityOfficerHome_Load(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(70, 0, 0, 0);    // panel transparent
            pnlBox1.BackColor = Color.FromArgb(100, 0, 0, 0);   // panel transparent
            pnlAuthorized.BackColor = Color.FromArgb(100, 0, 0, 0); // panel transparent
            pnlBox.BackColor = Color.FromArgb(100, 0, 0, 0); // panel transparent

            btnGDuty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  
            btnCSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));

            pnlGateDuty.Visible = true;
            pnlUnauthorized.Visible = false;
            pnlAuthorized.Visible = false;
            pnlCurrentSO.Visible = false;

            lblDate.Text = DateTime.Now.ToLongDateString();  // Date Settings

        }

        private void btnGDuty_MouseClick(object sender, MouseEventArgs e)
        {
            btnGDuty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  
            btnCSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));


            pnlGateDuty.Visible = true;
            pnlUnauthorized.Visible = false;
            pnlAuthorized.Visible = false;
            pnlCurrentSO.Visible = false;
        }

        private void btnCSO_MouseClick(object sender, MouseEventArgs e)
        {
            btnGDuty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  
            btnCSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));

            pnlGateDuty.Visible = true;
            pnlUnauthorized.Visible = false;
            pnlAuthorized.Visible = false;
            pnlCurrentSO.Visible = true;



            
            
        }


        // // // // // // //             End Basic Design             // // // // // // //







        // // // // // // //             Begining Timer             // // // // // // //



        private void Timer_Tick(object sender, EventArgs e)     // Timer Settings
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();  
            Timer.Start();
        }


        // // // // // // //             End Timer             // // // // // // //










        // // // // // // //             Begining Of Menu Items             // // // // // // //


        private void btnUpdateDetails_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Update uou = new Update(0);
            uou.Show();
        }

        private void btnVehicleDetails_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            VehicleSearch vs = new VehicleSearch(1);
            vs.Show();
        }

        private void btnHistory_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            History h = new History(2);
            h.Show();
        }

        private void btnLogOut_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            LogOut logout = new LogOut(2);
            logout.Show();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void pnlCurrentSO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCSO_Click(object sender, EventArgs e)
        {

        }

        private void btnVehicleDetails_Click(object sender, EventArgs e)
        {

        }


        // // // // // // //             End Of Menu Items             // // // // // // //

















    }
}
