using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent ();
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            try
            {
            String str = "Data Source=gzc12;Persist Security Info=True;User ID=sysman;Unicode=True;Password=abc123";
            OracleConnection conn = new OracleConnection(str);
                conn.Open();
                MessageBox.Show("连接数据库成功!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                
                throw;
            }

        }
    }
}
