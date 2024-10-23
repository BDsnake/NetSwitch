using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NetSwitch
{
    public partial class Form1 : Form
    {
        private string ipAddress;
        private string subnetMask;
        private string gateway;  // 这里可以根据需要修改
        private string dns1;
        private string dns2;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // 注册加载事件
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 加载之前保存的设置
            ipAddress = NetSwitch.Properties.Settings.Default.IPAddress;
            subnetMask = NetSwitch.Properties.Settings.Default.SubnetMask;
            gateway = NetSwitch.Properties.Settings.Default.GateWay;
            dns1 = NetSwitch.Properties.Settings.Default.DNS1;
            dns2 = NetSwitch.Properties.Settings.Default.DNS2;
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            // 切换到公司网络（静态 IP）
            SetStaticIP(ipAddress, subnetMask, gateway, dns1, dns2);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // 切换到家庭网络（DHCP）
            SetDHCP();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // 打开设置窗口
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void SetStaticIP(string ipAddress, string subnetMask, string gateway, string dns1, string dns2)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", $"interface ip set address \"以太网\" static {ipAddress} {subnetMask} {gateway} 1");
            psi.Verb = "runas";  // 以管理员身份运行
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);

            psi = new ProcessStartInfo("netsh", $"interface ip set dns \"以太网\" static {dns1} primary");
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);

            psi = new ProcessStartInfo("netsh", $"interface ip add dns \"以太网\" {dns2} index=2");
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void SetDHCP()
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"以太网\" dhcp");
            psi.Verb = "runas";  // 以管理员身份运行
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);

            psi = new ProcessStartInfo("netsh", "interface ip set dns \"以太网\" dhcp");
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public void UpdateSettings(string ip, string mask, string gateway, string dns1, string dns2, string adapterName)
        {
            // 保存到设置
            NetSwitch.Properties.Settings.Default.IPAddress = ip;
            NetSwitch.Properties.Settings.Default.SubnetMask = mask;
            NetSwitch.Properties.Settings.Default.GateWay = gateway;
            NetSwitch.Properties.Settings.Default.DNS1 = dns1;
            NetSwitch.Properties.Settings.Default.DNS2 = dns2;
            NetSwitch.Properties.Settings.Default.AdapterName = adapterName; // 保存适配器名称
            NetSwitch.Properties.Settings.Default.Save(); // 保存设置
        }

    }
}
