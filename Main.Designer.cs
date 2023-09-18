namespace TinyMCSV
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            selectInstanceToolStripMenuItem = new ToolStripMenuItem();
            selectInstanceToolStripMenuItem1 = new ToolStripMenuItem();
            loadInstanceToolStripMenuItem = new ToolStripMenuItem();
            createANewInstanceToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(701, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "TinyMCSV";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectInstanceToolStripMenuItem, toolStripSeparator1, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // selectInstanceToolStripMenuItem
            // 
            selectInstanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectInstanceToolStripMenuItem1, loadInstanceToolStripMenuItem, createANewInstanceToolStripMenuItem });
            selectInstanceToolStripMenuItem.Name = "selectInstanceToolStripMenuItem";
            selectInstanceToolStripMenuItem.Size = new Size(118, 22);
            selectInstanceToolStripMenuItem.Text = "Instance";
            // 
            // selectInstanceToolStripMenuItem1
            // 
            selectInstanceToolStripMenuItem1.Name = "selectInstanceToolStripMenuItem1";
            selectInstanceToolStripMenuItem1.Size = new Size(189, 22);
            selectInstanceToolStripMenuItem1.Text = "Select instance";
            selectInstanceToolStripMenuItem1.Click += selectInstanceToolStripMenuItem1_Click;
            // 
            // loadInstanceToolStripMenuItem
            // 
            loadInstanceToolStripMenuItem.Name = "loadInstanceToolStripMenuItem";
            loadInstanceToolStripMenuItem.Size = new Size(189, 22);
            loadInstanceToolStripMenuItem.Text = "Load instance";
            // 
            // createANewInstanceToolStripMenuItem
            // 
            createANewInstanceToolStripMenuItem.Name = "createANewInstanceToolStripMenuItem";
            createANewInstanceToolStripMenuItem.Size = new Size(189, 22);
            createANewInstanceToolStripMenuItem.Text = "Create a new instance";
            createANewInstanceToolStripMenuItem.Click += createANewInstanceToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(115, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(118, 22);
            quitToolStripMenuItem.Text = "Exit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(52, 20);
            helpToolStripMenuItem.Text = "About";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 420);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(701, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(263, 17);
            toolStripStatusLabel1.Text = "No instance loadded, go to File > Select instance";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(4, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(697, 390);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(689, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(689, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configuration";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(689, 362);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Plugins";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(689, 362);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Terminal";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(689, 362);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Player";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(701, 442);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(717, 481);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyMCSV";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem selectInstanceToolStripMenuItem;
        private ToolStripMenuItem selectInstanceToolStripMenuItem1;
        private ToolStripMenuItem loadInstanceToolStripMenuItem;
        private ToolStripMenuItem createANewInstanceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}