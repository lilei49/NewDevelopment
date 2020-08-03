using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Development.DBHelper
{
    public class AbstractDBHelper
    {
        private SqlConnection SqlConnection = new SqlConnection();

        void Open() {
            try
            {
                if (SqlConnection.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                Close();
                Message_Util
            }
            finally
            {
                Close();
            }
        }
        void Close()
        { 
        
        }
    }
}
