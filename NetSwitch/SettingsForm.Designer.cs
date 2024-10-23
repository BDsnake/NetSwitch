namespace NetSwitch
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.Label lblGateWay;
        private System.Windows.Forms.Label lblDNS1;
        private System.Windows.Forms.Label lblDNS2;
        private System.Windows.Forms.Label lblAdapterName;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.TextBox txtGateWay;
        private System.Windows.Forms.TextBox txtDNS1;
        private System.Windows.Forms.TextBox txtDNS2;
        private System.Windows.Forms.TextBox txtAdapterName;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblGateWay = new System.Windows.Forms.Label();
            this.lblDNS1 = new System.Windows.Forms.Label();
            this.lblDNS2 = new System.Windows.Forms.Label();
            this.lblAdapterName = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.txtGateWay = new System.Windows.Forms.TextBox();
            this.txtDNS1 = new System.Windows.Forms.TextBox();
            this.txtDNS2 = new System.Windows.Forms.TextBox();
            this.txtAdapterName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(12, 15);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(74, 17);
            this.lblIPAddress.TabIndex = 0;
            this.lblIPAddress.Text = "静态 IP 地址:";

            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(12, 50);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(74, 17);
            this.lblSubnetMask.TabIndex = 1;
            this.lblSubnetMask.Text = "子网掩码:";

            // 
            // lblGateWay
            // 
            this.lblGateWay.AutoSize = true;
            this.lblGateWay.Location = new System.Drawing.Point(12, 85);
            this.lblGateWay.Name = "lblGateWay";
            this.lblGateWay.Size = new System.Drawing.Size(74, 17);
            this.lblGateWay.TabIndex = 2;
            this.lblGateWay.Text = "网关:";

            // 
            // lblDNS1
            // 
            this.lblDNS1.AutoSize = true;
            this.lblDNS1.Location = new System.Drawing.Point(12, 120);
            this.lblDNS1.Name = "lblDNS1";
            this.lblDNS1.Size = new System.Drawing.Size(44, 17);
            this.lblDNS1.TabIndex = 3;
            this.lblDNS1.Text = "主 DNS:";

            // 
            // lblDNS2
            // 
            this.lblDNS2.AutoSize = true;
            this.lblDNS2.Location = new System.Drawing.Point(12, 155);
            this.lblDNS2.Name = "lblDNS2";
            this.lblDNS2.Size = new System.Drawing.Size(74, 17);
            this.lblDNS2.TabIndex = 4;
            this.lblDNS2.Text = "备用 DNS:";

            // 
            // lblAdapterName
            // 
            this.lblAdapterName.AutoSize = true;
            this.lblAdapterName.Location = new System.Drawing.Point(12, 190);
            this.lblAdapterName.Name = "lblAdapterName";
            this.lblAdapterName.Size = new System.Drawing.Size(74, 17);
            this.lblAdapterName.TabIndex = 5;
            this.lblAdapterName.Text = "适配器名称:";

            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(100, 12);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(150, 22);
            this.txtIPAddress.TabIndex = 6;

            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(100, 47);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(150, 22);
            this.txtSubnetMask.TabIndex = 7;

            // 
            // txtGateWay
            // 
            this.txtGateWay.Location = new System.Drawing.Point(100, 82);
            this.txtGateWay.Name = "txtGateWay";
            this.txtGateWay.Size = new System.Drawing.Size(150, 22);
            this.txtGateWay.TabIndex = 8;

            // 
            // txtDNS1
            // 
            this.txtDNS1.Location = new System.Drawing.Point(100, 117);
            this.txtDNS1.Name = "txtDNS1";
            this.txtDNS1.Size = new System.Drawing.Size(150, 22);
            this.txtDNS1.TabIndex = 9;

            // 
            // txtDNS2
            // 
            this.txtDNS2.Location = new System.Drawing.Point(100, 152);
            this.txtDNS2.Name = "txtDNS2";
            this.txtDNS2.Size = new System.Drawing.Size(150, 22);
            this.txtDNS2.TabIndex = 10;

            // 
            // txtAdapterName
            // 
            this.txtAdapterName.Location = new System.Drawing.Point(100, 187);
            this.txtAdapterName.Name = "txtAdapterName";
            this.txtAdapterName.Size = new System.Drawing.Size(150, 22);
            this.txtAdapterName.TabIndex = 11;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 270);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblSubnetMask);
            this.Controls.Add(this.lblGateWay);
            this.Controls.Add(this.lblDNS1);
            this.Controls.Add(this.lblDNS2);
            this.Controls.Add(this.lblAdapterName);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.txtSubnetMask);
            this.Controls.Add(this.txtGateWay);
            this.Controls.Add(this.txtDNS1);
            this.Controls.Add(this.txtDNS2);
            this.Controls.Add(this.txtAdapterName);
            this.Controls.Add(this.btnSave);
            this.Name = "SettingsForm";
            this.Text = "设置静态 IP";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
