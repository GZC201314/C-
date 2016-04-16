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
    public partial class Update : Form
    {
        public Update ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            this.Hide();
            MainForm ma = new MainForm();
            ma.Show();
        }

        private void ok_Click ( object sender, EventArgs e )
        {
            try
            {
                OracleConnection conn = ConnectionOracle.creaConnection();
                OracleCommand cmd = conn.CreateCommand();
                string str = "delete from jie where rno='"+rno.Text+"'and bno='"+bno.Text+"'";
                cmd.CommandText = str;
                int row = cmd.ExecuteNonQuery();
                string str1 = "update book set re=re-1 where bno = '"+bno.Text+"'";
                cmd.CommandText = str1;
                int row1 = cmd.ExecuteNonQuery();
                if (row == 1 && row1 == 1)
                {
                    MessageBox.Show("还书成功");
                }
                else
                {
                    MessageBox.Show("没有找到你的借书记录,请检查你的输入");
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
