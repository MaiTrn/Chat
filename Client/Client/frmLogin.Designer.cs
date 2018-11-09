namespace Client
{
    partial class frmLogin
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
            this.Username = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(12, 24);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 18);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlogin.Location = new System.Drawing.Point(95, 23);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(152, 22);
            this.txtlogin.TabIndex = 1;
            // 
            // Enter
            // 
            this.Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Enter.Location = new System.Drawing.Point(42, 63);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exit.Location = new System.Drawing.Point(139, 63);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 108);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.TextBox txtlogin;
    }
}