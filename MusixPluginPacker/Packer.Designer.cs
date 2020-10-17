namespace MusixPluginPacker
{
    partial class Packer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packer));
            this.lblPlAs = new System.Windows.Forms.Label();
            this.txtPluginAsm = new System.Windows.Forms.TextBox();
            this.btnBrowseAsembly = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listDep = new System.Windows.Forms.ListBox();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.btnRemDep = new System.Windows.Forms.Button();
            this.btnPack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cblPlatforms = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtMinVersion = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.tabPlatforms = new System.Windows.Forms.TabPage();
            this.tabAssemblies = new System.Windows.Forms.TabPage();
            this.tabPack = new System.Windows.Forms.TabPage();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.TabInfo.SuspendLayout();
            this.tabPlatforms.SuspendLayout();
            this.tabAssemblies.SuspendLayout();
            this.tabPack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlAs
            // 
            this.lblPlAs.AutoSize = true;
            this.lblPlAs.Location = new System.Drawing.Point(16, 76);
            this.lblPlAs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlAs.Name = "lblPlAs";
            this.lblPlAs.Size = new System.Drawing.Size(155, 24);
            this.lblPlAs.TabIndex = 28;
            this.lblPlAs.Text = "Plugin Assembly:";
            // 
            // txtPluginAsm
            // 
            this.txtPluginAsm.Location = new System.Drawing.Point(20, 104);
            this.txtPluginAsm.Name = "txtPluginAsm";
            this.txtPluginAsm.Size = new System.Drawing.Size(462, 29);
            this.txtPluginAsm.TabIndex = 12;
            // 
            // btnBrowseAsembly
            // 
            this.btnBrowseAsembly.Location = new System.Drawing.Point(492, 104);
            this.btnBrowseAsembly.Name = "btnBrowseAsembly";
            this.btnBrowseAsembly.Size = new System.Drawing.Size(86, 29);
            this.btnBrowseAsembly.TabIndex = 9;
            this.btnBrowseAsembly.Text = "Browse";
            this.btnBrowseAsembly.UseVisualStyleBackColor = true;
            this.btnBrowseAsembly.Click += new System.EventHandler(this.btnBrowseAsembly_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Dependencies:";
            // 
            // listDep
            // 
            this.listDep.FormattingEnabled = true;
            this.listDep.ItemHeight = 24;
            this.listDep.Location = new System.Drawing.Point(20, 174);
            this.listDep.Name = "listDep";
            this.listDep.Size = new System.Drawing.Size(462, 220);
            this.listDep.TabIndex = 13;
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(20, 400);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(95, 33);
            this.btnAddDep.TabIndex = 10;
            this.btnAddDep.Text = "Add";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // btnRemDep
            // 
            this.btnRemDep.Location = new System.Drawing.Point(121, 400);
            this.btnRemDep.Name = "btnRemDep";
            this.btnRemDep.Size = new System.Drawing.Size(95, 33);
            this.btnRemDep.TabIndex = 14;
            this.btnRemDep.Text = "Remove";
            this.btnRemDep.UseVisualStyleBackColor = true;
            this.btnRemDep.Click += new System.EventHandler(this.btnRemDep_Click);
            // 
            // btnPack
            // 
            this.btnPack.Location = new System.Drawing.Point(256, 218);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(95, 36);
            this.btnPack.TabIndex = 15;
            this.btnPack.Text = "Pack";
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Plugin Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(466, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(17, 95);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(466, 29);
            this.txtDesc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Plugin Description:";
            // 
            // cblPlatforms
            // 
            this.cblPlatforms.FormattingEnabled = true;
            this.cblPlatforms.Items.AddRange(new object[] {
            "Windows",
            "Android",
            "Linux",
            "MacOS"});
            this.cblPlatforms.Location = new System.Drawing.Point(16, 36);
            this.cblPlatforms.Name = "cblPlatforms";
            this.cblPlatforms.Size = new System.Drawing.Size(184, 100);
            this.cblPlatforms.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Supported Platforms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Min Version:";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(17, 216);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(466, 29);
            this.txtTags.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Plugin Tags:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Plugin Icon:";
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(16, 36);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(466, 29);
            this.txtIcon.TabIndex = 11;
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.Location = new System.Drawing.Point(488, 37);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(86, 29);
            this.btnBrowseIcon.TabIndex = 8;
            this.btnBrowseIcon.Text = "Browse";
            this.btnBrowseIcon.UseVisualStyleBackColor = true;
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // txtMinVersion
            // 
            this.txtMinVersion.Location = new System.Drawing.Point(16, 172);
            this.txtMinVersion.Name = "txtMinVersion";
            this.txtMinVersion.Size = new System.Drawing.Size(184, 29);
            this.txtMinVersion.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(17, 157);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(466, 29);
            this.txtAuthor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Plugin Author:";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.TabInfo);
            this.tabMain.Controls.Add(this.tabPlatforms);
            this.tabMain.Controls.Add(this.tabAssemblies);
            this.tabMain.Controls.Add(this.tabPack);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(636, 499);
            this.tabMain.TabIndex = 24;
            // 
            // TabInfo
            // 
            this.TabInfo.Controls.Add(this.txtWebsite);
            this.TabInfo.Controls.Add(this.label9);
            this.TabInfo.Controls.Add(this.txtTags);
            this.TabInfo.Controls.Add(this.txtName);
            this.TabInfo.Controls.Add(this.txtAuthor);
            this.TabInfo.Controls.Add(this.label6);
            this.TabInfo.Controls.Add(this.txtDesc);
            this.TabInfo.Controls.Add(this.label3);
            this.TabInfo.Controls.Add(this.label2);
            this.TabInfo.Controls.Add(this.label8);
            this.TabInfo.Location = new System.Drawing.Point(4, 33);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Size = new System.Drawing.Size(628, 462);
            this.TabInfo.TabIndex = 0;
            this.TabInfo.Text = "Plugin Info";
            this.TabInfo.UseVisualStyleBackColor = true;
            // 
            // tabPlatforms
            // 
            this.tabPlatforms.Controls.Add(this.cblPlatforms);
            this.tabPlatforms.Controls.Add(this.label4);
            this.tabPlatforms.Controls.Add(this.label5);
            this.tabPlatforms.Controls.Add(this.txtMinVersion);
            this.tabPlatforms.Location = new System.Drawing.Point(4, 33);
            this.tabPlatforms.Name = "tabPlatforms";
            this.tabPlatforms.Size = new System.Drawing.Size(628, 462);
            this.tabPlatforms.TabIndex = 1;
            this.tabPlatforms.Text = "Compatability";
            this.tabPlatforms.UseVisualStyleBackColor = true;
            // 
            // tabAssemblies
            // 
            this.tabAssemblies.Controls.Add(this.lblPlAs);
            this.tabAssemblies.Controls.Add(this.txtPluginAsm);
            this.tabAssemblies.Controls.Add(this.btnRemDep);
            this.tabAssemblies.Controls.Add(this.btnBrowseIcon);
            this.tabAssemblies.Controls.Add(this.btnAddDep);
            this.tabAssemblies.Controls.Add(this.btnBrowseAsembly);
            this.tabAssemblies.Controls.Add(this.label1);
            this.tabAssemblies.Controls.Add(this.listDep);
            this.tabAssemblies.Controls.Add(this.txtIcon);
            this.tabAssemblies.Controls.Add(this.label7);
            this.tabAssemblies.Location = new System.Drawing.Point(4, 33);
            this.tabAssemblies.Name = "tabAssemblies";
            this.tabAssemblies.Size = new System.Drawing.Size(628, 462);
            this.tabAssemblies.TabIndex = 2;
            this.tabAssemblies.Text = "Files";
            this.tabAssemblies.UseVisualStyleBackColor = true;
            // 
            // tabPack
            // 
            this.tabPack.Controls.Add(this.btnPack);
            this.tabPack.Location = new System.Drawing.Point(4, 33);
            this.tabPack.Name = "tabPack";
            this.tabPack.Size = new System.Drawing.Size(628, 462);
            this.tabPack.TabIndex = 3;
            this.tabPack.Text = "Pack";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(17, 278);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(466, 29);
            this.txtWebsite.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Website/Project URL:";
            // 
            // Packer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 499);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Packer";
            this.Text = "Musix Plugin Packer";
            this.Load += new System.EventHandler(this.Packer_Load);
            this.tabMain.ResumeLayout(false);
            this.TabInfo.ResumeLayout(false);
            this.TabInfo.PerformLayout();
            this.tabPlatforms.ResumeLayout(false);
            this.tabPlatforms.PerformLayout();
            this.tabAssemblies.ResumeLayout(false);
            this.tabAssemblies.PerformLayout();
            this.tabPack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlAs;
        private System.Windows.Forms.TextBox txtPluginAsm;
        private System.Windows.Forms.Button btnBrowseAsembly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDep;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.Button btnRemDep;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cblPlatforms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtMinVersion;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage TabInfo;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPlatforms;
        private System.Windows.Forms.TabPage tabAssemblies;
        private System.Windows.Forms.TabPage tabPack;
    }
}