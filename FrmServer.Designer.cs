
namespace SerSig
{
    partial class FrmServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSessionTemp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtSessionDisconect = new System.Windows.Forms.TextBox();
            this.txtSessionDisconnect = new System.Windows.Forms.TextBox();
            this.tmrClient = new System.Windows.Forms.Timer(this.components);
            this.tbSignal = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtSignal = new System.Windows.Forms.TextBox();
            this.txtCountClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAlert = new System.Windows.Forms.ListBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.tmrAlert = new System.Windows.Forms.Timer(this.components);
            this.lvClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtSessionConnect = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 402);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(408, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSessionTemp
            // 
            this.txtSessionTemp.Location = new System.Drawing.Point(70, 194);
            this.txtSessionTemp.Name = "txtSessionTemp";
            this.txtSessionTemp.Size = new System.Drawing.Size(358, 20);
            this.txtSessionTemp.TabIndex = 2;
            this.txtSessionTemp.Text = "127.0.0.1";
            this.txtSessionTemp.Visible = false;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(224, 38);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "54000";
            this.txtPort.Visible = false;
            // 
            // txtSessionDisconect
            // 
            this.txtSessionDisconect.Location = new System.Drawing.Point(130, 246);
            this.txtSessionDisconect.Name = "txtSessionDisconect";
            this.txtSessionDisconect.Size = new System.Drawing.Size(298, 20);
            this.txtSessionDisconect.TabIndex = 4;
            this.txtSessionDisconect.Visible = false;
            // 
            // txtSessionDisconnect
            // 
            this.txtSessionDisconnect.Location = new System.Drawing.Point(96, 312);
            this.txtSessionDisconnect.Name = "txtSessionDisconnect";
            this.txtSessionDisconnect.Size = new System.Drawing.Size(332, 20);
            this.txtSessionDisconnect.TabIndex = 5;
            this.txtSessionDisconnect.Visible = false;
            // 
            // tmrClient
            // 
            this.tmrClient.Interval = 1000;
            this.tmrClient.Tick += new System.EventHandler(this.tmrClient_Tick);
            // 
            // tbSignal
            // 
            this.tbSignal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSignal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSignal.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSignal.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbSignal.Location = new System.Drawing.Point(10, 112);
            this.tbSignal.Name = "tbSignal";
            this.tbSignal.Size = new System.Drawing.Size(408, 34);
            this.tbSignal.TabIndex = 87;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(158, 220);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(270, 20);
            this.txtTemp.TabIndex = 269;
            this.txtTemp.Visible = false;
            // 
            // txtSignal
            // 
            this.txtSignal.Location = new System.Drawing.Point(16, 185);
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.Size = new System.Drawing.Size(270, 20);
            this.txtSignal.TabIndex = 270;
            this.txtSignal.Visible = false;
            // 
            // txtCountClient
            // 
            this.txtCountClient.BackColor = System.Drawing.Color.MediumBlue;
            this.txtCountClient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCountClient.Location = new System.Drawing.Point(265, 376);
            this.txtCountClient.Name = "txtCountClient";
            this.txtCountClient.Size = new System.Drawing.Size(153, 21);
            this.txtCountClient.TabIndex = 271;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(6, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 272;
            this.label2.Text = "Всего подключено:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 273;
            this.label4.Text = "Статус сервера:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtServerStatus
            // 
            this.txtServerStatus.BackColor = System.Drawing.Color.MediumBlue;
            this.txtServerStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServerStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtServerStatus.Location = new System.Drawing.Point(260, 85);
            this.txtServerStatus.Name = "txtServerStatus";
            this.txtServerStatus.Size = new System.Drawing.Size(153, 21);
            this.txtServerStatus.TabIndex = 274;
            this.txtServerStatus.Text = "Отключен";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 275;
            this.label1.Text = "Подключено клиентов";
            this.label1.Visible = false;
            // 
            // lbAlert
            // 
            this.lbAlert.FormattingEnabled = true;
            this.lbAlert.Location = new System.Drawing.Point(16, 9);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(158, 43);
            this.lbAlert.TabIndex = 276;
            this.lbAlert.Visible = false;
            // 
            // lblSignal
            // 
            this.lblSignal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignal.AutoSize = true;
            this.lblSignal.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignal.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSignal.Location = new System.Drawing.Point(116, 48);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(238, 26);
            this.lblSignal.TabIndex = 277;
            this.lblSignal.Text = "Ждем запуска БОТА";
            this.lblSignal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvClients.FullRowSelect = true;
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(10, 154);
            this.lvClients.MultiSelect = false;
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(408, 216);
            this.lvClients.TabIndex = 278;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Session";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP Адрес";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Страна";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Город";
            this.columnHeader4.Width = 135;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(141, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 26);
            this.label3.TabIndex = 320;
            this.label3.Text = "MabiyN SBS v 03-2021";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSessionConnect
            // 
            this.txtSessionConnect.Location = new System.Drawing.Point(96, 272);
            this.txtSessionConnect.Name = "txtSessionConnect";
            this.txtSessionConnect.Size = new System.Drawing.Size(332, 20);
            this.txtSessionConnect.TabIndex = 322;
            this.txtSessionConnect.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClient.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblClient.Location = new System.Drawing.Point(91, 335);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(238, 26);
            this.lblClient.TabIndex = 323;
            this.lblClient.Text = "Ждем запуска БОТА";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClient.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.TabIndex = 324;
            this.pictureBox1.TabStop = false;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtSessionConnect);
            this.Controls.Add(this.txtSessionDisconnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtSessionTemp);
            this.Controls.Add(this.txtSessionDisconect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvClients);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.lbAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountClient);
            this.Controls.Add(this.txtSignal);
            this.Controls.Add(this.tbSignal);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.Shown += new System.EventHandler(this.FrmServer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSessionTemp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtSessionDisconect;
        private System.Windows.Forms.TextBox txtSessionDisconnect;
        private System.Windows.Forms.Timer tmrClient;
        public System.Windows.Forms.TextBox tbSignal;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtSignal;
        private System.Windows.Forms.TextBox txtCountClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAlert;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Timer tmrAlert;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.TextBox txtSessionConnect;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}