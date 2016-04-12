using BankCustoms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_read_and_write
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        System.IO.StreamReader reader;
        List<Custom> list = new List<Custom>();
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files(*.txt)|*.txt";
            //string path = openFileDialog1.FileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine() + "\n";
                    string[] S = line.Split(':');
                    Custom Cus = new Custom();
                    Cus.AccountName = S[0];
                    Cus.AccountBalance = double.Parse(S[1]);
                    Cus.AccountNumber = S[3];
                    Cus.AccountType = S[2];
                    list.Add(Cus);
                    
                }
                reader.Close();
                
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "bankdate.txt";

            System.IO.StreamWriter write = new System.IO.StreamWriter(path, true, Encoding.Default);

            for (int i = 0; i < list.Count();i++ )
            {
                string line = list[i].AccountName+":"+list[i].AccountNumber+":"+
                list[i].AccountType+":"
                    +list[i].AccountBalance.ToString()+"\n";
                write.WriteLine(line);
            }
            write.Close();
        }

        private void 存款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string UserName = this.Name.te
            double Money =double.Parse(this.Money.Text);
            for(int i=0;i<list.Count;i++)
            {
                if(Name==list[i].AccountName)
                {
                    list[i].AccountBalance = list[i].AccountBalance + Money;
                }
            }
        }

    }
}
