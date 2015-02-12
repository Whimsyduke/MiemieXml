namespace MiemieXml
{
    partial class MieMieXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MieMieXML));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.buttonAddUpdata = new System.Windows.Forms.Button();
            this.treeViewALL = new System.Windows.Forms.TreeView();
            this.buttonDelUpdata = new System.Windows.Forms.Button();
            this.buttonXML = new System.Windows.Forms.Button();
            this.checkedListBoxFolder = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxFullCheck = new System.Windows.Forms.CheckedListBox();
            this.buttonDelCheck = new System.Windows.Forms.Button();
            this.buttonAddCheck = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FolderMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAllFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCheckFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUpdataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCheckFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUpdataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成XML文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成XML文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.生成设置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdataLable = new System.Windows.Forms.Label();
            this.CheckLable = new System.Windows.Forms.Label();
            this.LabelFtpLT = new System.Windows.Forms.Label();
            this.LabelFtpDX = new System.Windows.Forms.Label();
            this.TextBoxIPLT = new System.Windows.Forms.TextBox();
            this.TextBoxIPDX = new System.Windows.Forms.TextBox();
            this.LableID = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LablePassword = new System.Windows.Forms.Label();
            this.ButtonGenerationSet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripMain.Location = new System.Drawing.Point(0, 509);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(834, 22);
            this.statusStripMain.TabIndex = 1;
            // 
            // buttonAddUpdata
            // 
            this.buttonAddUpdata.Location = new System.Drawing.Point(449, 482);
            this.buttonAddUpdata.Name = "buttonAddUpdata";
            this.buttonAddUpdata.Size = new System.Drawing.Size(90, 23);
            this.buttonAddUpdata.TabIndex = 4;
            this.buttonAddUpdata.Text = "添加更新目录";
            this.buttonAddUpdata.UseVisualStyleBackColor = true;
            this.buttonAddUpdata.Click += new System.EventHandler(this.buttonAddUpdata_Click);
            // 
            // treeViewALL
            // 
            this.treeViewALL.CheckBoxes = true;
            this.treeViewALL.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewALL.Location = new System.Drawing.Point(0, 25);
            this.treeViewALL.Name = "treeViewALL";
            this.treeViewALL.Size = new System.Drawing.Size(250, 484);
            this.treeViewALL.TabIndex = 4;
            this.treeViewALL.TabStop = false;
            this.treeViewALL.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewALL_AfterCheck);
            // 
            // buttonDelUpdata
            // 
            this.buttonDelUpdata.Location = new System.Drawing.Point(641, 482);
            this.buttonDelUpdata.Name = "buttonDelUpdata";
            this.buttonDelUpdata.Size = new System.Drawing.Size(90, 23);
            this.buttonDelUpdata.TabIndex = 5;
            this.buttonDelUpdata.Text = "移除更新目录";
            this.buttonDelUpdata.UseVisualStyleBackColor = true;
            this.buttonDelUpdata.Click += new System.EventHandler(this.buttonDelUpdata_Click);
            // 
            // buttonXML
            // 
            this.buttonXML.Location = new System.Drawing.Point(734, 482);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(90, 23);
            this.buttonXML.TabIndex = 3;
            this.buttonXML.Text = "生成XML文件";
            this.buttonXML.UseVisualStyleBackColor = true;
            this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // checkedListBoxFolder
            // 
            this.checkedListBoxFolder.FormattingEnabled = true;
            this.checkedListBoxFolder.Location = new System.Drawing.Point(256, 299);
            this.checkedListBoxFolder.Name = "checkedListBoxFolder";
            this.checkedListBoxFolder.Size = new System.Drawing.Size(570, 180);
            this.checkedListBoxFolder.Sorted = true;
            this.checkedListBoxFolder.TabIndex = 10;
            this.checkedListBoxFolder.TabStop = false;
            // 
            // checkedListBoxFullCheck
            // 
            this.checkedListBoxFullCheck.FormattingEnabled = true;
            this.checkedListBoxFullCheck.Location = new System.Drawing.Point(256, 101);
            this.checkedListBoxFullCheck.Name = "checkedListBoxFullCheck";
            this.checkedListBoxFullCheck.Size = new System.Drawing.Size(570, 180);
            this.checkedListBoxFullCheck.Sorted = true;
            this.checkedListBoxFullCheck.TabIndex = 11;
            this.checkedListBoxFullCheck.TabStop = false;
            // 
            // buttonDelCheck
            // 
            this.buttonDelCheck.Location = new System.Drawing.Point(545, 482);
            this.buttonDelCheck.Name = "buttonDelCheck";
            this.buttonDelCheck.Size = new System.Drawing.Size(90, 23);
            this.buttonDelCheck.TabIndex = 2;
            this.buttonDelCheck.Text = "移除检测目录";
            this.buttonDelCheck.UseVisualStyleBackColor = true;
            this.buttonDelCheck.Click += new System.EventHandler(this.buttonDelCheck_Click);
            // 
            // buttonAddCheck
            // 
            this.buttonAddCheck.Location = new System.Drawing.Point(353, 482);
            this.buttonAddCheck.Name = "buttonAddCheck";
            this.buttonAddCheck.Size = new System.Drawing.Size(90, 23);
            this.buttonAddCheck.TabIndex = 1;
            this.buttonAddCheck.Text = "添加检测目录";
            this.buttonAddCheck.UseVisualStyleBackColor = true;
            this.buttonAddCheck.Click += new System.EventHandler(this.buttonAddCheck_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(257, 482);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(90, 23);
            this.buttonAddAll.TabIndex = 6;
            this.buttonAddAll.Text = "添加全部目录";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderMenuToolStripMenuItem,
            this.生成XML文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FolderMenuToolStripMenuItem
            // 
            this.FolderMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAllFolderToolStripMenuItem,
            this.AddCheckFolderToolStripMenuItem,
            this.AddUpdataFolderToolStripMenuItem,
            this.RemoveCheckFolderToolStripMenuItem,
            this.RemoveUpdataFolderToolStripMenuItem});
            this.FolderMenuToolStripMenuItem.Name = "FolderMenuToolStripMenuItem";
            this.FolderMenuToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.FolderMenuToolStripMenuItem.Text = "目录处理";
            // 
            // AddAllFolderToolStripMenuItem
            // 
            this.AddAllFolderToolStripMenuItem.Name = "AddAllFolderToolStripMenuItem";
            this.AddAllFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddAllFolderToolStripMenuItem.Text = "添加全部目录";
            this.AddAllFolderToolStripMenuItem.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // AddCheckFolderToolStripMenuItem
            // 
            this.AddCheckFolderToolStripMenuItem.Name = "AddCheckFolderToolStripMenuItem";
            this.AddCheckFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddCheckFolderToolStripMenuItem.Text = "添加检测目录";
            this.AddCheckFolderToolStripMenuItem.Click += new System.EventHandler(this.buttonAddCheck_Click);
            // 
            // AddUpdataFolderToolStripMenuItem
            // 
            this.AddUpdataFolderToolStripMenuItem.Name = "AddUpdataFolderToolStripMenuItem";
            this.AddUpdataFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddUpdataFolderToolStripMenuItem.Text = "添加更新目录";
            this.AddUpdataFolderToolStripMenuItem.Click += new System.EventHandler(this.buttonAddUpdata_Click);
            // 
            // RemoveCheckFolderToolStripMenuItem
            // 
            this.RemoveCheckFolderToolStripMenuItem.Name = "RemoveCheckFolderToolStripMenuItem";
            this.RemoveCheckFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.RemoveCheckFolderToolStripMenuItem.Text = "移除检测目录";
            this.RemoveCheckFolderToolStripMenuItem.Click += new System.EventHandler(this.buttonDelCheck_Click);
            // 
            // RemoveUpdataFolderToolStripMenuItem
            // 
            this.RemoveUpdataFolderToolStripMenuItem.Name = "RemoveUpdataFolderToolStripMenuItem";
            this.RemoveUpdataFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.RemoveUpdataFolderToolStripMenuItem.Text = "移除更新目录";
            this.RemoveUpdataFolderToolStripMenuItem.Click += new System.EventHandler(this.buttonDelUpdata_Click);
            // 
            // 生成XML文件ToolStripMenuItem
            // 
            this.生成XML文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成XML文件ToolStripMenuItem1,
            this.生成设置文件ToolStripMenuItem});
            this.生成XML文件ToolStripMenuItem.Name = "生成XML文件ToolStripMenuItem";
            this.生成XML文件ToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.生成XML文件ToolStripMenuItem.Text = "生成XML文件";
            // 
            // 生成XML文件ToolStripMenuItem1
            // 
            this.生成XML文件ToolStripMenuItem1.Name = "生成XML文件ToolStripMenuItem1";
            this.生成XML文件ToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.生成XML文件ToolStripMenuItem1.Text = "生成XML文件";
            this.生成XML文件ToolStripMenuItem1.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // 生成设置文件ToolStripMenuItem
            // 
            this.生成设置文件ToolStripMenuItem.Name = "生成设置文件ToolStripMenuItem";
            this.生成设置文件ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.生成设置文件ToolStripMenuItem.Text = "生成设置文件";
            this.生成设置文件ToolStripMenuItem.Click += new System.EventHandler(this.ButtonGenerationSet_Click);
            // 
            // UpdataLable
            // 
            this.UpdataLable.AutoSize = true;
            this.UpdataLable.Location = new System.Drawing.Point(259, 284);
            this.UpdataLable.Name = "UpdataLable";
            this.UpdataLable.Size = new System.Drawing.Size(89, 12);
            this.UpdataLable.TabIndex = 14;
            this.UpdataLable.Text = "更新目录列表：";
            // 
            // CheckLable
            // 
            this.CheckLable.AutoSize = true;
            this.CheckLable.Location = new System.Drawing.Point(259, 86);
            this.CheckLable.Name = "CheckLable";
            this.CheckLable.Size = new System.Drawing.Size(89, 12);
            this.CheckLable.TabIndex = 15;
            this.CheckLable.Text = "检测目录列表：";
            // 
            // LabelFtpLT
            // 
            this.LabelFtpLT.AutoSize = true;
            this.LabelFtpLT.Location = new System.Drawing.Point(259, 38);
            this.LabelFtpLT.Name = "LabelFtpLT";
            this.LabelFtpLT.Size = new System.Drawing.Size(53, 12);
            this.LabelFtpLT.TabIndex = 16;
            this.LabelFtpLT.Text = "联通IP：";
            // 
            // LabelFtpDX
            // 
            this.LabelFtpDX.AutoSize = true;
            this.LabelFtpDX.Location = new System.Drawing.Point(259, 63);
            this.LabelFtpDX.Name = "LabelFtpDX";
            this.LabelFtpDX.Size = new System.Drawing.Size(53, 12);
            this.LabelFtpDX.TabIndex = 17;
            this.LabelFtpDX.Text = "电信IP：";
            // 
            // TextBoxIPLT
            // 
            this.TextBoxIPLT.Location = new System.Drawing.Point(315, 34);
            this.TextBoxIPLT.Name = "TextBoxIPLT";
            this.TextBoxIPLT.Size = new System.Drawing.Size(180, 21);
            this.TextBoxIPLT.TabIndex = 18;
            // 
            // TextBoxIPDX
            // 
            this.TextBoxIPDX.Location = new System.Drawing.Point(315, 60);
            this.TextBoxIPDX.Name = "TextBoxIPDX";
            this.TextBoxIPDX.Size = new System.Drawing.Size(180, 21);
            this.TextBoxIPDX.TabIndex = 19;
            // 
            // LableID
            // 
            this.LableID.AutoSize = true;
            this.LableID.Location = new System.Drawing.Point(503, 38);
            this.LableID.Name = "LableID";
            this.LableID.Size = new System.Drawing.Size(71, 12);
            this.LableID.TabIndex = 20;
            this.LableID.Text = "FTP用户名：";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(581, 34);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(180, 21);
            this.TextBoxID.TabIndex = 21;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(581, 60);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(180, 21);
            this.TextBoxPassword.TabIndex = 23;
            // 
            // LablePassword
            // 
            this.LablePassword.AutoSize = true;
            this.LablePassword.Location = new System.Drawing.Point(503, 64);
            this.LablePassword.Name = "LablePassword";
            this.LablePassword.Size = new System.Drawing.Size(71, 12);
            this.LablePassword.TabIndex = 22;
            this.LablePassword.Text = "FTP密码  ：";
            // 
            // ButtonGenerationSet
            // 
            this.ButtonGenerationSet.Location = new System.Drawing.Point(767, 34);
            this.ButtonGenerationSet.Name = "ButtonGenerationSet";
            this.ButtonGenerationSet.Size = new System.Drawing.Size(57, 47);
            this.ButtonGenerationSet.TabIndex = 24;
            this.ButtonGenerationSet.Text = "生成设置文件";
            this.ButtonGenerationSet.UseVisualStyleBackColor = true;
            this.ButtonGenerationSet.Click += new System.EventHandler(this.ButtonGenerationSet_Click);
            // 
            // MieMieXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.ButtonGenerationSet);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LablePassword);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.LableID);
            this.Controls.Add(this.TextBoxIPDX);
            this.Controls.Add(this.TextBoxIPLT);
            this.Controls.Add(this.LabelFtpDX);
            this.Controls.Add(this.LabelFtpLT);
            this.Controls.Add(this.CheckLable);
            this.Controls.Add(this.UpdataLable);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonDelCheck);
            this.Controls.Add(this.buttonAddCheck);
            this.Controls.Add(this.checkedListBoxFullCheck);
            this.Controls.Add(this.checkedListBoxFolder);
            this.Controls.Add(this.buttonXML);
            this.Controls.Add(this.buttonDelUpdata);
            this.Controls.Add(this.buttonAddUpdata);
            this.Controls.Add(this.treeViewALL);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 570);
            this.MinimumSize = new System.Drawing.Size(850, 570);
            this.Name = "MieMieXML";
            this.Text = "咩咩服更新设置 V0.0.5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Button buttonAddUpdata;
        private System.Windows.Forms.TreeView treeViewALL;
        private System.Windows.Forms.Button buttonDelUpdata;
        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.CheckedListBox checkedListBoxFolder;
        private System.Windows.Forms.CheckedListBox checkedListBoxFullCheck;
        private System.Windows.Forms.Button buttonDelCheck;
        private System.Windows.Forms.Button buttonAddCheck;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FolderMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAllFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCheckFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUpdataFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveCheckFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveUpdataFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成XML文件ToolStripMenuItem;
        private System.Windows.Forms.Label UpdataLable;
        private System.Windows.Forms.Label CheckLable;
        private System.Windows.Forms.ToolStripMenuItem 生成XML文件ToolStripMenuItem1;
        private System.Windows.Forms.Label LabelFtpLT;
        private System.Windows.Forms.Label LabelFtpDX;
        private System.Windows.Forms.TextBox TextBoxIPLT;
        private System.Windows.Forms.TextBox TextBoxIPDX;
        private System.Windows.Forms.Label LableID;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LablePassword;
        private System.Windows.Forms.Button ButtonGenerationSet;
        private System.Windows.Forms.ToolStripMenuItem 生成设置文件ToolStripMenuItem;

    }
}

