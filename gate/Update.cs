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
    public partial class Update : Form
    {


        Int32 type;
        public Update(Int32 i)
        {
            InitializeComponent();
            type = i;
        }






        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database





        // // // // // // //             Begining Basic Design             // // // // // // //

        private void UniversityOfficerUpdate_Load(object sender, EventArgs e)
        {
            pnlBox.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        // // // // // // //            End Basic Design             // // // // // // //










        // // // // // // // // // //  Begining Update // // // // // // // // // //



        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {

            if (type == 0)
            {

                if (txtUserName.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Insert details in every field...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Check your password again...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }
                else
                {


                    String user = txtUserName.Text;
                    String pass = txtPassword.Text;


                    try
                    {

                        connect.Open();

                        //Update USER table
                        String updateQuery1 = "UPDATE USER SET USERNAME='" + user + "', PASSWORD='" + pass + "'  WHERE USER_TYPE_ID=" + 2 + "";
                        MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();
                        myReader1.Close();



                        MessageBox.Show("Update Successfully...!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";

                    }
                }





            }
            else if (type == 1)
            {


                if (txtUserName.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Insert details in every field...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Check your password again...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }
                else
                {


                    String user = txtUserName.Text;
                    String pass = txtPassword.Text;


                    try
                    {

                        connect.Open();

                        //Update USER table
                        String updateQuery1 = "UPDATE USER SET USERNAME='" + user + "', PASSWORD='" + pass + "'  WHERE USER_TYPE_ID=" + 1 + "";
                        MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();
                        myReader1.Close();



                        MessageBox.Show("Update Successfully...!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";

                    }
                }




            }

        }  

        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {


            if (type == 0)
            {
                this.Close();
                UniversityOfficerHome uoh = new UniversityOfficerHome();
                uoh.Show();
            }
            else if (type == 1) 
            {
                this.Close();
                AdminHome uoh = new AdminHome();
                uoh.Show();
            }

            
        }



        // // // // // // // // // //  End Update // // // // // // // // // //
    }
}
