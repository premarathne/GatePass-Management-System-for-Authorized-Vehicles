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
using System.IO;




namespace gate
{

    
    public partial class SecurityOfficerHome : Form
    {




        //Globle Variables 
        //Int32 uid;
        //Int32 gid;
        String vid;
        Int32 intVid;
        

        public SecurityOfficerHome()
        {
            InitializeComponent();
            
        }



        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=sep"); //create connection with the database







        // // // // // // //             Begining Basic Design             // // // // // // //

        private void SecurityOfficerHome_Load(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(70, 0, 0, 0);
            pnlBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlBoxAuthorized.BackColor = Color.FromArgb(100, 0, 0, 0);

            pnlBoxAuthorized.Visible = false;
            pnlBoxUnauthorized.Visible = false;

            lblDate.Text = DateTime.Now.ToLongDateString();  // Date Settings

        }


        // // // // // // //             End Basic Design             // // // // // // //








        // // // // // // //             Begining Timer             // // // // // // //
        private void vehicleTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            vehicleTimer.Start();
            
        }
        // // // // // // //             End Timer             // // // // // // //









        // // // // // // //             Begining Of Menu Items             // // // // // // //


        private void btnUpdateDetails_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Hide();
            SecurityOfficerUpdateBySO soubso = new SecurityOfficerUpdateBySO();
            soubso.Show();
        }

        private void btnVehicleDetails_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            VehicleSearch vs = new VehicleSearch(0);
            vs.Show();

        }

        private void btnHistory_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            History h = new History(3);
            h.Show();
        }

        private void btnLogOut_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            LogOut logout = new LogOut(3);
            logout.Show();
        }


        // // // // // // //             End Of Menu Items             // // // // // // //













        // // // // // // //             Begining Authorized Vehicle Settings            // // // // // // //

        private void btnAllow_MouseClick(object sender, MouseEventArgs e)
        {

            
           // String vnum = txtVNumber.Text;

            try {

                MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=sep"); //create connection with the database

                connect.Open();

                //Select V_ID  from VEHICLE table
                String selectQuery1 = "SELECT V_ID FROM vehicle WHERE V_NUMBER='"+ txtVNumber.Text + "'";
                MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                MySqlDataReader myReader1 = command1.ExecuteReader();

                while (myReader1.Read())
                {
                    this.vid = myReader1[0].ToString();
                    
                }

                intVid = Int32.Parse(vid);
                
                myReader1.Close();


                //  Insert data in to PASS table
                String insertQuery2 = "INSERT INTO pass (G_ID, V_ID) VALUES ('"+Login.gid+"', '"+vid+"')";
                MySqlCommand command2 = new MySqlCommand(insertQuery2, connect);
                MySqlDataReader myReader2 = command2.ExecuteReader();
                myReader2.Close();


            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
            finally
            {
                connect.Close();
            }


        }

        // // // // // // //             End Authorized Vehicle Settings             // // // // // // //











        // // // // // // //            Begining Unauthorized Vehicle Settings            // // // // // // //


        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String MySqlConnectionString = "server=localhost;port=3306;username=root;password=;database=sep";
            String MySqlConnectionString1 = "server=localhost;port=3306;username=root;password=;database=iotproject";

            MySqlConnection con = new MySqlConnection(MySqlConnectionString);
            MySqlConnection con1 = new MySqlConnection(MySqlConnectionString1);
            con1.Open();
            string query1 = "SELECT  CardID from  users ORDER BY id DESC LIMIT 1  ;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con1);
            MySqlDataReader mdr1;

            //mdr1 = cmd1.ExecuteReader();
            if (mdr1.Read())
            {
                con.Open();
                string query2 = "select V_TAG_NO from VEHICLE where V_TAG_NO='" + mdr1.GetString("CardID") + "'";
                MySqlCommand cmd = new MySqlCommand(query2, con);
                MySqlDataReader mdr;

                mdr = cmd.ExecuteReader();


                if (mdr.Read())
                {
                  //  pnlBoxUnauthorized.Visible = true;
                  //  pnlBoxAuthorized.Visible = false;
                    // textBox1.Text = mdr.GetString("VehicleId");
                    txtVtagno.Text = mdr.GetString("V_TAG_NO");
                    // textBox3.Text = mdr.GetString("Model");

                    con1.Close();
                    con.Close();
                    con.Open();
                    // string query = "SELECT V_NUMBER,V_TAG_NO,V_TYPE,V_MODEL from vehicle where V_TAG_NO='" + txtVtagno.Text + "';";
                    string query = "SELECT V.V_NUMBER, V.V_TAG_NO,  V.V_TYPE,  V.V_MODEL, O.O_NAME , O.O_TYPE,O.O_TELEPHONE FROM VEHICLE V INNER JOIN owner O  ON O.O_ID=V.O_ID WHERE V.V_TAG_NO='" + txtVtagno.Text + "'";
                    // string query2= "SELECT O_NIC,O_NAME,O_TYPE from owner where O_ID='" + txtVtagno.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(query, con);

                    MySqlDataReader md;


                    md = cmd2.ExecuteReader();
                    if (md.Read())
                    {

                        txtVNumber.Text = md.GetString("V_NUMBER");
                        txtVType.Text = md.GetString("V_TYPE");
                        txtVModel.Text = md.GetString("V_MODEL");
                        txtOName.Text = md.GetString("O_NAME");
                        txtORole.Text = md.GetString("O_TYPE");
                        txtOTel.Text = md.GetString("O_TELEPHONE");
                    }
                    
                }
              else
                {
                    pnlBoxAuthorized.Visible = false;
                    panel1.Visible = false;
                    pnlBox1.Visible = false;
                    pnlBoxUnauthorized.Visible = true;
                   // MessageBox.Show("Unauthorized  to acess.....!!");
                    
                }

            }
        }

        private void pnlBoxAuthorized_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBoxUnauthorized_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sucessfully inserted!!!!!");

            try
            {


                connect.Open();

                //Select V_ID  from VEHICLE table
                String selectQuery1 = "SELECT V_ID FROM vehicle WHERE V_NUMBER='" + txtVNumber.Text + "'";
                MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                MySqlDataReader myReader1 = command1.ExecuteReader();

                while (myReader1.Read())
                {
                    this.vid = myReader1[0].ToString();

                }

                intVid = Int32.Parse(vid);

                myReader1.Close();


                //  Insert data in to PASS table
                String insertQuery2 = "INSERT INTO pass (G_ID, V_ID) VALUES ('" + Login.gid + "', '" + vid + "')";
                MySqlCommand command2 = new MySqlCommand(insertQuery2, connect);
                MySqlDataReader myReader2 = command2.ExecuteReader();
                myReader2.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnVehicleDetails_Click(object sender, EventArgs e)
        {

        }

        private void picVImage_Click(object sender, EventArgs e)
        {

        }
    }
}




        // // // // // // //             End Unauthorized Vehicle Settings             // // // // // // //

    

