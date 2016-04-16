using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm ( )
        {
            InitializeComponent ();
        }

        private void treeView1_AfterSelect ( object sender, TreeViewEventArgs e )
        {
//            MessageBox.Show(treeView1.SelectedNode.ToString());
            if (treeView1.SelectedNode.ToString().EndsWith("查看违章学生记录"))
            {
                this.Hide();
                View_illstudent stu = new View_illstudent();
                stu.Show();
            }
            else if (treeView1.SelectedNode.ToString().EndsWith("更新数据"))
            {
                this.Hide();
                Update update = new Update();
                update.Show();
            }
            else if (treeView1.SelectedNode.ToString().EndsWith("学生借书"))
            {
                this.Hide();
                Borrow borrow = new Borrow();
                borrow.Show();
            }
            else if (treeView1.SelectedNode.ToString ().EndsWith ( "查看个人信息" ))
            {
                this.Hide ();
                myinformation myinfo = new myinformation();
                myinfo.Show();
            }
            else if (treeView1.SelectedNode.ToString ().EndsWith ( "查看当前借阅" ))
            {
                this.Hide ();
                myborrow mybo = new myborrow();
                mybo.Show();
            }
            else if (treeView1.SelectedNode.ToString ().EndsWith ( "申请续借" ))
            {
                this.Hide ();
                myborrow ba = new myborrow();
                ba.Show();
            }
            else if (treeView1.SelectedNode.ToString ().EndsWith ( "图书查询" ))
            {
                this.Hide ();
                Query query = new Query();
                query.Show();
            }




//                MessageBox.Show("nicuole");
        }
//        MessageBox.Show(treeview1);
    }
}
