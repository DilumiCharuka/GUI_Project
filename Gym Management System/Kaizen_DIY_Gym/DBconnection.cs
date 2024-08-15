using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen_DIY_Gym
{
    internal class DBconnection
    {
        public string connectionstring = @"data source=LAPTOP-PGPNV1BS\SQLEXPRESS;" +
            "initial catalog=GYM; User Id= chalani; password=123456";

        public SqlConnection GetDBconnection()
        {
            SqlConnection conobj= new SqlConnection(connectionstring);
            conobj.Open();
            return conobj;
        }
    }
}
