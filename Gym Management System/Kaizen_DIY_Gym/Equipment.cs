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
    public partial class Form_Equipment : Form
    {
        public Form_Equipment()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {

                string  equipmentname=textBoxequipment.Text;
                string Ediscription=richTextBoxdiscription.Text;
                string mused= textBoxMusclessused.Text;
                string Dedate= dateTimePickerdeliverytime.Text;
                Int64 cost= Int64.Parse(textBoxcost.Text);

                string connectionstring = @"data source = LAPTOP-PGPNV1BS\SQLEXPRESS;" + "initial catalog=GYM;user id=chalani; password=123456";

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();

                string sql = "insert into Equipment(EquipName,Ediscriotion,Mused,Cost,DeDate) values ('" + textBoxequipment.Text + "','" +richTextBoxdiscription.Text + "','" +textBoxMusclessused.Text + "','" +textBoxcost.Text + "','"+dateTimePickerdeliverytime.Text+"')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("DATA saved");

            }

            catch (Exception ex) 
            {
                MessageBox.Show("saved failed   "+ex.Message);
            }

        }

        private void buttonresert_Click(object sender, EventArgs e)
        {
            textBoxequipment.Clear();
            textBoxMusclessused.Clear();
            richTextBoxdiscription.Clear();
            textBoxcost.Clear();
            dateTimePickerdeliverytime.Value = DateTime.Now;

        }

        private void buttonviewequipment_Click(object sender, EventArgs e)
        {
            Form_viewequipment ve= new Form_viewequipment();
            ve.Show();
        }
    }
}
