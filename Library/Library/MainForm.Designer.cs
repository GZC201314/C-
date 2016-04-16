namespace Library
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("查看违章学生记录");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("更新数据");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("学生借书");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("教师", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("查看个人信息");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("查看当前借阅");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("申请续借");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("图书查询");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("学生", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("图书馆", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用图书管理系统";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(90, 46);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点3";
            treeNode1.Text = "查看违章学生记录";
            treeNode2.Name = "节点4";
            treeNode2.Text = "更新数据";
            treeNode3.Name = "节点5";
            treeNode3.Text = "学生借书";
            treeNode4.Name = "节点1";
            treeNode4.Text = "教师";
            treeNode5.Name = "节点8";
            treeNode5.Text = "查看个人信息";
            treeNode6.Name = "节点9";
            treeNode6.Text = "查看当前借阅";
            treeNode7.Name = "节点10";
            treeNode7.Text = "申请续借";
            treeNode8.Name = "节点0";
            treeNode8.Text = "图书查询";
            treeNode9.Name = "节点7";
            treeNode9.Text = "学生";
            treeNode10.Checked = true;
            treeNode10.Name = "节点0";
            treeNode10.Text = "图书馆";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(264, 223);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 304);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
    }
}