using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strconn = "Data Source = Oracle10g;User ID=U006;pwd=ABC123";
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                Console.WriteLine("数据库打开成功!!!");
                Console.ReadKey();
                //MessageBox.Show("数据库打开成功!!!");
                conn.Close();
            }
            catch
            {
                Console.WriteLine("数据库打开成功!!!");
                Console.ReadKey();
            }
        }
    }
}
