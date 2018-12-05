namespace Server
{
    partial class frmServer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelstatus = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPORT = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.txtboxStatus = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus.ForeColor = System.Drawing.Color.Firebrick;
            this.labelstatus.Location = new System.Drawing.Point(9, 33);
            this.labelstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(123, 17);
            this.labelstatus.TabIndex = 10;
            this.labelstatus.Text = "Status Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(9, 274);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(310, 51);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(338, 283);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(326, 93);
            this.lbIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(27, 17);
            this.lbIP.TabIndex = 10;
            this.lbIP.Text = "IP:";
            // 
            // lbPORT
            // 
            this.lbPORT.AutoSize = true;
            this.lbPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPORT.Location = new System.Drawing.Point(326, 162);
            this.lbPORT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPORT.Name = "lbPORT";
            this.lbPORT.Size = new System.Drawing.Size(56, 17);
            this.lbPORT.TabIndex = 10;
            this.lbPORT.Text = "PORT:";
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IP.Cursor = System.Windows.Forms.Cursors.Default;
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(338, 116);
            this.IP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IP.Multiline = true;
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Size = new System.Drawing.Size(76, 27);
            this.IP.TabIndex = 10;
            this.IP.Text = " 127.0.0.1";
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.port.Cursor = System.Windows.Forms.Cursors.Default;
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(338, 187);
            this.port.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.port.Multiline = true;
            this.port.Name = "port";
            this.port.ReadOnly = true;
            this.port.Size = new System.Drawing.Size(76, 27);
            this.port.TabIndex = 10;
            this.port.Text = "8910";
            this.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxStatus
            // 
            this.txtboxStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.txtboxStatus.Location = new System.Drawing.Point(9, 70);
            this.txtboxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxStatus.Multiline = true;
            this.txtboxStatus.Name = "txtboxStatus";
            this.txtboxStatus.ReadOnly = true;
            this.txtboxStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxStatus.Size = new System.Drawing.Size(310, 183);
            this.txtboxStatus.TabIndex = 10;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 341);
            this.Controls.Add(this.txtboxStatus);
            this.Controls.Add(this.port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.lbPORT);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServer_FormClosed);
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPORT;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox txtboxStatus;
    }
}

