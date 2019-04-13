using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPF_App.Model
{
    class ConnSQL
    {
        private static bool isConnected;
        public static bool IsConnected { get => isConnected; set => isConnected = value; }

        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PEJHOGB;Initial Catalog=NowaBaza;Integrated Security=True");
        public void Connection()
        //public void Connection(string connectionID, string sqlquarty)
        {
            try
            {
                // using (SqlConnection connection = new SqlConnection(connectionID))
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PEJHOGB;Initial Catalog=NowaBaza;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Table", connection))
                    //using (SqlCommand command = new SqlCommand(sqlquarty, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine(reader.GetValue(i));
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("can not open connection ! ");
                IsConnected = false;
            }
        }
    }
}
