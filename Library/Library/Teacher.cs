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
    public partial class Teacher : Form
    {
        public Teacher ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            this.Hide();
            MainForm ma = new MainForm();
            ma.Show();
        }

        private void OK_Click ( object sender, EventArgs e )
        {
            try
            {
                OracleConnection conn = ConnectionOracle.creaConnection();
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select count(*) from admins where id='"+tno.Text+"' and psw='"+Psw.Text+"'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString ().Equals ( "1" ))
                    {
                        this.Hide();
                        View_illstudent stu = new View_illstudent();
                        stu.Show();
                        return;
                    }
                }
                MessageBox.Show("用户没有找到");
//                cmd.ExecuteScalar() + "";
                //               int raw = cmd.ExecuteOracleScalar();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                
                throw;
            }
        }
    }
}
