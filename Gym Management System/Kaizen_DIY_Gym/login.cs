using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaizen_DIY_Gym
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxusername.Text == "admin" && textBoxpassword.Text == "417")
                {
                    FormKaizeDIYGym fm = new FormKaizeDIYGym();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("failed" + ex.Message);
            }
        }
    }
}
