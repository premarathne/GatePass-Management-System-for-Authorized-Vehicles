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
    public partial class SecurityOfficerSettings : Form
    {
        public SecurityOfficerSettings()
        {
            InitializeComponent();
        }







        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database




        //Globle Variables 
        String uid;
        Int32 intUid;
        String sUsername;
        String sPassword;
        String sName;
        String sNic;
        String sTelephone;
        String sFirst;
        String sSecond;
        String sThird;
        String sFourth;
        String sState;
        Int16 intSState;


















        // // // // // // //             Begining Basic Design             // // // // // // //


        private void securityRegistration_Load(object sender, EventArgs e)  // Appearence when page is loading...
        {
            pnlBoxRegister.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlSSearch.BackColor = Color.FromArgb(100, 0, 0, 0);
            

            pnlBoxRegister.Visible = true;
            pnlBoxSearch.Visible = false;
            

            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  

        }

        private void btnRegister_MouseClick(object sender, MouseEventArgs e)  // Opens Security Officer Registration form
        {
            pnlBoxRegister.Visible = true;
            pnlBoxSearch.Visible = false;
            

            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  //panel transparent
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  //panel transparent

        }

        private void btnSearch_MouseClick(object sender, MouseEventArgs e)   // Opens Security Officer Searching form
        {

            pnlBoxRegister.Visible = true;
            pnlBoxSearch.Visible = true;
            

            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));  //panel transparent
            btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));  //panel transparent

        }


        // // // // // // //             End Basic Design             // // // // // // //


























        // // // // // // //             Begining Registration Form             // // // // // // //


        




        private void btnRInsert_MouseClick(object sender, MouseEventArgs e)  // Insert data to the database
        {
            //Registration form details
            String username = txtRUser.Text; 
            String password = txtRPass.Text;
            String conPassword = txtRConPass.Text;
            String sid = txtRSID.Text;
            String name = txtRname.Text;
            String nic = txtRNIC.Text;
            String telephone = txtRTel.Text;
            String first = txtRAline1.Text;
            String second = txtRAline2.Text;
            String third = txtRAline3.Text;
            String fourth = txtRAline4.Text;

            if (txtRUser.Text == ""  || txtRPass.Text == "" || txtRConPass.Text == "" || txtRSID.Text == "" || txtRname.Text == "" || txtRNIC.Text == "" || txtRTel.Text == "" || txtRAline1.Text == "" || txtRAline2.Text == "" || txtRAline3.Text == "") {
                MessageBox.Show("Insert details in every field...!");
            }
            else if (telephone.Length != 10)  // Check Telephone Number is Correct
            {
                MessageBox.Show("Check your telephone number again...!");
                txtRTel.Text = "";
            }
            else if (password != conPassword)  // Check Password is Correct
            {
                MessageBox.Show("Check your password again...!");
                txtRPass.Text = "";
                txtRConPass.Text = "";
            }
            else { 
            
                try
                {
                    connect.Open();
                
                    // Insert data to USER table
                    String insertQuery1 = "INSERT INTO USER (USER_TYPE_ID, USERNAME, PASSWORD, S_ID, S_NAME, S_NIC, S_TELEPHONE,S_STATE) VALUES ("+3+", '"+username+"', '"+ password+"', '"+sid+"', '"+name+"', '"+nic+"', '"+telephone+"', "+1+" )";
                    MySqlCommand command1 = new MySqlCommand(insertQuery1 , connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();
                    myReader1.Close();



                    //Select U_ID from USER table
                    String selectQuery1 = "SELECT U_ID FROM USER WHERE S_NIC='" + nic + "'";
                    MySqlCommand command2 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader2 = command2.ExecuteReader();

                    while (myReader2.Read())
                    {
                        this.uid = myReader2[0].ToString();
                    }

                    intUid = Int32.Parse(uid);
                    myReader2.Close();


               
                    // Insert data to SO_ADDRESS table
                    string insertQuery2 = "INSERT INTO SO_ADDRESS (U_ID, FIRST, SECOND, THIRD, FOURTH) VALUES ("+intUid+", '"+first+"', '"+second+"', '"+third+"', '"+fourth+"')";
                    MySqlCommand command3 = new MySqlCommand(insertQuery2, connect);
                    MySqlDataReader myReader3 = command3.ExecuteReader();
                    myReader3.Close();

                    MessageBox.Show("Inserted data sucessfully!");

                    txtRUser.Text = "";
                    txtRPass.Text = "";
                    txtRConPass.Text = "";
                    txtRSID.Text = "";
                    txtRname.Text = "";
                    txtRNIC.Text = "";
                    txtRTel.Text = "";
                    txtRAline1.Text = "";
                    txtRAline2.Text = "";
                    txtRAline3.Text = "";
                    txtRAline4.Text = "";


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









        private void btnRClear_MouseClick(object sender, MouseEventArgs e)  // Clear the form
        {
            txtRUser.Text = "";
            txtRPass.Text = "";
            txtRSID.Text = "";
            txtRname.Text = "";
            txtRNIC.Text = "";
            txtRTel.Text = "";
            txtRAline1.Text = "";
            txtRAline2.Text = "";
            txtRAline3.Text = "";
            txtRAline4.Text = "";
            txtRConPass.Text = "";
        }










        private void btnRBack_MouseClick(object sender, MouseEventArgs e)  // Back to the previous page
        {
            this.Close();
            AdminHome ah = new AdminHome();
            ah.Show();
        }



        // // // // // // //             End Registration Form             // // // // // // //
        






















        // // // // // // //             Begining Searching Form             // // // // // // //



        private void btnSSearch_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtSSID.Text == "")
            {
                MessageBox.Show("Insert Security Officer ID Number...!");
            }

            else
            {
                try {

                    connect.Open();

                    String sid = txtSSID.Text;

                    



                    //Select S_STATE from USER table
                    String selectQuery = "SELECT S_STATE FROM USER WHERE S_ID='"+sid+"'";
                    MySqlCommand command = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader myReader = command.ExecuteReader();

                    while (myReader.Read())
                    {
                        this.sState = myReader[0].ToString();
                    }

                    intSState = Int16.Parse(sState);
                    myReader.Close();

                    if (intSState == 1)
                    {


                    }
                    else if (intSState == 0)
                    {
                        MessageBox.Show("This Security Officer Has Been Deleted From The System");
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                    }



                    //Select data from USER table and SO_ADDRESS table using INNER JOIN
                    String selectQuery1 = "SELECT U.S_NAME, U.S_NIC, U.S_TELEPHONE, U.USERNAME, U.PASSWORD, SO.FIRST, SO.SECOND, SO.THIRD, SO.FOURTH FROM USER U INNER JOIN SO_ADDRESS SO ON SO.U_ID=U.U_ID WHERE U.S_ID='"+sid+"'";
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        this.sName = myReader1[0].ToString();
                        this.sNic = myReader1[1].ToString();
                        this.sTelephone = myReader1[2].ToString();
                        this.sUsername = myReader1[3].ToString();
                        this.sPassword = myReader1[4].ToString();
                        this.sFirst = myReader1[5].ToString();
                        this.sSecond = myReader1[6].ToString();
                        this.sThird = myReader1[7].ToString();
                        this.sFourth = myReader1[8].ToString();
                    }

                    myReader1.Close();


                    txtSName.Text = sName;
                    txtSNIC.Text = sNic;
                    txtSTel.Text = sTelephone;
                    txtSUser.Text = sUsername;
                    txtSPass.Text = sPassword;
                    txtSAline1.Text = sFirst;
                    txtSAline2.Text = sSecond;
                    txtSAline3.Text = sThird;
                    txtSAline4.Text = sFourth;

                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    connect.Close();
                }
            }
                
            
        }








        private void btnSUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSSID.Text == "")
            {
                MessageBox.Show("Insert The Security Officer ID You Want To Update...!");
            }
            else {

                String sid = txtSSID.Text;
                    

                try {
                    connect.Open();


                    

                    //Select S_STATE from USER table
                    String selectQuery = "SELECT S_STATE FROM USER WHERE S_ID='" + sid + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader myReader = command.ExecuteReader();

                    while (myReader.Read())
                    {
                        this.sState = myReader[0].ToString();
                    }

                    intSState = Int16.Parse(sState);
                    myReader.Close();

                    if (intSState == 1)
                    {

                        //Select U_ID from USER table
                        String selectQuery1 = "SELECT U_ID FROM USER WHERE S_ID='" + sid + "'";
                        MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();

                        while (myReader1.Read())
                        {
                            this.uid = myReader1[0].ToString();
                        }

                        intUid = Int32.Parse(uid);
                        myReader1.Close();


                        //  Update Form
                        SecurityOfficerUpdateSO secUpdate = new SecurityOfficerUpdateSO(intUid);
                        secUpdate.Show();

                    }
                    else if (intSState == 0)
                    {
                        MessageBox.Show("This Security Officer Has Been Deleted From The System...\nTherefore Can Not Update...!!");
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                    }



                    

                } 
                
                
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } 
                
                finally {
                    connect.Close();
                }
                
            }

            


            txtSName.Text = "";
            txtSNIC.Text = "";
            txtSTel.Text = "";
            txtSUser.Text = "";
            txtSPass.Text = "";
            txtSAline1.Text = "";
            txtSAline2.Text = "";
            txtSAline3.Text = "";
            txtSAline4.Text = "";
            txtSSID.Text = "";


            sUsername = "";
            sPassword = "";
            sName = "";
            sNic = "";
            sTelephone = "";
            sFirst = "";
            sSecond = "";
            sThird = "";
            sFourth = "";



        }








        private void btnSDelete_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtSSID.Text == "") {
                MessageBox.Show("Insert Security Officer ID Number...!");
            }
            
            else { 
                try
                {

                    connect.Open();

                    String sid = txtSSID.Text;

                    


                    //Select S_STATE from USER table
                    String selectQuery = "SELECT S_STATE FROM USER WHERE S_ID='" + sid + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader myReader = command.ExecuteReader();

                    while (myReader.Read())
                    {
                        this.sState = myReader[0].ToString();
                    }

                    intSState = Int16.Parse(sState);
                    myReader.Close();

                    if (intSState == 1)
                    {
                        //Update USER table
                        String updateQuery1 = "UPDATE USER SET S_STATE="+0+"  WHERE S_ID='"+sid+"'";
                        MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();
                        myReader1.Close();


                        MessageBox.Show("Successfully Deleted Entry...!");

                    }
                    else if (intSState == 0)
                    {
                        MessageBox.Show("This Security Officer Already Has Been Deleted From The System");
                    }
                    else
                    {
                        MessageBox.Show("There Is A Problem With This Vehicle Entry In Database...\n Meet Database Administrator To Fix It...! ");
                    }


                    


                    txtSName.Text = "";
                    txtSNIC.Text = "";
                    txtSTel.Text = "";
                    txtSUser.Text = "";
                    txtSPass.Text = "";
                    txtSAline1.Text = "";
                    txtSAline2.Text = "";
                    txtSAline3.Text = "";
                    txtSAline4.Text = "";
                    txtSSID.Text = "";


                    this.sUsername = "";
                    this.sPassword = "";
                    this.sName = "";
                    this.sNic = "";
                    this.sTelephone = "";
                    this.sFirst = "";
                    this.sSecond = "";
                    this.sThird = "";
                    this.sFourth = "";
                    this.uid = "";
                    this.intUid = 0;
                    this.sState = "";
                    this.intSState = 0;

                    


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
            txtSName.Text = "";
            txtSNIC.Text = "";
            txtSTel.Text = "";
            txtSUser.Text = "";
            txtSPass.Text = "";
            txtSAline1.Text = "";
            txtSAline2.Text = "";
            txtSAline3.Text = "";
            txtSAline4.Text = "";
            txtSSID.Text = "";


            this.sName = "";
            this.sNic = "";
            this.sTelephone = "";
            this.sUsername = "";
            this.sPassword = "";
            this.sFirst = "";
            this.sSecond = "";
            this.sThird = "";
            this.sFourth = "";
            this.uid = "";
            this.intUid = 0;


        }

        private void btnSBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            AdminHome ah = new AdminHome();
            ah.Show();
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {

        }


        // // // // // // //             End Searching Form             // // // // // // //
    }
}
