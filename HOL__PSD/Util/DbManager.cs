using System.Data;
using System.Data.SqlClient;

namespace HOL__PSD.Util
{
    public class DbManager
    {
        static SqlConnection connection;

        private DbManager() { }

        public static SqlConnection GetInstance()
        {
            if (DbManager.connection == null)
            {
                string attachDbFilename = @"F:\! Work\HOL PSD\HOL__PSD\HOL__PSD\App_Data\WatchShop.mdf";
                DbManager.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + attachDbFilename + ";Integrated Security=True");
            }

            return DbManager.connection;
        }

        public static DataTable Get(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = GetInstance())
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                connection.Close();
            }

            return dt;
        }

        public static void Execute(string query)
        {
            using (SqlConnection connection = GetInstance())
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
