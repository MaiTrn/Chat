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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbName = new System.Windows.Forms.Label();
            this.txtboxMsg = new System.Windows.Forms.TextBox();
            this.btnPrivChat = new System.Windows.Forms.CheckBox();
            this.btnPubChat = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.Firebrick;
            this.labelUsers.Location = new System.Drawing.Point(12, 28);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(119, 20);
            this.labelUsers.TabIndex = 0;
            this.labelUsers.Text = "Users Online";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(16, 67);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.ScrollAlwaysVisible = true;
            this.listBoxUsers.Size = new System.Drawing.Size(165, 244);
            this.listBoxUsers.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(551, 364);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 42);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(201, 347);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(325, 72);
            this.txtMessage.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Firebrick;
            this.lbName.Location = new System.Drawing.Point(184, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(106, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Username: ";
            // 
            // txtboxMsg
            // 
            this.txtboxMsg.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxMsg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtboxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMsg.Location = new System.Drawing.Point(201, 67);
            this.txtboxMsg.Multiline = true;
            this.txtboxMsg.Name = "txtboxMsg";
            this.txtboxMsg.ReadOnly = true;
            this.txtboxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxMsg.Size = new System.Drawing.Size(428, 244);
            this.txtboxMsg.TabIndex = 0;
            // 
            // btnPrivChat
            // 
            this.btnPrivChat.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPrivChat.AutoSize = true;
            this.btnPrivChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrivChat.Location = new System.Drawing.Point(33, 347);
            this.btnPrivChat.Name = "btnPrivChat";
            this.btnPrivChat.Size = new System.Drawing.Size(127, 27);
            this.btnPrivChat.TabIndex = 3;
            this.btnPrivChat.Text = "    Private Chat    ";
            this.btnPrivChat.UseVisualStyleBackColor = true;
            this.btnPrivChat.CheckedChanged += new System.EventHandler(this.btnPrivChat_CheckedChanged);
            this.btnPrivChat.Click += new System.EventHandler(this.btnPrivChat_Click);
            // 
            // btnPubChat
            // 
            this.btnPubChat.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPubChat.AutoSize = true;
            this.btnPubChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPubChat.Location = new System.Drawing.Point(33, 392);
            this.btnPubChat.Name = "btnPubChat";
            this.btnPubChat.Size = new System.Drawing.Size(129, 27);
            this.btnPubChat.TabIndex = 4;
            this.btnPubChat.Text = "     Public Chat     ";
            this.btnPubChat.UseVisualStyleBackColor = true;
            this.btnPubChat.CheckedChanged += new System.EventHandler(this.btnPubChat_CheckedChanged);
            this.btnPubChat.Click += new System.EventHandler(this.btnPubChat_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 442);
            this.Controls.Add(this.btnPubChat);
            this.Controls.Add(this.btnPrivChat);
            this.Controls.Add(this.txtboxMsg);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtboxMsg;
        private System.Windows.Forms.CheckBox btnPrivChat;
        private System.Windows.Forms.CheckBox btnPubChat;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}