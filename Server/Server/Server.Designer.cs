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
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelstatus = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Location = new System.Drawing.Point(12, 88);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(412, 228);
            this.listBoxStatus.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus.ForeColor = System.Drawing.Color.Firebrick;
            this.labelstatus.Location = new System.Drawing.Point(12, 41);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(144, 20);
            this.labelstatus.TabIndex = 2;
            this.labelstatus.Text = "Status Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 357);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(481, 42);
            this.txtMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(512, 357);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 42);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(457, 88);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(148, 228);
            this.listBoxUsers.TabIndex = 5;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.Firebrick;
            this.labelUsers.Location = new System.Drawing.Point(453, 50);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(119, 20);
            this.labelUsers.TabIndex = 6;
            this.labelUsers.Text = "Users Online";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 420);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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

        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelUsers;
    }
}

