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
    public partial class SecurityOfficerUpdateSO : Form
    {
        

        // Globle variables
        Int32 intUID;



        public SecurityOfficerUpdateSO(Int32 uid)
        {
            InitializeComponent();
            intUID = uid;
        }



        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database







        // // // // // // //             Begining Basic Design             // // // // // // //


        private void SecurityOfficerUpdate_Load(object sender, EventArgs e)
        {
            pnlBox.BackColor = Color.FromArgb(100, 0, 0, 0);

        }
        // // // // // // //             End Basic Design             // // // // // // //














        // // // // // // // // // //  Begining Update // // // // // // // // // //


        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {



            String name = txtName.Text;
            String nic = txtNIC.Text;
            String tel = txtTel.Text;
            String aL1 = txtAline1.Text;
            String aL2 = txtAline2.Text;
            String aL3 = txtAline3.Text;
            String aL4 = txtAline4.Text;
            String username = txtUser.Text;
            String pass = txtPass.Text;
            String conPass = txtConPass.Text;


            if (txtName.Text == "" || txtNIC.Text == "" || txtTel.Text == "" || txtAline1.Text == "" || txtAline2.Text == "" || txtAline3.Text == "" || txtUser.Text == "" || txtPass.Text == "" || txtConPass.Text == "")
            {
                MessageBox.Show("Insert details in every field...!");
            }
            else if (tel.Length != 10) {
                MessageBox.Show("Check your telephone number again...!");
                txtTel.Text = "";
            }
            else if (pass != conPass) {
                MessageBox.Show("Check your password again...!");
                txtPass.Text = "";
                txtConPass.Text = "";
            }
            else { 

                try
                {

                    connect.Open();

                

                    //Update USER table
                    String updateQuery1 = "UPDATE USER SET S_NAME='"+name+"', S_NIC='"+nic+"', S_TELEPHONE='"+tel+"', USERNAME='"+username+"', PASSWORD='"+pass+"'  WHERE U_ID="+intUID+"";
                    MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                    MySqlDataReader myReader1 = command1.ExecuteReader();
                    myReader1.Close();

                    //Update SO_ADDRESS table
                    String updateQuery2 = "UPDATE SO_ADDRESS SET FIRST='"+aL1+"', SECOND='"+aL2+"', THIRD='"+aL3+"', FOURTH='"+aL4+"'  WHERE U_ID="+intUID+"";
                    MySqlCommand command2 = new MySqlCommand(updateQuery2, connect);
                    MySqlDataReader myReader2 = command2.ExecuteReader();
                    myReader2.Close();



                    MessageBox.Show("Update Successfully...!");



                    txtName.Text = "";
                    txtNIC.Text = "";
                    txtTel.Text = "";
                    txtAline1.Text = "";
                    txtAline2.Text = "";
                    txtAline3.Text = "";
                    txtAline4.Text = "";
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtConPass.Text = "";



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





        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "";
            txtNIC.Text = "";
            txtTel.Text = "";
            txtAline1.Text = "";
            txtAline2.Text = "";
            txtAline3.Text = "";
            txtAline4.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtConPass.Text = "";
        }





        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            
        }


        // // // // // // // // // //  End Update // // // // // // // // // //





    }
}
