namespace SuperCalculator
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Methon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "存款金额(元)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入信息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "年利率(%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "存期(年)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "利息计算方法";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(194, 52);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(140, 21);
            this.Money.TabIndex = 1;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(194, 95);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(140, 21);
            this.Rate.TabIndex = 1;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(194, 135);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(140, 21);
            this.Year.TabIndex = 1;
            this.Year.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Methon
            // 
            this.Methon.FormattingEnabled = true;
            this.Methon.Items.AddRange(new object[] {
            "按年算息",
            "按季度算息",
            "按月算息"});
            this.Methon.Location = new System.Drawing.Point(194, 181);
            this.Methon.Name = "Methon";
            this.Methon.Size = new System.Drawing.Size(140, 20);
            this.Methon.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(55, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "到期估算金额";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(194, 249);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(140, 21);
            this.Sum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(116, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Methon);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "FormMain";
            this.Text = "超级存款计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.ComboBox Methon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Button button1;
    }
}

