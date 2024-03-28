using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Cajero
{
    public class Class1
    {
        public SqlConnection conectar()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N6O26FF;Initial Catalog=Cajero;Integrated Security=True");
            conn.Open();
            return conn;

        }

    }
}