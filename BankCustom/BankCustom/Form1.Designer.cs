namespace BankCustom
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Store = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "账户名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name.Location = new System.Drawing.Point(231, 111);
            this.Name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(164, 29);
            this.Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(395, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 51);
            this.label3.TabIndex = 0;
            this.label3.Text = "存取款金额";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Money
            // 
            this.Money.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Money.Location = new System.Drawing.Point(563, 110);
            this.Money.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(164, 29);
            this.Money.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(712, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = "账户类型";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "定期存款",
            "活期存款"});
            this.Type.Location = new System.Drawing.Point(879, 110);
            this.Type.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(162, 29);
            this.Type.TabIndex = 2;
            // 
            // Store
            // 
            this.Store.Location = new System.Drawing.Point(298, 213);
            this.Store.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(125, 65);
            this.Store.TabIndex = 3;
            this.Store.Text = "存款\r\n";
            this.Store.UseVisualStyleBackColor = true;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(516, 213);
            this.Draw.Margin = new System.Windows.Forms.Padding(5);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(125, 65);
            this.Draw.TabIndex = 3;
            this.Draw.Text = "取款";
            this.Draw.UseVisualStyleBackColor = true;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(789, 213);
            this.Show.Margin = new System.Windows.Forms.Padding(5);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(125, 65);
            this.Show.TabIndex = 3;
            this.Show.Text = "显示账户信息\r\n";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 286);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1007, 160);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 458);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            //this.Name = "FormMain";
            this.Text = "各人存款业务处理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button Store;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

