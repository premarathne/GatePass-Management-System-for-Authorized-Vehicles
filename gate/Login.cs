
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
using System.Net;
using System.Net.Mail;
using System.IO;

namespace gate
{
    public partial class Login : Form
    {

        //  Globle Variables
        String usertype;
        Int32 intUsertype;
        String password;
        String uid;
        public static Int32 intUid = 0;
        String state;
        Int32 intState;
        public static Int32 gid =0;
        public static Int32 worksAtId = 0;
        String worksAt;

        

        public Login()
        {
            InitializeComponent();
        }




        



        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database











        // // // // // // //             Begining Basic Design             // // // // // // //


        private void LOGIN_Load(object sender, EventArgs e)  //  Appearence when page is loading

        {
            pnlAdmin.BackColor = Color.FromArgb(100,0,0,0);
            pnlSO.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlUO.BackColor = Color.FromArgb(100, 0, 0, 0);
        }



        // // // // // // //             End Basic Design             // // // // // // //




        












        // // // // // // //             Begining Admin Login             // // // // // // //



        private void btnALogin_MouseClick(object sender, MouseEventArgs e)
        {

            String adminUsername = txtAUser.Text;
            String adminPassword = txtAPass.Text;



            try
            {


                connect.Open();


                if (txtAUser.Text == "" || txtAPass.Text == "")
                {
                    MessageBox.Show("Fill All The Columns Username and Password...!");
                }
                else
                {



                    //Select USER_TYPE_ID and PASSWORD from USER table
                    String selectQuery1 = "SELECT USER_TYPE_ID, PASSWORD, U_ID, S_STATE FROM USER WHERE USERNAME='"+adminUsername+"'";
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        this.usertype = myReader1[0].ToString();
                        this.password = myReader1[1].ToString();
                        this.uid = myReader1[2].ToString();
                        this.state = myReader1[3].ToString();
                    }

                    intUsertype = Int32.Parse(usertype);
                    Login.intUid = Int32.Parse(uid);
                    intState = Int32.Parse(state);
                    myReader1.Close();

                    if (intUsertype == 1 && password == adminPassword && intState == 1)
                    {
                        

                        txtAUser.Text = "";
                        txtAPass.Text = "";
                        

                        this.Hide();
                        AdminHome soh = new AdminHome();
                        soh.Show();

                    }
                    else
                    {
                        MessageBox.Show("Login Failed.....!!");

                        txtAUser.Text = "";
                        txtAPass.Text = "";


                        this.usertype = null;
                        this.intUsertype = 0;
                        this.password = null;
                        this.uid = null;
                        Login.intUid = 0;
                        this.state = null;
                        this.intState = 0;

                    }


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



        } 
        
        
        
        
        
        
        
        private void AForgot_MouseClick(object sender, MouseEventArgs e)
        {

        }



        // // // // // // //             End Admin Login             // // // // // // //












            



        // // // // // // //             Begining Security Officer Login             // // // // // // //



        private void btnSOLogin_MouseClick(object sender, MouseEventArgs e)
        {

           
           
            String soUsername = txtSOUser.Text;
            String soPassword = txtSOPass.Text;
            String soGate = txtSOGate.Text;
            

            if (soGate == "Gate Number 01 - FAS") {
                Login.gid = 1;
            }else if(soGate == "Gate Number 02 - FBSF") {
                Login.gid = 2;
            }



            


            try
            {


                connect.Open();


                if (txtSOUser.Text == "" || txtSOPass.Text == "" || txtSOGate.Text == "")
                {
                    MessageBox.Show("Fill All The Columns Username, Password and Gate...!");
                }
                else { 
                

                
                    //Select from USER table
                    String selectQuery1 = "SELECT USER_TYPE_ID, PASSWORD, U_ID, S_STATE FROM USER WHERE USERNAME='"+soUsername+"'";
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        this.usertype = myReader1[0].ToString();
                        this.password = myReader1[1].ToString();
                        this.uid = myReader1[2].ToString();
                        this.state = myReader1[3].ToString();
                    }

                    intUsertype = int.Parse(usertype);
                    Login.intUid = int.Parse(uid);
                    intState = int.Parse(state);
                    myReader1.Close();

                    if (intUsertype == 3 && password == soPassword && intState==1)
                    {
                    

                        txtSOUser.Text = "";
                        txtSOPass.Text = "";
                        

                        // Insert Login Time
                        String insertQuery2 = "INSERT INTO WORKS_AT (U_ID, G_ID, START_TIME_DATE) VALUES ("+Login.intUid+", "+Login.gid+", CURTIME())";
                        MySqlCommand command2 = new MySqlCommand(insertQuery2, connect);
                        MySqlDataReader myReader2 = command2.ExecuteReader();
                        myReader2.Close();

                        // Select Login ID
                        String selectQuery3 = "SELECT ID FROM WORKS_AT WHERE START_TIME_DATE=CURTIME()";
                        MySqlCommand command3 = new MySqlCommand(selectQuery3, connect);
                        MySqlDataReader myReader3 = command3.ExecuteReader();

                        while (myReader3.Read())
                        {
                            this.worksAt = myReader3[0].ToString();
                        }

                        Login.worksAtId = int.Parse(worksAt);

                        myReader3.Close();


                        



                        // Display Security Officer Home
                        this.Hide();
                        SecurityOfficerHome soh = new SecurityOfficerHome();
                        soh.Show();

                        

                    }
                    else
                    {
                        MessageBox.Show("Login Failed.....!!");

                        txtSOUser.Text = "";
                        txtSOPass.Text = "";


                        this.usertype = null;
                        this.intUsertype = 0;
                        this.password = null;
                        this.uid = null;
                        Login.intUid = 0;
                        this.state = null;
                        this.intState = 0;

                    }
                
                
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






        }
        


        private void SOForgot_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                WebClient client = new WebClient();
                Stream s = client.OpenRead(String.Format("http://api.clickatell.com/http/sendmsg?user=[USERNAME]&password=[PASSWORD]&api_id==[API_ID]&to={0}&text={1}" ,"0772920467", "Hi" ));
                StreamReader sr = new StreamReader(s);
                String result = sr.ReadToEnd();
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // // // // // // //             End Security Officer Login             // // // // // // //



















        // // // // // // //             Begining University Officer Login             // // // // // // //



        private void btnUOLogin_MouseClick(object sender, MouseEventArgs e)
        {


            String uoUsername = txtUOUser.Text;
            String uoPassword = txtUOPass.Text;



            try
            {


                connect.Open();


                if (txtUOUser.Text == "" || txtUOPass.Text == "")
                {
                    MessageBox.Show("Fill All The Columns Username and Password...!");
                }
                else
                {



                    //Select USER_TYPE_ID and PASSWORD from USER table
                    String selectQuery1 = "SELECT USER_TYPE_ID, PASSWORD, U_ID, S_STATE FROM USER WHERE USERNAME='" + uoUsername + "'";
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        this.usertype = myReader1[0].ToString();
                        this.password = myReader1[1].ToString();
                        this.uid = myReader1[2].ToString();
                        this.state = myReader1[3].ToString();
                    }

                    intUsertype = int.Parse(usertype);
                    Login.intUid = int.Parse(uid);
                    intState = int.Parse(state);
                    myReader1.Close();

                    if (intUsertype == 2 && password == uoPassword && intState == 1)
                    {


                        txtUOUser.Text = "";
                        txtUOPass.Text = "";

                        this.intUsertype = 0;
                        this.password = null;
                        this.uid = null;
                        Login.intUid = 0;
                        this.state = null;
                        this.intState = 0;

                        this.Hide();
                        UniversityOfficerHome soh = new UniversityOfficerHome();
                        soh.Show();


                    }
                    else
                    {
                        MessageBox.Show("Login Failed.....!!");

                        txtUOUser.Text = "";
                        txtUOPass.Text = "";


                        this.usertype = null;
                        this.intUsertype = 0;
                        this.password = null;
                        this.uid = null;
                        Login.intUid = 0;
                        this.state = null;
                        this.intState = 0;

                    }


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




        }

        private void UOForgot_MouseClick(object sender, MouseEventArgs e)
                {

                }

        private void btnSOLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnALogin_Click(object sender, EventArgs e)
        {

        }





        // // // // // // //             End University Officer Login             // // // // // // //






    }



}