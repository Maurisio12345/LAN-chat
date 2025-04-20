namespace Chatti
{
    partial class Form1
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
            this.txtChatbox = new System.Windows.Forms.RichTextBox();
            this.BtnSendMsg = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chckAnonyymi = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SuspendLayout();
            // 
            // txtChatbox
            // 
            this.txtChatbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtChatbox.Location = new System.Drawing.Point(82, 43);
            this.txtChatbox.Name = "txtChatbox";
            this.txtChatbox.ReadOnly = true;
            this.txtChatbox.Size = new System.Drawing.Size(933, 474);
            this.txtChatbox.TabIndex = 0;
            this.txtChatbox.Text = "";
            // 
            // BtnSendMsg
            // 
            this.BtnSendMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendMsg.Location = new System.Drawing.Point(12, 542);
            this.BtnSendMsg.Name = "BtnSendMsg";
            this.BtnSendMsg.Size = new System.Drawing.Size(87, 49);
            this.BtnSendMsg.TabIndex = 1;
            this.BtnSendMsg.Text = "Send";
            this.BtnSendMsg.UseVisualStyleBackColor = false;
            this.BtnSendMsg.Click += new System.EventHandler(this.BtnSendMsg_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(907, 557);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Your Name";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMessage.Location = new System.Drawing.Point(114, 557);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(183, 20);
            this.txtMessage.TabIndex = 3;
            // 
            // chckAnonyymi
            // 
            this.chckAnonyymi.AutoSize = true;
            this.chckAnonyymi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chckAnonyymi.Location = new System.Drawing.Point(907, 583);
            this.chckAnonyymi.Name = "chckAnonyymi";
            this.chckAnonyymi.Size = new System.Drawing.Size(87, 17);
            this.chckAnonyymi.TabIndex = 4;
            this.chckAnonyymi.Text = "Anonyymi tila";
            this.chckAnonyymi.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(12, 597);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Location = new System.Drawing.Point(308, 604);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(87, 34);
            this.btnServer.TabIndex = 8;
            this.btnServer.Text = "Start Server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(215, 604);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 34);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect to server";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 646);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chckAnonyymi);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BtnSendMsg);
            this.Controls.Add(this.txtChatbox);
            this.Name = "Form1";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtChatbox;
        private System.Windows.Forms.Button BtnSendMsg;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chckAnonyymi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

