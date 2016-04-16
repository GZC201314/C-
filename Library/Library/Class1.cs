using System;
using System.Data.OracleClient;

public class ConnactionOrcle
{
    public ConnactionOrcle( )
	{
	}

    static OracleConnection createConnection()
    {
        try
        {
            String str = "Data Source=gzc12;Persist Security Info=True;User ID=sysman;Unicode=True;Password=abc123";
            OracleConnection conn = new OracleConnection ( str );
            conn.Open ();
            MessageBox.Show ( "连接数据库成功!" );
        }
        catch (Exception e1)
        {
            MessageBox.Show ( e1.Message );

            throw;
        }
    }
}
