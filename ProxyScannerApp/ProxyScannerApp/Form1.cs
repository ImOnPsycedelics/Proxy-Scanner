using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProxyScannerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Select Proxy List File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string[] proxies = File.ReadAllLines(filePath);
                    txtProxyList.Lines = proxies;
                    lblStatus.Text = "Status: Proxy list loaded.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading proxy file: " + ex.Message);
                    lblStatus.Text = "Status: Error loading proxy file.";
                }
            }
        }

        private async void btnScanProxies_Click(object sender, EventArgs e)
        {
            lstValidProxies.Items.Clear();
            string[] proxies = txtProxyList.Lines;
            HttpClient httpClient = new HttpClient();

            lblStatus.Text = "Status: Scanning proxies...";

            foreach (string proxy in proxies)
            {
                if (!string.IsNullOrEmpty(proxy))
                {
                    string proxyUrl = "http://" + proxy.Trim();
                    string status = "Not Working";
                    double speed = 0;

                    try
                    {
                        var handler = new HttpClientHandler()
                        {
                            Proxy = new System.Net.WebProxy(proxyUrl),
                            UseProxy = true
                        };

                        using (var client = new HttpClient(handler))
                        {
                            client.Timeout = TimeSpan.FromSeconds(5);

                            var watch = System.Diagnostics.Stopwatch.StartNew();
                            var response = await client.GetAsync("http://www.google.com");
                            watch.Stop();

                            if (response.IsSuccessStatusCode)
                            {
                                status = "Working";
                                speed = CalculateSpeed(watch.ElapsedMilliseconds);
                            }
                        }
                    }
                    catch
                    {
                        // If an exception occurs, the proxy is considered not working.
                    }

                    // Display the proxy status and speed in the ListBox
                    lstValidProxies.Items.Add($"{proxy} - {status} - {speed:F2} MB/s");
                }
            }

            lblStatus.Text = "Status: Proxy scan completed.";
        }

        private double CalculateSpeed(long elapsedMilliseconds)
        {
            // Assuming we're downloading a small resource, calculate the speed in MB/s.
            // For a simple calculation, let's assume a file size of 1MB for demonstration.
            const double fileSizeMB = 1.0; // 1 MB file size assumption

            double seconds = elapsedMilliseconds / 1000.0;
            double speed = fileSizeMB / seconds; // Speed in MB/s

            return speed;
        }

        private void btnSetProxy_Click(object sender, EventArgs e)
        {
            if (lstValidProxies.SelectedItem != null)
            {
                string selectedProxy = lstValidProxies.SelectedItem.ToString().Split(' ')[0]; // Get proxy only
                SetSystemProxy(selectedProxy);
                lblStatus.Text = "Status: Proxy set to " + selectedProxy;
            }
            else
            {
                MessageBox.Show("Please select a valid proxy from the list.");
            }
        }

        private void btnDisableProxy_Click(object sender, EventArgs e)
        {
            DisableSystemProxy();
            lblStatus.Text = "Status: Proxy disabled.";
        }

        private void SetSystemProxy(string proxy)
        {
            string registryKey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(registryKey, true))
            {
                if (regKey != null)
                {
                    regKey.SetValue("ProxyEnable", 1);
                    regKey.SetValue("ProxyServer", proxy);
                }
            }
        }

        private void DisableSystemProxy()
        {
            string registryKey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(registryKey, true))
            {
                if (regKey != null)
                {
                    regKey.SetValue("ProxyEnable", 0);
                    regKey.SetValue("ProxyServer", string.Empty);
                }
            }
        }
    }
}
