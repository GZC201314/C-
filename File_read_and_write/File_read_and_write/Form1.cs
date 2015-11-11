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
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files(*.txt)|*.txt";
            //string path = openFileDialog1.FileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);
                //reader.BaseStream.Seek(10,System.IO.SeekOrigin.Begin);
                string line = reader.ReadLine()+"\n";
                while(line!=null)
                {
                    richTextBox1.AppendText(line);
                    line = reader.ReadLine() + "\n";
                }
                richTextBox1.AppendText("这个循环执行完了");
                reader.Close();
                //richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "bankdate.txt";

            System.IO.StreamWriter write = new System.IO.StreamWriter(path, true, Encoding.UTF8);
            string line = reader.ReadLine()+"\n";
            while(line!=null)
            {
                write.WriteLine(line);
                line = reader.ReadLine();
            }
        }

    }
}
