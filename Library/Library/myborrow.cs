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
    public partial class myborrow : Form
    {
        public myborrow ( )
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
                string str = "select reader.rname,book.bname,jie.date2 from reader jie book where book.bno=jie.bno and reader.rno = jie.rno and reader.rno='"+textBox1.Text+"'";
                DataSet ds = new DataSet();
                  OracleDataAdapter da = new OracleDataAdapter(str,conn);
                da.Fill(ds);
                string str1 = "select book.bname from reader jie book where book.bno=jie.bno and reader.rno = jie.rno and reader.rno='" + textBox1.Text + "'";
                da = new OracleDataAdapter(str1,conn);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
//                if(ds.)
                comboBox1.DataSource = ds1.Tables[0];
                comboBox1.DisplayMember = "bno";
                comboBox1.ValueMember = "bno";
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }
        }
    }
}
