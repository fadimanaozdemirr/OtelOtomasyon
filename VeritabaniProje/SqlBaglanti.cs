﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VeritabaniProje
{
    public class SqlBaglanti
    {
        public SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D966NE9;Initial Catalog=veritabaniproje;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            return con;
        }
    }
}
