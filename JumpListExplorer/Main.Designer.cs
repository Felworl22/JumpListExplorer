namespace JumpListExplorer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutWindowsJumpListExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listViewMain = new System.Windows.Forms.ListView();
            columnHeaderAumid = new System.Windows.Forms.ColumnHeader();
            columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            columnHeaderName = new System.Windows.Forms.ColumnHeader();
            columnHeaderPath = new System.Windows.Forms.ColumnHeader();
            contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(components);
            removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            openLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            removeAllDeletedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            imageListIcons = new System.Windows.Forms.ImageList(components);
            menuStripMain.SuspendLayout();
            contextMenuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new System.Drawing.Size(1226, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4;
            exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { refreshToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            refreshToolStripMenuItem.Text = "&Refresh";
            refreshToolStripMenuItem.Click += RefreshToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutWindowsJumpListExplorerToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutWindowsJumpListExplorerToolStripMenuItem
            // 
            aboutWindowsJumpListExplorerToolStripMenuItem.Name = "aboutWindowsJumpListExplorerToolStripMenuItem";
            aboutWindowsJumpListExplorerToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            aboutWindowsJumpListExplorerToolStripMenuItem.Text = "&About Windows Jump List Explorer";
            aboutWindowsJumpListExplorerToolStripMenuItem.Click += AboutWindowsJumpListExplorerToolStripMenuItem_Click;
            // 
            // listViewMain
            // 
            listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderAumid, columnHeaderDate, columnHeaderName, columnHeaderPath });
            listViewMain.ContextMenuStrip = contextMenuStripMain;
            listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewMain.FullRowSelect = true;
            listViewMain.Location = new System.Drawing.Point(0, 24);
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new System.Drawing.Size(1226, 594);
            listViewMain.SmallImageList = imageListIcons;
            listViewMain.TabIndex = 1;
            listViewMain.UseCompatibleStateImageBehavior = false;
            listViewMain.View = System.Windows.Forms.View.Details;
            listViewMain.DoubleClick += ListViewMain_DoubleClick;
            // 
            // columnHeaderAumid
            // 
            columnHeaderAumid.Text = "Application User Model ID";
            columnHeaderAumid.Width = 200;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Last Accessed Date";
            columnHeaderDate.Width = 140;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 150;
            // 
            // columnHeaderPath
            // 
            columnHeaderPath.Text = "Path";
            columnHeaderPath.Width = 300;
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { removeToolStripMenuItem, toolStripSeparator1, openLocationToolStripMenuItem, runFileToolStripMenuItem, toolStripSeparator2, removeAllDeletedFilesToolStripMenuItem });
            contextMenuStripMain.Name = "contextMenuStripMain";
            contextMenuStripMain.Size = new System.Drawing.Size(269, 104);
            contextMenuStripMain.Opening += ContextMenuStripMain_Opening;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += RemoveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // openLocationToolStripMenuItem
            // 
            openLocationToolStripMenuItem.Name = "openLocationToolStripMenuItem";
            openLocationToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            openLocationToolStripMenuItem.Text = "Open location";
            openLocationToolStripMenuItem.Click += OpenLocationToolStripMenuItem_Click;
            // 
            // runFileToolStripMenuItem
            // 
            runFileToolStripMenuItem.Name = "runFileToolStripMenuItem";
            runFileToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            runFileToolStripMenuItem.Text = "Run file";
            runFileToolStripMenuItem.Click += RunFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            // 
            // removeAllDeletedFilesToolStripMenuItem
            // 
            removeAllDeletedFilesToolStripMenuItem.Name = "removeAllDeletedFilesToolStripMenuItem";
            removeAllDeletedFilesToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            removeAllDeletedFilesToolStripMenuItem.Text = "Remove shortcuts for all deleted files";
            removeAllDeletedFilesToolStripMenuItem.Click += RemoveAllDeletedFilesToolStripMenuItem_Click;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageListIcons.ImageSize = new System.Drawing.Size(16, 16);
            imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1226, 618);
            Controls.Add(listViewMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Windows Jump List Explorer";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            contextMenuStripMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWindowsJumpListExplorerToolStripMenuItem;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderAumid;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ToolStripMenuItem openLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem runFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllDeletedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
    }
}
