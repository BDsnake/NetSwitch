using System;
using System.Windows.Forms;

namespace NetSwitch
{
    public partial class SettingsForm : Form
    {
        private Form1 mainForm;

        public SettingsForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;

            // 加载之前保存的设置
            LoadSettings();
        }

        private void LoadSettings()
        {
            txtIPAddress.Text = NetSwitch.Properties.Settings.Default.IPAddress;
            txtSubnetMask.Text = NetSwitch.Properties.Settings.Default.SubnetMask;
            txtGateWay.Text = NetSwitch.Properties.Settings.Default.GateWay;
            txtDNS1.Text = NetSwitch.Properties.Settings.Default.DNS1;
            txtDNS2.Text = NetSwitch.Properties.Settings.Default.DNS2;
            txtAdapterName.Text = NetSwitch.Properties.Settings.Default.AdapterName; // 加载适配器名称
        }

        private bool IsValidIP(string ip)
        {
            // 使用正则表达式验证 IP 地址格式
            var ipRegex = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return System.Text.RegularExpressions.Regex.IsMatch(ip, ipRegex);
        }

        private bool IsValidSubnetMask(string mask)
        {
            // 检查子网掩码是否有效
            string[] validMasks = { "255.255.255.255", "255.255.255.254", "255.255.255.252", "255.255.255.248", "255.255.255.240",
                                    "255.255.255.224", "255.255.255.192", "255.255.255.128", "255.255.255.0", "255.255.0.0",
                                    "255.0.0.0", "0.0.0.0" };
            return Array.Exists(validMasks, m => m == mask);
        }

        private bool IsValidGateway(string gateway)
        {
            // 验证网关是否为有效 IP 地址
            return IsValidIP(gateway);
        }

        private bool IsValidDNS(string dns)
        {
            // 验证 DNS 是否为有效 IP 地址
            return IsValidIP(dns);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ip = txtIPAddress.Text;
            string mask = txtSubnetMask.Text;
            string gateway = txtGateWay.Text; // 获取网关
            string dns1 = txtDNS1.Text;
            string dns2 = txtDNS2.Text;
            string adapterName = txtAdapterName.Text; // 获取适配器名称

            // 进行验证
            if (!IsValidIP(ip))
            {
                MessageBox.Show("请输入有效的 IP 地址。", "无效输入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidSubnetMask(mask))
            {
                MessageBox.Show("请输入有效的子网掩码。", "无效输入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidGateway(gateway))
            {
                MessageBox.Show("请输入有效的网关地址。", "无效输入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidDNS(dns1))
            {
                MessageBox.Show("请输入有效的主 DNS 地址。", "无效输入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidDNS(dns2))
            {
                MessageBox.Show("请输入有效的备用 DNS 地址。", "无效输入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 如果所有验证都通过，更新主窗体设置

            mainForm.UpdateSettings(ip, mask, gateway, dns1, dns2, adapterName); // 更新主窗体设置
            this.Close();
        }
    }
}
