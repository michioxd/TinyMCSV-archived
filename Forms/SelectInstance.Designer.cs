namespace TinyMCSV
{
    partial class SelectInstance
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
            label1 = new Label();
            listBox1 = new ListBox();
            Main_Quit = new Button();
            Main_Begin = new Button();
            Main_Create = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 1;
            label1.Text = "Please select a instance to continue";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(419, 259);
            listBox1.TabIndex = 2;
            // 
            // Main_Quit
            // 
            Main_Quit.Location = new Point(356, 310);
            Main_Quit.Name = "Main_Quit";
            Main_Quit.Size = new Size(75, 23);
            Main_Quit.TabIndex = 3;
            Main_Quit.Text = "Quit";
            Main_Quit.UseVisualStyleBackColor = true;
            // 
            // Main_Begin
            // 
            Main_Begin.Location = new Point(275, 310);
            Main_Begin.Name = "Main_Begin";
            Main_Begin.Size = new Size(75, 23);
            Main_Begin.TabIndex = 4;
            Main_Begin.Text = "Begin";
            Main_Begin.UseVisualStyleBackColor = true;
            // 
            // Main_Create
            // 
            Main_Create.Location = new Point(12, 310);
            Main_Create.Name = "Main_Create";
            Main_Create.Size = new Size(141, 23);
            Main_Create.TabIndex = 5;
            Main_Create.Text = "Create a new instance";
            Main_Create.UseVisualStyleBackColor = true;
            Main_Create.Click += Main_Create_Click;
            // 
            // SelectInstance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(443, 345);
            Controls.Add(Main_Create);
            Controls.Add(Main_Begin);
            Controls.Add(Main_Quit);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SelectInstance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select instance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button Main_Quit;
        private Button Main_Begin;
        private Button Main_Create;
    }
}