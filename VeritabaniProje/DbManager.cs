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

        public int musteriCek(string komut, string kimlik_no)
        {
            int musteri_id = 0;
            using (SqlConnection baglanti = sqlBaglanti.connection())
            {
                using (SqlCommand command = new SqlCommand(komut, baglanti))
                {

                    command.Parameters.AddWithValue("@kimlik_no", kimlik_no);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        musteri_id = Convert.ToInt32(reader["musteri_id"]);
                    }

                    baglanti.Close();
                }
            }
            return musteri_id;
        }

        public int guncelTabanFiyat(string komut)
        {
            int tabanFiyat = 0;
            using (SqlConnection baglanti = sqlBaglanti.connection())
            {
                using (SqlCommand command = new SqlCommand(komut, baglanti))
                {

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        tabanFiyat = Convert.ToInt32(reader["taban_fiyat"]);
                    }

                    baglanti.Close();
                }
            }
            return tabanFiyat;
        }

    }
}
