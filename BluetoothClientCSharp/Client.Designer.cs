namespace BluetoothClientCSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.iPBox = new System.Windows.Forms.TextBox();
            this.iPLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // iPBox
            // 
            this.iPBox.Location = new System.Drawing.Point(41, 12);
            this.iPBox.Name = "iPBox";
            this.iPBox.Size = new System.Drawing.Size(100, 20);
            this.iPBox.TabIndex = 0;
            // 
            // iPLabel
            // 
            this.iPLabel.AutoSize = true;
            this.iPLabel.Location = new System.Drawing.Point(9, 15);
            this.iPLabel.Name = "iPLabel";
            this.iPLabel.Size = new System.Drawing.Size(20, 13);
            this.iPLabel.TabIndex = 1;
            this.iPLabel.Text = "IP:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(9, 47);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(41, 44);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 20);
            this.portBox.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(41, 83);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(170, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(603, 387);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.iPLabel);
            this.Controls.Add(this.iPBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "EV3 Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iPBox;
        private System.Windows.Forms.Label iPLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListView listView1;
    }
}

