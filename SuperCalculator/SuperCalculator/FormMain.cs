using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public float calculateFrequency()
        {
            float startAmount = float.Parse(this.Money.Text);
            float yearRate = float.Parse(this.Rate.Text);
            int years = int.Parse(this.Year.Text);
            float Sum = startAmount;
            if (this.Methon.Text == "按月算息")
            {
                
                for (int i = 0; i < years * 12;i++)
                {
                    Sum = Sum + Sum * (yearRate / 100 / 12);
                }
       
            }
            if (this.Methon.Text == "按季度算息")
            {
                for (int i = 0; i < years * 4; i++)
                {
                    Sum = Sum + Sum * (yearRate / 100 / 4);
                }
            }
            if(this.Methon.Text == "按年算息")
            {
                for (int i = 0; i < years; i++)
                {
                    Sum = Sum + Sum * (yearRate / 100);
                }
            }


                return Sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Money.Clear();
            this.Sum.Clear();
            this.Year.Clear();
            this.Rate.Clear();

            if(float.Parse(this.Money.Text)<100)
            {
                
                this.Money.Paste("输入的存款低于100,不予计算!");
            }
            else
            {
                float SumMoney = calculateFrequency();
                this.Sum.Paste(SumMoney.ToString());
            }
                


        }
    }
}
