using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
namespace Sklad
{
    class SQLClass
    {
        public static MySqlConnection conn;
        public static List<string> Select(string Text)
        {
            List<string> results = new List<string>();

            MySqlCommand command = new MySqlCommand(Text, conn);
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetString(i));
            }

            reader.Close();
            command.Dispose();

            return results;
        }

        public static void Insert(string Text)
        {
            MySqlCommand command = new MySqlCommand(Text, conn);
            DbDataReader reader = command.ExecuteReader();
            reader.Close();
            command.Dispose();
        }
    }
}
