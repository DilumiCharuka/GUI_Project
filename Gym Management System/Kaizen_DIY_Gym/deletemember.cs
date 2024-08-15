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
    public partial class Formdeletemember : Form
    {
        public Formdeletemember()
        {
            InitializeComponent();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure delete this member?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = LAPTOP-PGPNV1BS\\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "delete from Newmember where MID= " + textBoxDeenterid.Text + "";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                }
                else
                {
                    this.Activate();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = LAPTOP-PGPNV1BS\\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select  * from Newmember";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridViewdeletemember.DataSource = DS.Tables[0];

                }


            }
            catch(Exception ex) 
            {
                MessageBox.Show("Delete Unsuccessfull" + ex.Message);
            }
        }

        private void Formdeletemember_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-PGPNV1BS\\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=12345";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select  * from Newmember";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridViewdeletemember.DataSource = DS.Tables[0];
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
