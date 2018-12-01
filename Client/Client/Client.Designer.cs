namespace Client
{
    partial class Client
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
            this.labelUsers = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPrivChat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnonlineusers = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtboxMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.Firebrick;
            this.labelUsers.Location = new System.Drawing.Point(9, 23);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(102, 17);
            this.labelUsers.TabIndex = 12;
            this.labelUsers.Text = "Users Online";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 17;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 73);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.ScrollAlwaysVisible = true;
            this.listBoxUsers.Size = new System.Drawing.Size(125, 208);
            this.listBoxUsers.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(459, 306);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(58, 34);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(151, 290);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(296, 61);
            this.txtMessage.TabIndex = 9;
            // 
            // btnPrivChat
            // 
            this.btnPrivChat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrivChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrivChat.Location = new System.Drawing.Point(22, 329);
            this.btnPrivChat.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrivChat.Name = "btnPrivChat";
            this.btnPrivChat.Size = new System.Drawing.Size(101, 24);
            this.btnPrivChat.TabIndex = 13;
            this.btnPrivChat.Text = "Private Chat";
            this.btnPrivChat.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(87, 24);
            this.menuStrip1.TabIndex = 14;
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
            // btnonlineusers
            // 
            this.btnonlineusers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnonlineusers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnonlineusers.Location = new System.Drawing.Point(22, 294);
            this.btnonlineusers.Margin = new System.Windows.Forms.Padding(2);
            this.btnonlineusers.Name = "btnonlineusers";
            this.btnonlineusers.Size = new System.Drawing.Size(101, 23);
            this.btnonlineusers.TabIndex = 15;
            this.btnonlineusers.Text = "Update List";
            this.btnonlineusers.UseVisualStyleBackColor = false;
            this.btnonlineusers.Click += new System.EventHandler(this.btnonlineusers_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Firebrick;
            this.lbName.Location = new System.Drawing.Point(138, 23);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 17);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Username: ";
            // 
            // txtboxMsg
            // 
            this.txtboxMsg.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMsg.Location = new System.Drawing.Point(151, 73);
            this.txtboxMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxMsg.Multiline = true;
            this.txtboxMsg.Name = "txtboxMsg";
            this.txtboxMsg.ReadOnly = true;
            this.txtboxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxMsg.Size = new System.Drawing.Size(359, 215);
            this.txtboxMsg.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change color background:";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Default",
            "Pink",
            "Blue",
            "Black",
            "Red",
            "White",
            "Green",
            "Yellow"});
            this.cmbColor.Location = new System.Drawing.Point(193, 47);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(150, 21);
            this.cmbColor.TabIndex = 19;
            this.cmbColor.SelectedValueChanged += new System.EventHandler(this.cmbColor_SelectedValueChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 364);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxMsg);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnonlineusers);
            this.Controls.Add(this.btnPrivChat);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServer_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnPrivChat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnonlineusers;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtboxMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColor;
    }
}