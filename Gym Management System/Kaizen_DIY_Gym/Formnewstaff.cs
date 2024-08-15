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
    public partial class Formnewstaff : Form
    {
        public Formnewstaff()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {

                string fname = textBoxsfirstname.Text;
                string lname = textBoxslastname.Text;
                string gender = "";

                bool ischeaked = radioButtonsgenader.Checked;
                if (ischeaked)
                {
                    gender = radioButtonsgenader.Text;
                }
                else
                {
                    gender = radioButtonsfgender.Text;
                }
                string dob = dateTimePickersdofbirth.Text;
                Int64 mobile = Int64.Parse(textBoxsmobile.Text);
                string email = textBoxsemail.Text;
                string jdate = dateTimePickersjooindate.Text;
                string state = textBoxsstate.Text;
                string city = textBoxscitty.Text;

                string connectionstring = @"data source = LAPTOP-PGPNV1BS\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();

                string sql = "insert into NewStaff(fname,lname,gender,dob,mobile,email,jdate,statee,city) values ('" +textBoxsfirstname.Text + "','" +textBoxslastname.Text + "','" + radioButtonsgenader.Text + "','" + dateTimePickersdofbirth.Text + "','" + textBoxsmobile.Text + "','" +textBoxsemail.Text + "','" +dateTimePickersjooindate.Text + "','" +textBoxsstate.Text + "','"+textBoxscitty.Text + "')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("DATA saved");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonresert_Click(object sender, EventArgs e)
        {
            textBoxsfirstname.Clear();
            textBoxslastname.Clear();
            textBoxsemail.Clear();
            textBoxscitty.Clear();
            textBoxsmobile.Clear();
            textBoxscitty.Clear();
            textBoxsstate.Clear();
            dateTimePickersdofbirth.Value= DateTime.Now;
            dateTimePickersjooindate.Value= DateTime.Now;
            radioButtonsfgender.Checked= false;
            radioButtonsgenader.Checked= false;
        }
    }
}
