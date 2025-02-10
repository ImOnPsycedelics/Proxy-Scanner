namespace ProxyScannerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // TextBox to display proxies
        private System.Windows.Forms.TextBox txtProxyList;

        // Button to load proxies from a file
        private System.Windows.Forms.Button btnLoadFile;

        // Button to scan and check proxies
        private System.Windows.Forms.Button btnScanProxies;

        // ListBox to display valid proxies with status
        private System.Windows.Forms.ListBox lstValidProxies;

        // Button to set the proxy in the system
        private System.Windows.Forms.Button btnSetProxy;

        // Button to disable the proxy
        private System.Windows.Forms.Button btnDisableProxy;

        // Label to show the status of the proxy scan
        private System.Windows.Forms.Label lblStatus;

        // Method to clean up components
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize the components (UI)
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtProxyList = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnScanProxies = new System.Windows.Forms.Button();
            this.lstValidProxies = new System.Windows.Forms.ListBox();
            this.btnSetProxy = new System.Windows.Forms.Button();
            this.btnDisableProxy = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProxyList
            // 
            this.txtProxyList.BackColor = System.Drawing.Color.Black;
            this.txtProxyList.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyList.ForeColor = System.Drawing.Color.White;
            this.txtProxyList.Location = new System.Drawing.Point(102, 12);
            this.txtProxyList.Multiline = true;
            this.txtProxyList.Name = "txtProxyList";
            this.txtProxyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProxyList.Size = new System.Drawing.Size(403, 134);
            this.txtProxyList.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.Black;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadFile.Location = new System.Drawing.Point(12, 26);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load Proxies";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnScanProxies
            // 
            this.btnScanProxies.BackColor = System.Drawing.Color.Black;
            this.btnScanProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanProxies.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanProxies.ForeColor = System.Drawing.Color.White;
            this.btnScanProxies.Location = new System.Drawing.Point(12, 55);
            this.btnScanProxies.Name = "btnScanProxies";
            this.btnScanProxies.Size = new System.Drawing.Size(75, 23);
            this.btnScanProxies.TabIndex = 2;
            this.btnScanProxies.Text = "Scan";
            this.btnScanProxies.UseVisualStyleBackColor = false;
            this.btnScanProxies.Click += new System.EventHandler(this.btnScanProxies_Click);
            // 
            // lstValidProxies
            // 
            this.lstValidProxies.BackColor = System.Drawing.Color.Black;
            this.lstValidProxies.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstValidProxies.ForeColor = System.Drawing.Color.White;
            this.lstValidProxies.FormattingEnabled = true;
            this.lstValidProxies.ItemHeight = 11;
            this.lstValidProxies.Location = new System.Drawing.Point(102, 152);
            this.lstValidProxies.Name = "lstValidProxies";
            this.lstValidProxies.Size = new System.Drawing.Size(403, 136);
            this.lstValidProxies.TabIndex = 3;
            // 
            // btnSetProxy
            // 
            this.btnSetProxy.BackColor = System.Drawing.Color.Black;
            this.btnSetProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetProxy.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetProxy.ForeColor = System.Drawing.Color.White;
            this.btnSetProxy.Location = new System.Drawing.Point(12, 84);
            this.btnSetProxy.Name = "btnSetProxy";
            this.btnSetProxy.Size = new System.Drawing.Size(75, 23);
            this.btnSetProxy.TabIndex = 4;
            this.btnSetProxy.Text = "Set Proxy";
            this.btnSetProxy.UseVisualStyleBackColor = false;
            this.btnSetProxy.Click += new System.EventHandler(this.btnSetProxy_Click);
            // 
            // btnDisableProxy
            // 
            this.btnDisableProxy.BackColor = System.Drawing.Color.Black;
            this.btnDisableProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableProxy.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableProxy.ForeColor = System.Drawing.Color.White;
            this.btnDisableProxy.Location = new System.Drawing.Point(12, 113);
            this.btnDisableProxy.Name = "btnDisableProxy";
            this.btnDisableProxy.Size = new System.Drawing.Size(75, 23);
            this.btnDisableProxy.TabIndex = 5;
            this.btnDisableProxy.Text = "Disable Proxy";
            this.btnDisableProxy.UseVisualStyleBackColor = false;
            this.btnDisableProxy.Click += new System.EventHandler(this.btnDisableProxy_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Black;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(102, 289);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(403, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: Waiting for action...";
            // 
            // Form1
            // 
            this.BackgroundImage = global::ProxyScannerApp.Properties.Resources.black_and_white_anime_girl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDisableProxy);
            this.Controls.Add(this.btnSetProxy);
            this.Controls.Add(this.lstValidProxies);
            this.Controls.Add(this.btnScanProxies);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtProxyList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Psychedelics Proxy Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
