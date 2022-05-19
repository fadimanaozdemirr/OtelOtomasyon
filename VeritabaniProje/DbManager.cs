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
        private SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private static DbManager instance;
        public static DbManager Instance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }

        public void veritabaniKomut(string komut)
        {
            using (SqlConnection baglanti = sqlBaglanti.connection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = baglanti;
                    command.CommandText = komut;
                    command.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }


    }
}
