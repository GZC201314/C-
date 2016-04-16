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
    public partial class Query : Form
    {
        public Query ( )
        {
            InitializeComponent ();
        }

        private void Query_Load ( object sender, EventArgs e )
        {
            label1.Visible = false;
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void radioButton1_CheckedChanged ( object sender, EventArgs e )
        {
            label1.Text = "书名";
            textBox1.Enabled = true;
        }

        private void radioButton2_CheckedChanged ( object sender, EventArgs e )
        {
            label1.Text = "作者名";
            textBox1.Enabled = true;
        }

        private void radioButton3_CheckedChanged ( object sender, EventArgs e )
        {
            label1.Text = "关键字";
            textBox1.Enabled = true;
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
                string str ="";
                if (radioButton1.Checked)
                {
                    str = "select * from book where bname='" + textBox1.Text + "'";
                }
                if (radioButton2.Checked)
                {
                    str = "select * from book where auther = '" + textBox1.Text + "'";
                }
                if (radioButton3.Checked)
                {
                    str = "select * from book where pkey='"+textBox1.Text+"' or pkey1='"+textBox1.Text+"' or pkey2='"+textBox1.Text+"'";
                }
                OracleCommand cmd = conn.CreateCommand();
                OracleDataAdapter da = new OracleDataAdapter(str,conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource =
                    ds.Tables[0];
                conn.Open();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }
        }

        private void radioButton1_Click ( object sender, EventArgs e )
        {
            label1.Text = "书名";
            textBox1.Enabled = true;
        }

        private void radioButton2_Click ( object sender, EventArgs e )
        {
            label1.Text = "作者名";
            textBox1.Enabled = true;
        }

        private void radioButton3_Click ( object sender, EventArgs e )
        {
            label1.Text = "关键字";
            textBox1.Enabled = true;
        }
    }
}
