using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace Library
{
  static class ConnectionOracle
    {
       public static OracleConnection creaConnection()
        {
            String str = "Data Source=gzc12;Persist Security Info=True;User ID=sysman;Unicode=True;Password=abc123";
            OracleConnection conn = new OracleConnection ( str );
//            conn.Open ();
//            MessageBox.Show ( "连接数据库成功!" );
            return conn;
        }
    }
}
