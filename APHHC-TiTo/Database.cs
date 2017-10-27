using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace APHHC_TiTo
{
    public static class Database
    {
        public static SqlConnection DatabaseConnect()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database.");
                throw;
            }
        }

        public static bool RunStoredProcedure(SqlCommand cmd)
        {
            using (SqlConnection conn = DatabaseConnect())
            {
                cmd.Connection = conn;
                int row = cmd.ExecuteNonQuery();

                return (row>0)? true: false;   
            }
        }

        public static object GetSingleFromDatabase(SqlCommand cmd)
        {
            using (SqlConnection conn = DatabaseConnect())
            {
                cmd.Connection = conn;

                try
                {
                    object returnedValue = cmd.ExecuteScalar();
                    return (returnedValue != null? returnedValue : 0);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
