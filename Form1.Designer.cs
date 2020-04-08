namespace Process_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCheck = new System.Windows.Forms.Button();
            this.GrpServerStatus = new System.Windows.Forms.GroupBox();
            this.RdbServerAus = new System.Windows.Forms.RadioButton();
            this.RdbServerAn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProcess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDatenbank = new System.Windows.Forms.TextBox();
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.BtnCreateString = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtColumn = new System.Windows.Forms.TextBox();
            this.TxtTable = new System.Windows.Forms.TextBox();
            this.GrpServerStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(275, 257);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(178, 23);
            this.BtnCheck.TabIndex = 0;
            this.BtnCheck.Text = "Check Server";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // GrpServerStatus
            // 
            this.GrpServerStatus.Controls.Add(this.RdbServerAus);
            this.GrpServerStatus.Controls.Add(this.RdbServerAn);
            this.GrpServerStatus.Location = new System.Drawing.Point(12, 24);
            this.GrpServerStatus.Name = "GrpServerStatus";
            this.GrpServerStatus.Size = new System.Drawing.Size(178, 100);
            this.GrpServerStatus.TabIndex = 1;
            this.GrpServerStatus.TabStop = false;
            this.GrpServerStatus.Text = "Server Status";
            // 
            // RdbServerAus
            // 
            this.RdbServerAus.AutoSize = true;
            this.RdbServerAus.Checked = true;
            this.RdbServerAus.Location = new System.Drawing.Point(7, 61);
            this.RdbServerAus.Name = "RdbServerAus";
            this.RdbServerAus.Size = new System.Drawing.Size(43, 17);
            this.RdbServerAus.TabIndex = 1;
            this.RdbServerAus.TabStop = true;
            this.RdbServerAus.Text = "Aus";
            this.RdbServerAus.UseVisualStyleBackColor = true;
            // 
            // RdbServerAn
            // 
            this.RdbServerAn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RdbServerAn.AutoSize = true;
            this.RdbServerAn.Location = new System.Drawing.Point(7, 37);
            this.RdbServerAn.Name = "RdbServerAn";
            this.RdbServerAn.Size = new System.Drawing.Size(38, 17);
            this.RdbServerAn.TabIndex = 0;
            this.RdbServerAn.Text = "An";
            this.RdbServerAn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtProcess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtDatenbank);
            this.groupBox1.Controls.Add(this.TxtPasswort);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.TxtHost);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Datenbank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Process:";
            // 
            // TxtProcess
            // 
            this.TxtProcess.Location = new System.Drawing.Point(72, 124);
            this.TxtProcess.Name = "TxtProcess";
            this.TxtProcess.Size = new System.Drawing.Size(100, 20);
            this.TxtProcess.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datenbank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passwort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // TxtDatenbank
            // 
            this.TxtDatenbank.Location = new System.Drawing.Point(72, 98);
            this.TxtDatenbank.Name = "TxtDatenbank";
            this.TxtDatenbank.Size = new System.Drawing.Size(100, 20);
            this.TxtDatenbank.TabIndex = 3;
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.Location = new System.Drawing.Point(72, 72);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.PasswordChar = '*';
            this.TxtPasswort.Size = new System.Drawing.Size(100, 20);
            this.TxtPasswort.TabIndex = 2;
            this.TxtPasswort.UseWaitCursor = true;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(72, 46);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 20);
            this.TxtUser.TabIndex = 1;
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(72, 20);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(100, 20);
            this.TxtHost.TabIndex = 0;
            // 
            // BtnCreateString
            // 
            this.BtnCreateString.Location = new System.Drawing.Point(275, 286);
            this.BtnCreateString.Name = "BtnCreateString";
            this.BtnCreateString.Size = new System.Drawing.Size(178, 23);
            this.BtnCreateString.TabIndex = 5;
            this.BtnCreateString.Text = "übernehmen";
            this.BtnCreateString.UseVisualStyleBackColor = true;
            this.BtnCreateString.Click += new System.EventHandler(this.BtnCreateString_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtColumn);
            this.groupBox2.Controls.Add(this.TxtTable);
            this.groupBox2.Location = new System.Drawing.Point(275, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datenbank Tabelle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "column:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tabelle:";
            // 
            // TxtColumn
            // 
            this.TxtColumn.Location = new System.Drawing.Point(72, 46);
            this.TxtColumn.Name = "TxtColumn";
            this.TxtColumn.Size = new System.Drawing.Size(100, 20);
            this.TxtColumn.TabIndex = 1;
            this.TxtColumn.Text = "serverOnline";
            // 
            // TxtTable
            // 
            this.TxtTable.Location = new System.Drawing.Point(72, 20);
            this.TxtTable.Name = "TxtTable";
            this.TxtTable.Size = new System.Drawing.Size(100, 20);
            this.TxtTable.TabIndex = 0;
            this.TxtTable.Text = "settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCreateString);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpServerStatus);
            this.Controls.Add(this.BtnCheck);
            this.Name = "Form1";
            this.Text = "Process Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpServerStatus.ResumeLayout(false);
            this.GrpServerStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.GroupBox GrpServerStatus;
        private System.Windows.Forms.RadioButton RdbServerAus;
        private System.Windows.Forms.RadioButton RdbServerAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDatenbank;
        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProcess;
        private System.Windows.Forms.Button BtnCreateString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtColumn;
        private System.Windows.Forms.TextBox TxtTable;
    }
}

