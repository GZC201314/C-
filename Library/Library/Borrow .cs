using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Borrow : Form
    {
        public Borrow ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            this.Hide();
            MainForm ma = new MainForm();
            ma.Show();
        }

        private static string getdate()
        {
            string date = DateTime.Now.ToString ( "yyyy_MM_dd" );
            return date;
        }

        private void OK_Click ( object sender, EventArgs e )
        {
            try
            {
                string date = getdate ();
                string[] arr = date.Split ( '_' );
                int nyear = int.Parse ( arr[0] );
                int nmonth = int.Parse ( arr[1] );
                int nday = int.Parse (arr[2]);
                nmonth = nmonth + 1;
                string bdate = nyear+"_"+nmonth+"_"+
                nday;
                OracleConnection conn = ConnectionOracle.creaConnection();
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                string str = "insert into jie values('"+rno.Text+"','"+bno.Text+"','"+date+"','"+bdate+"')";
                string str1 = "update book set re=re-1 where bno='"+bno.Text+"'";
                cmd.CommandText = str;
                int row = cmd.ExecuteNonQuery();
                cmd.CommandText = str1;
                int row1 = cmd.ExecuteNonQuery();
                if (row == 1 && row1 == 1)
                {
                    MessageBox.Show("借书成功");
                }
                else
                {
                    MessageBox.Show("借书失败");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }

        }
    }
}
