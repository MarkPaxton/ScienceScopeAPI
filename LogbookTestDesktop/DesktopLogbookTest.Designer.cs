namespace LogbookTest
{
    partial class DesktopLogbookTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.getVersionButton = new System.Windows.Forms.Button();
            this.takeReadingButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(282, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(400, 445);
            this.textBox1.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 7);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(95, 32);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(181, 7);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(95, 32);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // getVersionButton
            // 
            this.getVersionButton.Location = new System.Drawing.Point(11, 61);
            this.getVersionButton.Name = "getVersionButton";
            this.getVersionButton.Size = new System.Drawing.Size(90, 23);
            this.getVersionButton.TabIndex = 3;
            this.getVersionButton.Text = "Get Version";
            this.getVersionButton.UseVisualStyleBackColor = true;
            this.getVersionButton.Click += new System.EventHandler(this.getVersionButton_Click);
            // 
            // takeReadingButton
            // 
            this.takeReadingButton.Location = new System.Drawing.Point(12, 90);
            this.takeReadingButton.Name = "takeReadingButton";
            this.takeReadingButton.Size = new System.Drawing.Size(90, 23);
            this.takeReadingButton.TabIndex = 4;
            this.takeReadingButton.Text = "Take a reading";
            this.takeReadingButton.UseVisualStyleBackColor = true;
            this.takeReadingButton.Click += new System.EventHandler(this.takeReadingButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update sensors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DesktopLogbookTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.takeReadingButton);
            this.Controls.Add(this.getVersionButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.textBox1);
            this.Name = "DesktopLogbookTest";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Logbook Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopLogbookTest_FormClosing);
            this.Load += new System.EventHandler(this.DesktopLogbookTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button getVersionButton;
        private System.Windows.Forms.Button takeReadingButton;
        private System.Windows.Forms.Button button1;
    }
}

