namespace TinyMCSV.Forms
{
    partial class CreateNewInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewInstance));
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBox1 = new CheckBox();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            CancelBtn = new Button();
            CreateBtn = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 54);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destination folder";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(384, 22);
            button1.Name = "button1";
            button1.Size = new Size(32, 23);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 23);
            textBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(422, 394);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(comboBox4);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(414, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "System";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(232, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Use portable Java Runtime";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "JRE 17 (Eclipse Temurin™)", "JRE 17 (Microsoft)", "JRE 17 (OpenJDK)", "JRE 17 (Liberica)", "JRE 17 (Amazon Corretto)", "JRE 17 (Azul Zulu)", "JRE 17 (Red Hat)", "JRE 17 (SapMachine)", "JRE 17 (GraalVM)", "JRE 17 (IBM Semeru Runtime Open Edition)" });
            comboBox4.Location = new Point(126, 69);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(271, 23);
            comboBox4.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { " 1.20.1", " 1.20", " 1.19.4", " 1.19.3", " 1.19.2", " 1.19.1", " 1.19", " 1.18.2", " 1.18.1", " 1.18", " 1.17.1", " 1.17", " 1.16.5", " 1.16.4", " 1.16.3", " 1.16.2", " 1.16.1", " 1.16", " 1.15.2", " 1.15.1", " 1.15", " 1.14.4", " 1.14.3", " 1.14.2", " 1.14.1", " 1.14", " 1.13.2", " 1.13.1", " 1.13", " 1.12.2", " 1.12.1", " 1.12", " 1.11.2", " 1.11.1", " 1.11", " 1.10.2", " 1.10.1", " 1.10", " 1.9.4", " 1.9.3", " 1.9.2", " 1.9.1", " 1.9", " 1.8.9", " 1.8.8", " 1.8.7", " 1.8.6", " 1.8.5", " 1.8.4", " 1.8.3", " 1.8", " 1.7.10", " 1.7.9", " 1.7.8", " 1.7.6", " 1.7.5", " 1.7.4", " 1.7.2", " 1.6.4", " 1.6.2", " 1.6.1", " 1.5.2", " 1.5.1", " 1.5.0", " 1.4.7", " 1.4.6", " 1.4.5", " 1.4.4", " 1.4.3", " 1.4.2", " 1.4.1", " 1.4.0", " 1.3.2", " 1.3.1", " 1.3.0", " 1.2.5", " 1.2.0", " 1.1.0" });
            comboBox2.Location = new Point(126, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(271, 23);
            comboBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 0;
            label4.Text = "Java Runtime";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vanilla", "Spigot", "PaperMC" });
            comboBox1.Location = new Point(126, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Version";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Software";
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(414, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Basic properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(353, 476);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += button2_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(272, 476);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(75, 23);
            CreateBtn.TabIndex = 2;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += button2_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CreateNewInstance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(446, 511);
            Controls.Add(CreateBtn);
            Controls.Add(CancelBtn);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateNewInstance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a new instance";
            Load += CreateNewInstance_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button CancelBtn;
        private Button CreateBtn;
        private ComboBox comboBox1;
        private Label label1;
        private PrintPreviewDialog printPreviewDialog1;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox4;
        private Label label4;
    }
}