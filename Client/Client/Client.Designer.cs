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
            this.labelUsers.Location = new System.Drawing.Point(12, 28);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(119, 20);
            this.labelUsers.TabIndex = 12;
            this.labelUsers.Text = "Users Online";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(16, 98);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.ScrollAlwaysVisible = true;
            this.listBoxUsers.Size = new System.Drawing.Size(165, 244);
            this.listBoxUsers.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(612, 386);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 42);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(201, 372);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(393, 69);
            this.txtMessage.TabIndex = 9;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(104, 28);
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
            this.lbName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.txtboxMsg.Location = new System.Drawing.Point(201, 90);
            this.txtboxMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxMsg.Multiline = true;
            this.txtboxMsg.Name = "txtboxMsg";
            this.txtboxMsg.ReadOnly = true;
            this.txtboxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxMsg.Size = new System.Drawing.Size(477, 264);
            this.txtboxMsg.TabIndex = 17;
            // 
            // btnPrivChat
            // 
            this.btnPrivChat.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPrivChat.AutoSize = true;
            this.btnPrivChat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrivChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrivChat.Location = new System.Drawing.Point(37, 374);
            this.btnPrivChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnPubChat.Location = new System.Drawing.Point(37, 415);
            this.btnPubChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPubChat.Name = "btnPubChat";
            this.btnPubChat.Size = new System.Drawing.Size(129, 27);
            this.btnPubChat.TabIndex = 4;
            this.btnPubChat.Text = "     Public Chat     ";
            this.btnPubChat.UseVisualStyleBackColor = true;
            this.btnPubChat.CheckedChanged += new System.EventHandler(this.btnPrivChat_CheckedChanged);
            this.btnPubChat.Click += new System.EventHandler(this.btnPubChat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
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
            this.cmbColor.Location = new System.Drawing.Point(257, 58);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(199, 24);
            this.cmbColor.TabIndex = 19;
            this.cmbColor.SelectedValueChanged += new System.EventHandler(this.cmbColor_SelectedValueChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 465);
            this.Controls.Add(this.btnPubChat);
            this.Controls.Add(this.btnPrivChat);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxMsg);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColor;
    }
}