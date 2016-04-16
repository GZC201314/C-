/********************************************************************
	created:	2016/04/15
	created:	15:4:2016   10:08
	filename: 	G:\我的C#程序\Library\Library\View_illstudent.cs
	file path:	G:\我的C#程序\Library\Library
	file base:	View_illstudent
	file ext:	cs
	author:		gzc
	
	purpose:	
*********************************************************************/
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
    public partial class View_illstudent : Form
    {
        public View_illstudent ( )
        {
            InitializeComponent ();
        }

        private void label1_Click ( object sender, EventArgs e )
        {
            textBox1.Enabled = true;
//            MessageBox.Show("拟以选择");
//            textBox1.Enabled.ToString();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
//            Teacher tea = new Teacher();
//            tea.Show();
            OracleConnection conn = ConnectionOracle.creaConnection();
//            OracleDataAdapter cmd = new OracleDataAdapter();
//            OracleCommand cmd = conn.CreateCommand();
            conn.Open();
            DataSet ds = new DataSet();
            if (textBox1.Enabled == false)
            {
                try
                {
                    String str = "select * from reader where ifb=1";
                    OracleDataAdapter cmd = new OracleDataAdapter ( str, conn );
                    cmd.Fill ( ds, "info" );
                    dataGridView1.DataSource = ds.Tables["info"];
                    conn.Close ();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    
                    throw;
                }

            }
            else
            {
                String str = "select * from reader where rno = '"+textBox1.Text+"'";
//                cmd.CommandText = str;
                DataSet ds1 = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(str,conn);
                dataAdapter.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
                conn.Close();


            }
        }

        private void all_CheckedChanged ( object sender, EventArgs e )
        {
            textBox1.Enabled = false;
        }
    }
}
