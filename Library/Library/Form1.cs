
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
                OracleConnection conn = ConnectionOracle.creaConnection ();
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select count(*) from admins where id='" + Uname.Text + "'and psw='" + Psw.Text + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
//                    int 
                    if (reader[0].ToString().Equals("1"))
                    {
                    MessageBox.Show("用户已找到,登陆成功");
                    MainForm main = new MainForm();
//                        this.Disposing();
                        this.Hide();    
                        main.ShowDialog();
                        

                        


                    return;
                    }

                }
                MessageBox.Show("没有找到你的记录,请检查输入,或联系管理员.");
//                cmd.ExecuteReader(str);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                
                throw;
            }
//            ConnectionOracle conn = 
//            ConnectionOracle conn = new ConnectionOracle();/

            

        }
    }
}
