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
    public partial class History : Form
    {

        int type;  // admin=0&1, UO=2, SO=3

        




        public History(int i)
        {
            InitializeComponent();

            type = i;
        }




        MySqlConnection connect = new MySqlConnection("Server=localhost;port=3306;username=root;password=;database=SEP"); //create connection with the database
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();






        // // // // // // //             Begining Basic Design             // // // // // // //

        private void History_Load(object sender, EventArgs e)
        {
            pnlHistory.BackColor = Color.FromArgb(100, 0, 0, 0);  //panel transparent
            pnlGride.BackColor = Color.FromArgb(70, 0, 0, 0);  //panel transparent


            if (type == 1 || type == 2 || type == 3)
            {





                try
                {

                    connect.Open();



                    // SELECT TIME_DATE , G_ID, V_NUMBER
                    string selectQuery2 = "SELECT V_ID,TIME_DATE, G_ID  FROM PASS";
                    MySqlCommand command2 = new MySqlCommand(selectQuery2, connect);


                    ad = new MySqlDataAdapter(command2);
                    ad.Fill(dt);


                    foreach (DataRow row in dt.Rows)
                    {

                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
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
            else
            {

            }


        }

        private void populate(String a, String b, String c)
        {
            gridHistory.Rows.Add(a,b,c);
        }
        


        // // // // // // //             End Basic Design             // // // // // // //










        // // // // // // //             Begining Button Actions             // // // // // // //




        

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (type == 0)
            {

            }
            else if (type == 1)
            {
                this.Close();
                AdminHome soh = new AdminHome();
                soh.Show();

                this.type = 0;
            }
            else if (type == 2)
            {
                this.Close();
                UniversityOfficerHome soh = new UniversityOfficerHome();
                soh.Show();

                this.type = 0;
            }
            else if (type == 3)
            {
                this.Close();
                SecurityOfficerHome soh = new SecurityOfficerHome();
                soh.Show();

                this.type = 0;
            }


        }

        private void gridHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // // // // // // //             End Button Actions             // // // // // // //

    }
}
