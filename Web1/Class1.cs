using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public class Class1
    {
        public SqlConnection conectar()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH_4;Integrated Security=True");
            conn.Open();
            return conn;


        }

        

    }
}