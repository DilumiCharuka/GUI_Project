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
    public partial class FormKaizeDIYGym : Form
    {
        public FormKaizeDIYGym()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
               toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\LENOVO\Downloads\icon\ghjk.PNG");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\LENOVO\Downloads\icon\Untitledtyu.PNG");
            }
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNew_Member nm = new FormNew_Member();
            nm.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Equipment eq=new Form_Equipment();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formsearchmember sm=new Formsearchmember();
            sm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdeletemember dm=new Formdeletemember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close your Application comfirm?","Close",MessageBoxButtons.YesNo, MessageBoxIcon.Error )== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back","Welcome",MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("LOG OUT !!! comform??", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Formlogin lg=new Formlogin();
                lg.Show();
            }

        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formnewstaff nss=new Formnewstaff();
            nss.Show();
        }
    }
}
