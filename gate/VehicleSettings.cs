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
    public partial class VehicleSettings : Form
    {
        public VehicleSettings()
        {
            InitializeComponent();
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
        String sVehicleTag;
        String sVehicleType;
        String sVehicleModel;
        String vState;
        Int16 intVState;
        byte[] sVImage;
        String vNum;
        String vID;
        Int32 intVID;


















        // // // // // // //             Begining Basic Design             // // // // // // //


        private void VehicleSettings_Load(object sender, EventArgs e) // Appearence when page is loading...
        {

            pnlRegister.BackColor = Color.FromArgb(100, 0, 0, 0);  //panel transparent
            pnlRVehicle.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlROwner.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlSVehicle.BackColor = Color.FromArgb(50, 0, 0, 0);   //panel transparent
            pnlSOwner.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlSSearch.BackColor = Color.FromArgb(80, 0, 0, 0);  //panel transparent
            pnlHGride.BackColor = Color.FromArgb(50, 0, 0, 0);  //panel transparent
            pnlHSearch.BackColor = Color.FromArgb(80, 0, 0, 0);  //panel transparent

            pnlRegister.Visible = true;
            pnlSearch.Visible = false;
            pnlHistory.Visible = false;

            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  

        }






        private void btnRegister_MouseClick(object sender, MouseEventArgs e) // Opens Vehicle Registration form
        {

            pnlRegister.Visible = true;
            pnlSearch.Visible = false;
            pnlHistory.Visible = false;


            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));   
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  

        }







        private void btnSearch_MouseClick(object sender, MouseEventArgs e) // Opens Vehicle Search form
        {
            pnlRegister.Visible = true;
            pnlSearch.Visible = true;
            pnlHistory.Visible = false;

            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));   
        }



        private void btnHistory_MouseClick(object sender, MouseEventArgs e) // Opens Vehicle History form
        {
            pnlRegister.Visible = true;
            pnlSearch.Visible = true;
            pnlHistory.Visible = true;

            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));   
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));    
            btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  


        }



        // // // // // // //             End Basic Design             // // // // // // //






















        // // // // // // //             Begining Registration Form             // // // // // // //


        private void btnRBrowse_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";         //Image types  --- Filter image files
                ofd.Title = "Select Vehicle Image";        //  Title of the selection window
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picRVImage.Image = Image.FromFile(ofd.FileName);
                    String picPath = ofd.FileName.ToString();
                    txtRVBrowse.Text = picPath;
                    picRVImage.ImageLocation = picPath; 
                    //picRVImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnRInsert_MouseClick(object sender, MouseEventArgs e)
        {

            


            if (picRVImage.Image == null) {
                MessageBox.Show("Insert Vehicle Image...!");
            }
            else if (txtRVNumber.Text == "" || txtRVTag.Text == "" || txtRVType.Text == "" || txtRVModel.Text == "" || txtRONIC.Text == "" || txtROName.Text == "" || txtRORole.Text == "" || txtROTel.Text == "" || txtROAline1.Text == "" || txtROAline2.Text == "" || txtROAline3.Text == "") {
                MessageBox.Show("Insert details in every field...!");
            }
            else if (txtROTel.Text.Length != 10)
            {
                MessageBox.Show("Check your telephone number again...!");
                txtROTel.Text = "";

            }
            else {

                //Registration form details
                String ownerNic = txtRONIC.Text;
                String ownerName = txtROName.Text;
                String ownerType = txtRORole.Text;
                String ownerTel = txtROTel.Text;
                String ownerA1 = txtROAline1.Text;
                String ownerA2 = txtROAline2.Text;
                String ownerA3 = txtROAline3.Text;
                String ownerA4 = txtROAline4.Text;
                String vehicleNum = txtRVNumber.Text;
                String vehicleTag = txtRVTag.Text;
                String vehicleType = txtRVType.Text;
                String vehicleModel = txtRVModel.Text;


                // image
                byte[] imagebt = null;
                FileStream stream = new FileStream(this.txtRVBrowse.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                imagebt = br.ReadBytes((int)stream.Length);



                try
                {
                    connect.Open();

                    //  Insert data in to OWNER table
                    String insertQuery1 = "INSERT INTO OWNER (O_NIC, O_NAME, O_TYPE, O_TELEPHONE) VALUES ('" + ownerNic + "', '" + ownerName + "', '" + ownerType + "', '" + ownerTel + "')";
                    MySqlCommand command1 = new MySqlCommand(insertQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();
                    myReader1.Close();

                    // Select O_ID from OWNER table
                    String selectQuery1 = "SELECT O_ID FROM OWNER WHERE O_NIC='" + ownerNic + "'";
                    MySqlCommand command2 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader2 = command2.ExecuteReader();


                    while (myReader2.Read()) {
                        this.oid = myReader2[0].ToString();

                    }

                    intOid = Int32.Parse(oid);
                    myReader2.Close();

                    //  Insert data in to O_ADDRESS table
                    String insertQuery2 = "INSERT INTO O_ADDRESS (O_ID, FIRST, SECOND, THIRD, FOURTH) VALUES (" + intOid + ", '" + ownerA1 + "', '" + ownerA2 + "', '" + ownerA3 + "', '" + ownerA4 + "')";
                    MySqlCommand command3 = new MySqlCommand(insertQuery2, connect);
                    MySqlDataReader myReader3 = command3.ExecuteReader();
                    myReader3.Close();

                    //  Insert data in to VEHICLE table
                    String insertQuery3 = "INSERT INTO VEHICLE (O_ID, V_NUMBER, V_TAG_NO, V_TYPE, V_MODEL, V_IMAGE, V_STATE) VALUES ("+intOid+", '"+vehicleNum+"', '"+vehicleTag+"', '"+vehicleType+"', '"+vehicleModel+"', @IMG , "+1+")";
                    MySqlCommand command4 = new MySqlCommand(insertQuery3, connect);
                    command4.Parameters.Add(new MySqlParameter("@IMG", imagebt));  // Image insertion
                    MySqlDataReader myReader4 = command4.ExecuteReader();
                    myReader3.Close();


                    MessageBox.Show("Inserted data sucessfully!");

                    txtRVNumber.Text = "";
                    txtRVTag.Text = "";
                    txtRVModel.Text = "";
                    txtRVType.Text = "";
                    txtROName.Text = "";
                    txtRONIC.Text = "";
                    txtROTel.Text = "";
                    txtROAline1.Text = "";
                    txtROAline2.Text = "";
                    txtROAline3.Text = "";
                    txtROAline4.Text = "";
                    txtRORole.Text = "";
                    txtRVBrowse.Text = "";

                    picRVImage.Image = null;

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







        private void btnRClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtRVNumber.Text = "";
            txtRVTag.Text = "";
            txtRVModel.Text = "";
            txtRVType.Text = "";
            txtROName.Text = "";
            txtRONIC.Text = "";
            txtROTel.Text = "";
            txtROAline1.Text = "";
            txtROAline2.Text = "";
            txtROAline3.Text = "";
            txtROAline4.Text = "";
            txtRORole.Text = "";
            txtRVBrowse.Text = "";
            picRVImage.Image = null;
        }







        private void btnRBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            AdminHome ah = new AdminHome();
            ah.Show();
        }



        // // // // // // //             End Registration Form             // // // // // // //





















        // // // // // // //             Begining Searching Form             // // // // // // //


        private void btnSSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSVNumber.Text == "") {
                MessageBox.Show("Insert Vehicle Number...!");
            } else {


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

                    if (intVState == 1) {
                    
                    }
                    else if (intVState == 0) {
                        MessageBox.Show("This Vehicle Already Has Been Deleted From The System");
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                    }
                    


                    //  Select data from VEHICLE table and OWNER table using INNER JOIN
                    String selectQuery1 = "SELECT V.V_TYPE, V.V_MODEL, O.O_NAME, O.O_TYPE, O.O_TELEPHONE, V_IMAGE FROM VEHICLE V INNER JOIN OWNER O ON O.O_ID=V.O_ID WHERE V.V_NUMBER='"+sVehicleNum+"'";
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();

                    while (myReader1.Read())  //  Assign values to globle variables
                    {
                    
                        this.sVehicleType = myReader1[0].ToString();
                        this.sVehicleModel = myReader1[1].ToString();
                        this.sOwnerName = myReader1[2].ToString();
                        this.sOwnerType = myReader1[3].ToString();
                        this.sOwnerTel = myReader1[4].ToString();
                        this.sVImage = (byte[])myReader1[5];

                    }

                    myReader1.Close();

                    //Select data from VEHICLE table, OWNER table and O_ADDRESS table using INNER JOIN
                    String selectQuery2 = "SELECT V.V_TAG_NO, OA.FIRST, OA.SECOND,  OA.THIRD,  OA.FOURTH FROM VEHICLE V INNER JOIN O_ADDRESS OA  ON OA.O_ID=V.O_ID WHERE V.V_NUMBER='" + sVehicleNum + "'";
                    MySqlCommand command2 = new MySqlCommand(selectQuery2, connect);
                    MySqlDataReader myReader2 = command2.ExecuteReader();

                    while (myReader2.Read())  //  Assign values to globle variables
                    {
                        this.sVehicleTag = myReader2[0].ToString();
                        this.sOwnerA1 = myReader2[1].ToString();
                        this.sOwnerA2 = myReader2[2].ToString();
                        this.sOwnerA3 = myReader2[3].ToString();
                        this.sOwnerA4 = myReader2[4].ToString();

                    }

                    myReader2.Close();


                    

                    // set data in the form
                    txtSVTag.Text = sVehicleTag;
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







        private void btnSClear_MouseClick(object sender, MouseEventArgs e)  //  clear the form
        {
            txtSVNumber.Text = "";
            txtSVTag.Text = "";
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
            this.sVehicleTag = "";
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
            this.Close();
            AdminHome ah = new AdminHome();
            ah.Show();
        }







        private void btnSDelete_MouseClick(object sender, MouseEventArgs e)
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

                    String vnum = txtSVNumber.Text;



                    //Select V_STATE from VEHICLE table
                    String selectQuery = "SELECT V_STATE FROM VEHICLE WHERE V_NUMBER='" + vnum + "'";
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
                        //Update Vehicle table
                        String updateQuery1 = "UPDATE VEHICLE SET V_STATE=" + 0 + "  WHERE V_NUMBER='" + vnum + "'";
                        MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();
                        myReader1.Close();


                        MessageBox.Show("Deleted Vehicle Sucessfully...!");
                    }
                    else if (intVState == 0)
                    {
                        MessageBox.Show("This Vehicle Already Has Been Deleted From The System");
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                    }


                    


                    txtSVNumber.Text = "";
                    txtSVTag.Text = "";
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
                    this.sVehicleTag = "";
                    this.sOwnerA1 = "";
                    this.sOwnerA2 = "";
                    this.sOwnerA3 = "";
                    this.sOwnerA4 = "";
                    this.oid = "";
                    this.intOid = 0;
                    this.vState = "";
                    this.intVState = 0;

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







        private void btnSUpdate_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtSVNumber.Text == "")
            {
                MessageBox.Show("Insert Vehicle Number...!");
            }
            else
            {

                String vnum = txtSVNumber.Text;

                try
                {
                    connect.Open();



                    //Select V_STATE from VEHICLE table
                    String selectQuery = "SELECT V_STATE FROM VEHICLE WHERE V_NUMBER='" + vnum + "'";
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


                        //Select O_ID from VEHICLE table
                        String selectQuery1 = "SELECT O_ID FROM VEHICLE WHERE V_NUMBER='"+vnum+"'";
                        MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();

                        while (myReader1.Read())
                        {
                            this.oid = myReader1[0].ToString();
                        }

                        intOid = Int32.Parse(oid);
                        myReader1.Close();

                        VehicleUpdate vu = new VehicleUpdate(intOid);
                        vu.Show();

                    }
                    else if (intVState == 0)
                    {
                        MessageBox.Show("This Vehicle Has Been Deleted From The System.\nTherefore Cannot Update...!!");
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                    }


                    

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    connect.Close();
                }

                

                txtSVNumber.Text = "";
                txtSVTag.Text = "";
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
                this.sVehicleTag = "";
                this.sOwnerA1 = "";
                this.sOwnerA2 = "";
                this.sOwnerA3 = "";
                this.sOwnerA4 = "";
                this.oid = "";
                this.intOid = 0;
            }
                
        }




        // // // // // // //             End Searching Form             // // // // // // //



















        // // // // // // //             Begining History Form             // // // // // // //




        private void populate(String a, String b)
        {
            gridHistory.Rows.Add(a, b);
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
                String selectQuery2 = "SELECT CAST(TIME_DATE AS VARCHAR(100)), G_ID FROM PASS WHERE V_ID=" + intVID + "";
                MySqlCommand command2 = new MySqlCommand(selectQuery2, connect);


                ad = new MySqlDataAdapter(command2);
                ad.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {

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

        private void btnHBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            AdminHome ah = new AdminHome();
            ah.Show();
        }

        private void btnHClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtHNumber.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {

        }


        // // // // // // //             End History Form             // // // // // // //

    }
}
