namespace RPM
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
            this.components = new System.ComponentModel.Container();
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateFreqBtn = new System.Windows.Forms.Button();
            this.UpdateFreqTB = new System.Windows.Forms.TextBox();
            this.LastUpdate = new System.Windows.Forms.Label();
            this.UpdateInfo = new System.Windows.Forms.Button();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.RemoveServer = new System.Windows.Forms.Button();
            this.AddServer = new System.Windows.Forms.Button();
            this.PingTimer = new System.Windows.Forms.Timer(this.components);
            this.Serverlist = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PingBGWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServersListBox
            // 
            this.ServersListBox.FormattingEnabled = true;
            this.ServersListBox.Location = new System.Drawing.Point(6, 19);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.Size = new System.Drawing.Size(340, 225);
            this.ServersListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateFreqBtn);
            this.groupBox1.Controls.Add(this.UpdateFreqTB);
            this.groupBox1.Controls.Add(this.LastUpdate);
            this.groupBox1.Controls.Add(this.UpdateInfo);
            this.groupBox1.Controls.Add(this.ServersListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heartbeat";
            // 
            // UpdateFreqBtn
            // 
            this.UpdateFreqBtn.Location = new System.Drawing.Point(6, 268);
            this.UpdateFreqBtn.Name = "UpdateFreqBtn";
            this.UpdateFreqBtn.Size = new System.Drawing.Size(126, 23);
            this.UpdateFreqBtn.TabIndex = 4;
            this.UpdateFreqBtn.Text = "Update Freq (Mins)";
            this.UpdateFreqBtn.UseVisualStyleBackColor = true;
            this.UpdateFreqBtn.Click += new System.EventHandler(this.UpdateFreqBtn_Click);
            // 
            // UpdateFreqTB
            // 
            this.UpdateFreqTB.Location = new System.Drawing.Point(138, 270);
            this.UpdateFreqTB.Name = "UpdateFreqTB";
            this.UpdateFreqTB.Size = new System.Drawing.Size(91, 20);
            this.UpdateFreqTB.TabIndex = 3;
            // 
            // LastUpdate
            // 
            this.LastUpdate.AutoSize = true;
            this.LastUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastUpdate.Location = new System.Drawing.Point(103, 250);
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Size = new System.Drawing.Size(2, 15);
            this.LastUpdate.TabIndex = 2;
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.Location = new System.Drawing.Point(6, 245);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(91, 23);
            this.UpdateInfo.TabIndex = 1;
            this.UpdateInfo.Text = "Update";
            this.UpdateInfo.UseVisualStyleBackColor = true;
            this.UpdateInfo.Click += new System.EventHandler(this.UpdateInfo_Click);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(6, 172);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerTextBox.TabIndex = 4;
            // 
            // RemoveServer
            // 
            this.RemoveServer.Location = new System.Drawing.Point(6, 228);
            this.RemoveServer.Name = "RemoveServer";
            this.RemoveServer.Size = new System.Drawing.Size(100, 23);
            this.RemoveServer.TabIndex = 3;
            this.RemoveServer.Text = "Remove Server";
            this.RemoveServer.UseVisualStyleBackColor = true;
            this.RemoveServer.Click += new System.EventHandler(this.RemoveServer_Click);
            // 
            // AddServer
            // 
            this.AddServer.Location = new System.Drawing.Point(6, 199);
            this.AddServer.Name = "AddServer";
            this.AddServer.Size = new System.Drawing.Size(100, 23);
            this.AddServer.TabIndex = 2;
            this.AddServer.Text = "Add Server";
            this.AddServer.UseVisualStyleBackColor = true;
            this.AddServer.Click += new System.EventHandler(this.AddServer_Click);
            // 
            // PingTimer
            // 
            this.PingTimer.Enabled = true;
            this.PingTimer.Tick += new System.EventHandler(this.PingTimer_Tick);
            // 
            // Serverlist
            // 
            this.Serverlist.FormattingEnabled = true;
            this.Serverlist.Location = new System.Drawing.Point(6, 19);
            this.Serverlist.Name = "Serverlist";
            this.Serverlist.Size = new System.Drawing.Size(346, 147);
            this.Serverlist.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddServer);
            this.groupBox2.Controls.Add(this.RemoveServer);
            this.groupBox2.Controls.Add(this.ServerTextBox);
            this.groupBox2.Controls.Add(this.Serverlist);
            this.groupBox2.Location = new System.Drawing.Point(370, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RPM ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ServersListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateInfo;
        private System.Windows.Forms.Button RemoveServer;
        private System.Windows.Forms.Button AddServer;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Timer PingTimer;
        private System.Windows.Forms.ListBox Serverlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LastUpdate;
        private System.ComponentModel.BackgroundWorker PingBGWorker;
        private System.Windows.Forms.Button UpdateFreqBtn;
        private System.Windows.Forms.TextBox UpdateFreqTB;
    }
}

