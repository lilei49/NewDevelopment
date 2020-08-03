using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Development.Util;

namespace Development.DBHelper
{
    public class AbstractDBHelper
    {
        private SqlConnection SqlConnection = new SqlConnection();

        public DataSet GetData(SqlCommand sqlCommand)
        {
            DataSet ds = new DataSet();
            try
            {
                Open();
                sqlCommand.Connection = SqlConnection;
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                sqlData.Fill(ds,"Table");
                return ds;
            }
            catch (Exception ex)
            {
                Message_Util.MessageTxt = ex.Message; Message_Util.MessageTitle = "错误"; Message_Util.MessageState = true;
                return ds;
            }
            finally { Close(); }
        }



        #region 公用方法
        void Open() {
            try
            {
                SqlConnection.ConnectionString = Connection_Util.ConnString;
                if (SqlConnection.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                Close();
                Message_Util.MessageTxt = ex.Message;Message_Util.MessageTitle = "错误";Message_Util.MessageState = true;
            }
            finally
            {
                Close();
            }
        }
        void Close()
        {
            try
            {
                if (SqlConnection.State==ConnectionState.Open)
                {
                    SqlConnection.Close(); ;
                }
            }
            catch (Exception ex)
            {
                Close();
                Message_Util.MessageTxt = ex.Message; Message_Util.MessageTitle = "错误"; Message_Util.MessageState = true;
            }
        }
        #endregion
    }
}
