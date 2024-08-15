using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kaizen_DIY_Gym
{
    public partial class FormNew_Member : Form
    {
        public FormNew_Member()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = textBoxfirstname.Text;
                string lname = textBoxlastname.Text;

                string gender = "";
                bool isChecked = radioButtonmale.Checked;
                if (isChecked)
                {
                    gender = radioButtonmale.Text;

                }
                else
                {
                    gender = radioButtonfemale.Text;
                }

                string dob = dateTimePickerdateofbirth.Text;
                Int64 mobile = Int64.Parse(textBoxmobile.Text);
                string email = textBoxemail.Text;
                string joindate = dateTimePickerjoindate.Text;
                string gymtime = comboBoxgymtime.Text;
                string address = richTextBoxaddress.Text;
                string membershiptime = comboBoxmembershiptime.Text;


                string connectionstring = @"data source = LAPTOP-PGPNV1BS\SQLEXPRESS;"+"initial catalog=GYM;user id=chalani; password=123456";

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();

                string sql = "insert into Newmember(fname,lname,gender,DOB,mobile,email,joindate,gymtime,Maddress,membershiptime) values ('" + textBoxfirstname.Text + "','" + textBoxlastname.Text + "','" + radioButtonfemale.Text + "','" + dateTimePickerdateofbirth.Text + "','" + textBoxmobile.Text + "','" + textBoxemail.Text + "','" + dateTimePickerjoindate.Text + "','" + comboBoxgymtime.Text + "','" + richTextBoxaddress.Text + "','" + comboBoxmembershiptime.Text + "')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("DATA saved");

            }
            catch(Exception ex)
            {
                MessageBox.Show("incorrect saved____  "+ex.Message);
            }

        }

        private void buttonresert_Click(object sender, EventArgs e)
        {
            textBoxfirstname.Text=string.Empty;
            textBoxlastname.Text=string.Empty;
            textBoxmobile.Text=string.Empty;
            textBoxemail.Text=string.Empty;
            dateTimePickerdateofbirth.Value=DateTime.Now;
            dateTimePickerjoindate.Value=DateTime.Now;
            comboBoxgymtime.Text=string.Empty;
            comboBoxmembershiptime.Text=string.Empty;
            richTextBoxaddress.Text=string.Empty;
            radioButtonmale.Checked=false;
            radioButtonfemale.Checked=false;
        }
    }
}
