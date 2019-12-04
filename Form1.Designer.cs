namespace DicomBrowser
{
    partial class Browser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.GetPatientBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PatientIdList = new System.Windows.Forms.ListView();
            this.FilesList = new System.Windows.Forms.ListView();
            this.IP_text = new System.Windows.Forms.TextBox();
            this.PORT_text = new System.Windows.Forms.TextBox();
            this.AET_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PORTCLIENT_txt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.AETSERWERA_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AET:";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(12, 293);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 13);
            this.StatusText.TabIndex = 3;
            this.StatusText.UseWaitCursor = true;
            this.StatusText.Visible = false;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(15, 324);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(137, 23);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "POŁĄCZ";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // GetPatientBtn
            // 
            this.GetPatientBtn.Location = new System.Drawing.Point(15, 353);
            this.GetPatientBtn.Name = "GetPatientBtn";
            this.GetPatientBtn.Size = new System.Drawing.Size(137, 23);
            this.GetPatientBtn.TabIndex = 5;
            this.GetPatientBtn.Text = "ODŚWIEŻ";
            this.GetPatientBtn.UseVisualStyleBackColor = true;
            this.GetPatientBtn.Click += new System.EventHandler(this.GetPatientBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "LISTA PACJENTÓW:";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(490, 35);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(282, 374);
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            // 
            // PatientIdList
            // 
            this.PatientIdList.GridLines = true;
            this.PatientIdList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PatientIdList.HideSelection = false;
            this.PatientIdList.Location = new System.Drawing.Point(203, 35);
            this.PatientIdList.Margin = new System.Windows.Forms.Padding(1);
            this.PatientIdList.MaximumSize = new System.Drawing.Size(250, 160);
            this.PatientIdList.MinimumSize = new System.Drawing.Size(250, 160);
            this.PatientIdList.MultiSelect = false;
            this.PatientIdList.Name = "PatientIdList";
            this.PatientIdList.ShowGroups = false;
            this.PatientIdList.Size = new System.Drawing.Size(250, 160);
            this.PatientIdList.TabIndex = 10;
            this.PatientIdList.UseCompatibleStateImageBehavior = false;
            this.PatientIdList.View = System.Windows.Forms.View.List;
            this.PatientIdList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PatientIdList_ItemSelectionChanged);
            // 
            // FilesList
            // 
            this.FilesList.Location = new System.Drawing.Point(203, 238);
            this.FilesList.Margin = new System.Windows.Forms.Padding(1);
            this.FilesList.MaximumSize = new System.Drawing.Size(250, 171);
            this.FilesList.MinimumSize = new System.Drawing.Size(250, 171);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(250, 171);
            this.FilesList.TabIndex = 11;
            this.FilesList.UseCompatibleStateImageBehavior = false;
            this.FilesList.View = System.Windows.Forms.View.List;
            this.FilesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FilesList_ItemSelectionChanged);
            // 
            // IP_text
            // 
            this.IP_text.Location = new System.Drawing.Point(12, 29);
            this.IP_text.Name = "IP_text";
            this.IP_text.Size = new System.Drawing.Size(100, 20);
            this.IP_text.TabIndex = 13;
            this.IP_text.Text = "127.0.0.1";
            // 
            // PORT_text
            // 
            this.PORT_text.Location = new System.Drawing.Point(12, 81);
            this.PORT_text.Name = "PORT_text";
            this.PORT_text.Size = new System.Drawing.Size(100, 20);
            this.PORT_text.TabIndex = 14;
            this.PORT_text.Text = "10100";
            // 
            // AET_text
            // 
            this.AET_text.Location = new System.Drawing.Point(12, 175);
            this.AET_text.Name = "AET_text";
            this.AET_text.Size = new System.Drawing.Size(100, 20);
            this.AET_text.TabIndex = 15;
            this.AET_text.Text = "KLIENTL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "STATUS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "LISTA BADAŃ PACJENTA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "PODGLĄD OBRAZU:";
            // 
            // PORTCLIENT_txt
            // 
            this.PORTCLIENT_txt.Location = new System.Drawing.Point(12, 227);
            this.PORTCLIENT_txt.Name = "PORTCLIENT_txt";
            this.PORTCLIENT_txt.Size = new System.Drawing.Size(100, 20);
            this.PORTCLIENT_txt.TabIndex = 20;
            this.PORTCLIENT_txt.Text = "10104 ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 207);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 13);
            this.label.TabIndex = 19;
            this.label.Text = "PORT KLIENTA:";
            // 
            // AETSERWERA_txt
            // 
            this.AETSERWERA_txt.Location = new System.Drawing.Point(12, 127);
            this.AETSERWERA_txt.Name = "AETSERWERA_txt";
            this.AETSERWERA_txt.Size = new System.Drawing.Size(100, 20);
            this.AETSERWERA_txt.TabIndex = 22;
            this.AETSERWERA_txt.Text = "ARCHIWUM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "AET SERWERA:";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AETSERWERA_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PORTCLIENT_txt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AET_text);
            this.Controls.Add(this.PORT_text);
            this.Controls.Add(this.IP_text);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.PatientIdList);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GetPatientBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Browser";
            this.Text = "DICOM Browser";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button GetPatientBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListView PatientIdList;
        private System.Windows.Forms.ListView FilesList;
        private System.Windows.Forms.TextBox IP_text;
        private System.Windows.Forms.TextBox PORT_text;
        private System.Windows.Forms.TextBox AET_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PORTCLIENT_txt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox AETSERWERA_txt;
        private System.Windows.Forms.Label label9;
    }
}

