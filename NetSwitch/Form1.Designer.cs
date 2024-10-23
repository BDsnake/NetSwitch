namespace NetSwitch
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;

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
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(50, 30);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(200, 30);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "切换到静态IP";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);

            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(50, 80);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 30);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "切换到DHCP";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(50, 130);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 30);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "设置静态 IP";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.Name = "Form1";
            this.Text = "NetSwitch";
            this.ResumeLayout(false);
        }
    }
}
