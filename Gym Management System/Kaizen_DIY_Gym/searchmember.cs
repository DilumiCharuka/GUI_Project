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
    public partial class Formsearchmember : Form
    {
        public Formsearchmember()
        {
            InitializeComponent();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxenterid.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = LAPTOP-PGPNV1BS\\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select  * from Newmember where MID=" + textBoxenterid.Text + "";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridViewsearchmember.DataSource = DS.Tables[0];
                }
                else
                {
                    MessageBox.Show("Please enter some ID");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("cannot search member"+ex.Message);
            }

        }

        private void Formsearchmember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-PGPNV1BS\\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select  * from Newmember";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewsearchmember.DataSource = DS.Tables[0];
        }
    }
}
