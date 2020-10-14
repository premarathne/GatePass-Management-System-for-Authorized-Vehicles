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
    public partial class LogOut : Form
    {



        //Globle Variables 
        //int uid;
        int usertype; // admin=1, uni.off.=2, sec.0ff.=3
        //int gid;



        public LogOut(int i)
        {
           
           usertype = i;
           

            InitializeComponent();
        }






        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database





        // // // // // // //             Begining Basic Design             // // // // // // //


        private void LogOut_Load(object sender, EventArgs e)
        {
            pnlBox.BackColor = Color.FromArgb(100, 0, 0, 0);
           
        }


        // // // // // // //             End Basic Design             // // // // // // //







        // // // // // // //             Begining Yes Button Action             // // // // // // //


        private void btnYes_MouseClick(object sender, MouseEventArgs e)
        {

            if (usertype == 3)
            {
                try
                {
                    connect.Open();

                    //Update Log Out Time
                    String updateQuery1 = "UPDATE WORKS_AT SET STOP_TIME_DATE=CURTIME() WHERE ID="+Login.worksAtId+"";
                    MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();
                    myReader1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    connect.Close();
                }
            }
            


            this.Close();
            Application.Exit();
            Login.intUid = 0;
            Login.intUid = 0;
            Login.worksAtId = 0;
        }


        // // // // // // //             End Yes Button Action             // // // // // // //






        // // // // // // //             Begining No Button Action             // // // // // // //


        private void No_MouseClick(object sender, MouseEventArgs e)
        {




            if (usertype == 1) {
                this.Close();
                AdminHome soh = new AdminHome();
                soh.Show();
            }




            else if (usertype == 2) {
                this.Close();
                UniversityOfficerHome soh = new UniversityOfficerHome();
                soh.Show();
            }




            else if (usertype == 3) {
                this.Close();
                SecurityOfficerHome soh = new SecurityOfficerHome();
                soh.Show();
            }



        }


        // // // // // // //             End No Button Action             // // // // // // //

    }
}
