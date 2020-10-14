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
    public partial class VehicleSearch : Form
    {



        int selectForm;
        //int uid;
        //int gid;

        public VehicleSearch(int i)
        {
            InitializeComponent();
            selectForm = i;


        }



        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();




        //Globle Variables 
        String oid;
        Int32 intOid;
        String sOwnerName;
        String sOwnerType;
        String sOwnerTel;
        String sOwnerA1;
        String sOwnerA2;
        String sOwnerA3;
        String sOwnerA4;
        String sVehicleType;
        String sVehicleModel;
        String vState;
        Int16 intVState;
        byte[] sVImage;
        String vNum;
        String vID;
        Int32 intVID;
        
        



        




        // // // // // // //             Begining Basic Design             // // // // // // //


        private void VehicleSearch_Load(object sender, EventArgs e)
        {
            pnlSearch.BackColor = Color.FromArgb(100, 0, 0, 0);  //panel transparent
            pnlSVehicle.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlSOwner.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlSSearch.BackColor = Color.FromArgb(80, 0, 0, 0);  //panel transparent
            pnlHGride.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlHSearch.BackColor = Color.FromArgb(80, 0, 0, 0);  //panel transparent


            pnlSearch.Visible = true;
            pnlHistory.Visible = false;

            
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  

        }

        private void btnSearch_MouseClick(object sender, MouseEventArgs e)  //Opens searching form
        {
            
            pnlSearch.Visible = true;
            pnlHistory.Visible = false;

            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));

        }

        private void btnHistory_MouseClick(object sender, MouseEventArgs e)  // Opens History form
        {

            
            pnlSearch.Visible = true;
            pnlHistory.Visible = true;

            
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));   
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  

        }



        // // // // // // //             End Basic Design             // // // // // // //














        // // // // // // //             Begining Searching Form             // // // // // // //


        private void btnSSearch_MouseClick(object sender, MouseEventArgs e)
        {



            if (txtSVNumber.Text == "")
            {
                MessageBox.Show("Insert Vehicle Number...!");
            }
            else
            {


                try
                {

                    connect.Open();

                    String sVehicleNum = txtSVNumber.Text;




                    //Select V_STATE from VEHICLE table
                    String selectQuery = "SELECT V_STATE FROM VEHICLE WHERE V_NUMBER='" + sVehicleNum + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader myReader = command.ExecuteReader();

                    while (myReader.Read())
                    {
                        this.vState = myReader[0].ToString();
                    }

                    intVState = Int16.Parse(vState);
                    myReader.Close();

                    if (intVState == 1)
                    {
                        this.txtSVState.ForeColor = System.Drawing.Color.Black;
                        txtSVState.Text = "Authorized";
                    }
                    else if (intVState == 0)
                    {
                        this.txtSVState.ForeColor = System.Drawing.Color.Red;
                        txtSVState.Text = "Unauthorized";
                        
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                        this.txtSVState.ForeColor = System.Drawing.Color.Red;
                        txtSVState.Text = "Error...!!!";
                    }



                    //  Select data from VEHICLE table and OWNER table using INNER JOIN
                    String selectQuery1 = "SELECT V.V_TYPE, O.O_NAME, O.O_TYPE, O.O_TELEPHONE, V_IMAGE FROM VEHICLE V INNER JOIN OWNER O ON O.O_ID=V.O_ID WHERE V.V_NUMBER='" + sVehicleNum + "'";
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();

                    while (myReader1.Read())  //  Assign values to globle variables
                    {

                        this.sVehicleType = myReader1[0].ToString();
                        this.sOwnerName = myReader1[1].ToString();
                        this.sOwnerType = myReader1[2].ToString();
                        this.sOwnerTel = myReader1[3].ToString();
                        this.sVImage = (byte[])myReader1[4];

                    }

                    myReader1.Close();

                    //Select data from VEHICLE table, OWNER table and O_ADDRESS table using INNER JOIN
                    String selectQuery2 = "SELECT V.V_MODEL, OA.FIRST, OA.SECOND,  OA.THIRD,  OA.FOURTH FROM VEHICLE V INNER JOIN O_ADDRESS OA  ON OA.O_ID=V.O_ID WHERE V.V_NUMBER='" + sVehicleNum + "'";
                    MySqlCommand command2 = new MySqlCommand(selectQuery2, connect);
                    MySqlDataReader myReader2 = command2.ExecuteReader();

                    while (myReader2.Read())  //  Assign values to globle variables
                    {
                        this.sVehicleModel = myReader2[0].ToString();
                        this.sOwnerA1 = myReader2[1].ToString();
                        this.sOwnerA2 = myReader2[2].ToString();
                        this.sOwnerA3 = myReader2[3].ToString();
                        this.sOwnerA4 = myReader2[4].ToString();

                    }

                    myReader2.Close();




                    // set data in the form
                    txtSVType.Text = sVehicleType;
                    txtSVModel.Text = sVehicleModel;
                    txtSOAline1.Text = sOwnerA1;
                    txtSOAline2.Text = sOwnerA2;
                    txtSOAline3.Text = sOwnerA3;
                    txtSOAline4.Text = sOwnerA4;
                    txtSOName.Text = sOwnerName;
                    txtSORole.Text = sOwnerType;
                    txtSOTel.Text = sOwnerTel;

                    MemoryStream ms = new MemoryStream(sVImage);
                    picSVImage.Image = Image.FromStream(ms);


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

        }






        private void btnSClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtSVNumber.Text = "";
            txtSVState.Text = "";
            txtSVType.Text = "";
            txtSVModel.Text = "";
            txtSOAline1.Text = "";
            txtSOAline2.Text = "";
            txtSOAline3.Text = "";
            txtSOAline4.Text = "";
            txtSOName.Text = "";
            txtSORole.Text = "";
            txtSOTel.Text = "";
            picSVImage.Image = null;

            this.sVehicleType = "";
            this.sVehicleModel = "";
            this.sOwnerName = "";
            this.sOwnerType = "";
            this.sOwnerTel = "";
            this.sOwnerA1 = "";
            this.sOwnerA2 = "";
            this.sOwnerA3 = "";
            this.sOwnerA4 = "";
            this.oid = "";
            this.intOid = 0;
            this.vState = "";
            this.intVState = 0;
        }





        private void btnSBack_MouseClick(object sender, MouseEventArgs e)
        {


            if (selectForm == 0)
            {

                this.Close();
                SecurityOfficerHome soh = new SecurityOfficerHome();
                soh.Show();

                this.selectForm = 0;
                

            } 
            else if (selectForm == 1)
            {

                this.Close();
                UniversityOfficerHome uoh = new UniversityOfficerHome();
                uoh.Show();

                this.selectForm = 0;
                

            }


        }


        // // // // // // //             End Searching Form             // // // // // // //














        // // // // // // //             Begining History Form             // // // // // // //


        private void btnHClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtHNumber.Text = "";

           
        }

        private void btnHBack_MouseClick(object sender, MouseEventArgs e)
        {

            if (selectForm == 0)
            {

                this.Close();
                SecurityOfficerHome soh = new SecurityOfficerHome();
                soh.Show();

                this.selectForm = 0;
                

            }
            else if (selectForm == 1)
            {

                this.Close();
                UniversityOfficerHome uoh = new UniversityOfficerHome();
                uoh.Show();

                this.selectForm = 0;
                

            }

        }


        private void populate(String a, String b) {
            gridHistory.Rows.Add(a,b);
        }

        private void btnHSearch_MouseClick(object sender, MouseEventArgs e)
        {
            vNum = txtHNumber.Text;

            try
            {

                connect.Open();


                // SELECT Vehicle Number
                String selectQuery1 = "SELECT V_ID FROM VEHICLE WHERE V_NUMBER='" + vNum + "'";
                MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                MySqlDataReader myReader1 = command1.ExecuteReader();


                while (myReader1.Read())
                {
                    this.vID = myReader1[0].ToString();

                }

                intVID = Int32.Parse(vID);
                myReader1.Close();


                // SELECT TIME_DATE , G_ID
                String selectQuery2 = "SELECT TIME_DATE , G_ID FROM PASS WHERE V_ID=" + intVID+"";
                MySqlCommand command2 = new MySqlCommand(selectQuery2, connect);


                ad = new MySqlDataAdapter(command2);
                ad.Fill(dt);


                foreach (DataRow row in dt.Rows) {

                    populate(row[0].ToString(), row[1].ToString());
                }

              
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnHSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }



        // // // // // // //             End History Form             // // // // // // //
    }
}
