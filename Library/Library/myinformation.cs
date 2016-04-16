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
    public partial class myinformation : Form
    {
        public myinformation ( )
        {
            InitializeComponent ();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            this.Hide();
            MainForm ma = new MainForm();
            ma.Show();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            try
            {
                OracleConnection conn = ConnectionOracle.creaConnection();
                conn.Open();
                string str = "select * from reader where rno='"+textBox1.Text+"'";
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = conn.CreateCommand();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
//                dataGridView1.


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }
        }
    }
}
