using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace VeritabaniProje
{
    public class DbManager
    {
        private DbManager() { }
        private SqlBaglanti baglanti = new SqlBaglanti();
        private static DbManager instance;
        public static DbManager Instance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }

        public void insert(string komut)
        {
            using (var con = baglanti.connection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandText = komut;
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


    }
}
