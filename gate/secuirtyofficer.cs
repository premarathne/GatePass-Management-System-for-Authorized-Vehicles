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
    public partial class secuirtyofficer : Form
    {
        public secuirtyofficer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string myconnection = "server=localhost;port=3306;username=root;password=;database=gatepass";
            string myconnection = "server=localhost;port=3306;username=root;password=;database=gatepass";
            string query = "INSERT INTO gatepass.users(id,name,contactno,username,password,confirmpassword,user_typeid,NIC_number) VALUES ('" + this.textBox8.Text + "','" + this.textBox1.Text + "','" + this.textBox7.Text + "','" + this.textBox11.Text + "','" + this.textBox10.Text + "','" + this.textBox9.Text + "','" + 2 + "','" + this.textBox2.Text + "');";
            // string query1 = "INSERT INTO gatepass.admin(id,email)VALUES ('" + this.textBox1.Text + "','" + this.textBox2.Text + "');"; ;
            string query2 = "INSERT INTO gatepass.address(userid,number,Road,Town,City)VALUES ('" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "');"; ;


            string count1 = "SELECT username FROM users";
            MySqlConnection con = new MySqlConnection(myconnection);
            con.Open();
            MySqlCommand mycommand = new MySqlCommand(query, con);
            MySqlCommand mycommand2 = new MySqlCommand(query2, con);
            MySqlCommand mycommand1 = new MySqlCommand(count1, con);
            String username = mycommand1.ExecuteScalar().ToString();
            // MySqlDataReader sqldr = mycommand1.ExecuteReader();


            if (username == textBox11.Text)
            {

                MessageBox.Show("Username is already Exisits");
            }


            if (textBox8.Text == null || textBox1.Text == null || textBox7.Text == null || textBox11.Text == null || textBox10.Text == null || textBox9.Text == null || textBox2.Text == null)
            {

                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            // check if the password equal the confirm password
            else if (textBox10.Text.Equals(textBox9.Text))
            {
                con.Open();

                MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Errorr !!!!!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }











            // close the connection
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myconnection = "server=localhost;port=3306;username=root;password=;database=gatepass";
            MySqlConnection con = new MySqlConnection(myconnection);
        }
    }
}

