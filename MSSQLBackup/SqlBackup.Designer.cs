namespace MSSQLBackup
{
    partial class SqlBackup
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
            SQLtxtBox = new TextBox();
            label1 = new Label();
            lbl2 = new Label();
            DatabaseDropdown = new ComboBox();
            ConnectBtn = new Button();
            BackUpBtn = new Button();
            BackupLocationTextBox = new TextBox();
            LocationBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // SQLtxtBox
            // 
            SQLtxtBox.Location = new Point(107, 59);
            SQLtxtBox.Name = "SQLtxtBox";
            SQLtxtBox.Size = new Size(157, 23);
            SQLtxtBox.TabIndex = 0;
            SQLtxtBox.TextChanged += SQLtxtBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 37);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "MS SQL Dataabse Server";
            label1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(105, 199);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(98, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Select a Database";
            // 
            // DatabaseDropdown
            // 
            DatabaseDropdown.FormattingEnabled = true;
            DatabaseDropdown.Location = new Point(105, 217);
            DatabaseDropdown.Name = "DatabaseDropdown";
            DatabaseDropdown.Size = new Size(159, 23);
            DatabaseDropdown.TabIndex = 3;
            DatabaseDropdown.SelectedIndexChanged += DatabaseDropdown_SelectedIndexChanged;
            // 
            // ConnectBtn
            // 
            ConnectBtn.Location = new Point(325, 59);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(157, 30);
            ConnectBtn.TabIndex = 4;
            ConnectBtn.Text = "Connect";
            ConnectBtn.UseVisualStyleBackColor = true;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // BackUpBtn
            // 
            BackUpBtn.Location = new Point(224, 356);
            BackUpBtn.Name = "BackUpBtn";
            BackUpBtn.Size = new Size(154, 41);
            BackUpBtn.TabIndex = 5;
            BackUpBtn.Text = "Back Up";
            BackUpBtn.UseVisualStyleBackColor = true;
            BackUpBtn.Click += BackUpBtn_Click;
            // 
            // BackupLocationTextBox
            // 
            BackupLocationTextBox.Location = new Point(105, 311);
            BackupLocationTextBox.Name = "BackupLocationTextBox";
            BackupLocationTextBox.ReadOnly = true;
            BackupLocationTextBox.Size = new Size(439, 23);
            BackupLocationTextBox.TabIndex = 6;
            BackupLocationTextBox.TextChanged += BackupLocationTextBox_TextChanged;
            // 
            // LocationBtn
            // 
            LocationBtn.Location = new Point(330, 217);
            LocationBtn.Name = "LocationBtn";
            LocationBtn.Size = new Size(162, 28);
            LocationBtn.TabIndex = 7;
            LocationBtn.Text = "Select a Location";
            LocationBtn.UseVisualStyleBackColor = true;
            LocationBtn.Click += LocationBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 293);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 8;
            label2.Text = "BackUp Location";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(LocationBtn);
            Controls.Add(BackupLocationTextBox);
            Controls.Add(BackUpBtn);
            Controls.Add(ConnectBtn);
            Controls.Add(DatabaseDropdown);
            Controls.Add(lbl2);
            Controls.Add(label1);
            Controls.Add(SQLtxtBox);
            Name = "SqlBackUpProgram";
            Text = "SqlBackUpProgram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SQLtxtBox;
        private Label label1;
        private Label lbl2;
        private ComboBox DatabaseDropdown;
        private Button ConnectBtn;
        private Button BackUpBtn;
        private TextBox BackupLocationTextBox;
        private Button LocationBtn;
        private Label label2;
    }
}