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
    public partial class Form_viewequipment : Form
    {
        public Form_viewequipment()
        {
            InitializeComponent();
        }

        private void Form_viewequipment_Load(object sender, EventArgs e)
        {
            string connectionstring = @"data source = LAPTOP-PGPNV1BS\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";

            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from Equipment";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewequipment.DataSource = DS.Tables[0] ;


            




        }

       
    }
}
