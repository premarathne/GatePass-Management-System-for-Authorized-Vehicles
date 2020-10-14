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
    public partial class VehicleUpdate : Form
    {



        // Globle Variables
        Int32 intOid;
        String vState;
        Int16 intVState;



        public VehicleUpdate(Int32 id)
        {
            InitializeComponent();
            intOid = id;
        }


        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database









        // // // // // // //             Begining Basic Design             // // // // // // //

        private void VehicleUpdate_Load(object sender, EventArgs e)
        {
            pnlBox.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        // // // // // // //             End Basic Design             // // // // // // //













        // // // // // // // // // //  Begining Update // // // // // // // // // //


        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtTel.Text.Length != 10) {
                MessageBox.Show("Check Your Telephone Number Again...!");
                txtTel.Text = "";
            } else if (txtTagNo.Text == "" || txtNIC.Text == "" || txtTel.Text == "" || txtAline1.Text == "" || txtAline2.Text == "" || txtAline3.Text == "") {
                MessageBox.Show("Insert details in every field...!");
            } 
            else {


                try {


                    connect.Open();

                    
                    

                    //Select V_STATE from VEHICLE table
                    String selectQuery = "SELECT V_STATE FROM VEHICLE WHERE O_ID="+intOid+"";
                    MySqlCommand command = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader myReader = command.ExecuteReader();

                    while (myReader.Read())
                    {
                        this.vState = myReader[0].ToString();
                    }

                    intVState = Int16.Parse(vState);
                    myReader.Close();



                    if (intVState == 1)
                    {  //  Checks Vehicle Deleted 


                        String tag = txtTagNo.Text;
                        String nic = txtNIC.Text;
                        String tel = txtTel.Text;
                        String al1 = txtAline1.Text;
                        String al2 = txtAline2.Text;
                        String al3 = txtAline3.Text;
                        String al4 = txtAline4.Text;



                        //Update VEHICLE table
                        String updateQuery1 = "UPDATE VEHICLE SET V_TAG_NO='" + tag + "' WHERE O_ID=" + intOid + "";
                        MySqlCommand command1 = new MySqlCommand(updateQuery1, connect);
                        MySqlDataReader myReader1 = command1.ExecuteReader();
                        myReader1.Close();

                        //Update OWNER table
                        String updateQuery2 = "UPDATE OWNER SET O_NIC='" + nic + "', O_TELEPHONE='" + tel + "' WHERE O_ID=" + intOid + "";
                        MySqlCommand command2 = new MySqlCommand(updateQuery2, connect);
                        MySqlDataReader myReader2 = command2.ExecuteReader();
                        myReader2.Close();

                        //Update O_ADDRESS table
                        String updateQuery3 = "UPDATE O_ADDRESS SET FIRST='" + al1 + "', SECOND='" + al2 + "', THIRD='" + al3 + "', FOURTH='" + al4 + "'  WHERE O_ID=" + intOid + "";
                        MySqlCommand command3 = new MySqlCommand(updateQuery3, connect);
                        MySqlDataReader myReader3 = command3.ExecuteReader();
                        myReader3.Close();



                        MessageBox.Show("Update Successfully...!");


                    }

                    else if (intVState == 0)
                    {
                        MessageBox.Show("Can Not Update This Vehicle.\n This Vehicle Is Deleted...!");
                    }
                    else {
                        MessageBox.Show("ERROR...!");
                    }
                    


                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    connect.Close();

                    txtTagNo.Text = "";
                    txtTel.Text = "";
                    txtNIC.Text = "";
                    txtAline1.Text = "";
                    txtAline2.Text = "";
                    txtAline3.Text = "";
                    txtAline4.Text = "";

                    this.Close();
                }





                

            }


        }





        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtTagNo.Text = "";
            txtNIC.Text = "";
            txtTel.Text = "";
            txtAline1.Text = "";
            txtAline2.Text = "";
            txtAline3.Text = "";
            txtAline4.Text = "";
        }





        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }



        // // // // // // // // // //  End Update // // // // // // // // // //



    }
}
