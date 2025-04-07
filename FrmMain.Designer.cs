namespace DVLD_3Tier
{
    partial class FrmMain
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReplacementForLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalDrivingLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReleaseDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPeople,
            this.tsmDrivers,
            this.tsmUsers,
            this.toolStripMenuItem4,
            this.toolstrip4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmPeople
            // 
            this.tsmPeople.Image = global::DVLD_3Tier.Properties.Resources.People_64;
            this.tsmPeople.Name = "tsmPeople";
            this.tsmPeople.Size = new System.Drawing.Size(105, 29);
            this.tsmPeople.Text = "People";
            this.tsmPeople.Click += new System.EventHandler(this.tsmPeople_Click);
            // 
            // tsmDrivers
            // 
            this.tsmDrivers.Image = global::DVLD_3Tier.Properties.Resources.Drivers_64;
            this.tsmDrivers.Name = "tsmDrivers";
            this.tsmDrivers.Size = new System.Drawing.Size(107, 29);
            this.tsmDrivers.Text = "Drivers";
            this.tsmDrivers.Click += new System.EventHandler(this.tsmDrivers_Click);
            // 
            // tsmUsers
            // 
            this.tsmUsers.Image = global::DVLD_3Tier.Properties.Resources.Add_New_User_72;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(95, 29);
            this.tsmUsers.Text = "Users";
            this.tsmUsers.Click += new System.EventHandler(this.tsmUsers_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolstrip3,
            this.toolstripmenu,
            this.tsmManageApplicationTypes,
            this.tsmManageTestTypes});
            this.toolStripMenuItem4.Image = global::DVLD_3Tier.Properties.Resources.Applications;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(150, 29);
            this.toolStripMenuItem4.Text = "Applications";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenu2,
            this.tsmRenewDrivingLicense,
            this.tsmReplacementForLostOrDamagedLicense,
            this.tsmReleaseDetainedLicense,
            this.tsmRetakeTest});
            this.toolStripMenuItem6.Image = global::DVLD_3Tier.Properties.Resources.Driver_License_32;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(323, 34);
            this.toolStripMenuItem6.Text = "Driving Licenses Services";
            // 
            // toolstripmenu2
            // 
            this.toolstripmenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalLicense,
            this.tsmInternationalLicense});
            this.toolstripmenu2.Image = global::DVLD_3Tier.Properties.Resources.New_Driving_License_32;
            this.toolstripmenu2.Name = "toolstripmenu2";
            this.toolstripmenu2.Size = new System.Drawing.Size(450, 34);
            this.toolstripmenu2.Text = "New Driving License";
            // 
            // tsmLocalLicense
            // 
            this.tsmLocalLicense.Image = global::DVLD_3Tier.Properties.Resources.Local_32;
            this.tsmLocalLicense.Name = "tsmLocalLicense";
            this.tsmLocalLicense.Size = new System.Drawing.Size(274, 34);
            this.tsmLocalLicense.Text = "Local License";
            this.tsmLocalLicense.Click += new System.EventHandler(this.tsmLocalLicense_Click);
            // 
            // tsmInternationalLicense
            // 
            this.tsmInternationalLicense.Image = global::DVLD_3Tier.Properties.Resources.International_321;
            this.tsmInternationalLicense.Name = "tsmInternationalLicense";
            this.tsmInternationalLicense.Size = new System.Drawing.Size(274, 34);
            this.tsmInternationalLicense.Text = "International License";
            this.tsmInternationalLicense.Click += new System.EventHandler(this.tsmInternationalLicense_Click);
            // 
            // tsmRenewDrivingLicense
            // 
            this.tsmRenewDrivingLicense.Image = global::DVLD_3Tier.Properties.Resources.Renew_Driving_License_32;
            this.tsmRenewDrivingLicense.Name = "tsmRenewDrivingLicense";
            this.tsmRenewDrivingLicense.Size = new System.Drawing.Size(450, 34);
            this.tsmRenewDrivingLicense.Text = "Renew Driving License";
            this.tsmRenewDrivingLicense.Click += new System.EventHandler(this.tsmRenewDrivingLicense_Click);
            // 
            // tsmReplacementForLostOrDamagedLicense
            // 
            this.tsmReplacementForLostOrDamagedLicense.Image = global::DVLD_3Tier.Properties.Resources.Damaged_Driving_License_32;
            this.tsmReplacementForLostOrDamagedLicense.Name = "tsmReplacementForLostOrDamagedLicense";
            this.tsmReplacementForLostOrDamagedLicense.Size = new System.Drawing.Size(450, 34);
            this.tsmReplacementForLostOrDamagedLicense.Text = "Replacement For Lost or Damaged License";
            this.tsmReplacementForLostOrDamagedLicense.Click += new System.EventHandler(this.tsmReplacementForLostOrDamagedLicense_Click);
            // 
            // tsmReleaseDetainedLicense
            // 
            this.tsmReleaseDetainedLicense.Image = global::DVLD_3Tier.Properties.Resources.Detained_Driving_License_32;
            this.tsmReleaseDetainedLicense.Name = "tsmReleaseDetainedLicense";
            this.tsmReleaseDetainedLicense.Size = new System.Drawing.Size(450, 34);
            this.tsmReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmReleaseDetainedLicense.Click += new System.EventHandler(this.tsmReleaseDetainedLicense_Click);
            // 
            // tsmRetakeTest
            // 
            this.tsmRetakeTest.Image = global::DVLD_3Tier.Properties.Resources.Retake_Test_32;
            this.tsmRetakeTest.Name = "tsmRetakeTest";
            this.tsmRetakeTest.Size = new System.Drawing.Size(450, 34);
            this.tsmRetakeTest.Text = "Retake Test";
            this.tsmRetakeTest.Click += new System.EventHandler(this.tsmRetakeTest_Click);
            // 
            // toolstrip3
            // 
            this.toolstrip3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicenseApplication,
            this.tsmInternationalDrivingLicenseApplication});
            this.toolstrip3.Image = global::DVLD_3Tier.Properties.Resources.app1;
            this.toolstrip3.Name = "toolstrip3";
            this.toolstrip3.Size = new System.Drawing.Size(323, 34);
            this.toolstrip3.Text = "Manage Applications";
            // 
            // tsmLocalDrivingLicenseApplication
            // 
            this.tsmLocalDrivingLicenseApplication.Image = global::DVLD_3Tier.Properties.Resources.LocalDriving_License;
            this.tsmLocalDrivingLicenseApplication.Name = "tsmLocalDrivingLicenseApplication";
            this.tsmLocalDrivingLicenseApplication.Size = new System.Drawing.Size(431, 34);
            this.tsmLocalDrivingLicenseApplication.Text = "Local Driving License Application";
            this.tsmLocalDrivingLicenseApplication.Click += new System.EventHandler(this.tsmLocalDrivingLicenseApplication_Click);
            // 
            // tsmInternationalDrivingLicenseApplication
            // 
            this.tsmInternationalDrivingLicenseApplication.Image = global::DVLD_3Tier.Properties.Resources.International_32;
            this.tsmInternationalDrivingLicenseApplication.Name = "tsmInternationalDrivingLicenseApplication";
            this.tsmInternationalDrivingLicenseApplication.Size = new System.Drawing.Size(431, 34);
            this.tsmInternationalDrivingLicenseApplication.Text = "International Driving License Application";
            this.tsmInternationalDrivingLicenseApplication.Click += new System.EventHandler(this.tsmInternationalDrivingLicenseApplication_Click);
            // 
            // toolstripmenu
            // 
            this.toolstripmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDetainLicense,
            this.tsmManageDetainLicense,
            this.tsmReleaseDetainLicense});
            this.toolstripmenu.Image = global::DVLD_3Tier.Properties.Resources.Detain_64;
            this.toolstripmenu.Name = "toolstripmenu";
            this.toolstripmenu.Size = new System.Drawing.Size(323, 34);
            this.toolstripmenu.Text = "Detained Licenses";
            // 
            // tsmDetainLicense
            // 
            this.tsmDetainLicense.Image = global::DVLD_3Tier.Properties.Resources.Detain_641;
            this.tsmDetainLicense.Name = "tsmDetainLicense";
            this.tsmDetainLicense.Size = new System.Drawing.Size(295, 34);
            this.tsmDetainLicense.Text = "Detain License";
            this.tsmDetainLicense.Click += new System.EventHandler(this.tsmDetainLicense_Click);
            // 
            // tsmManageDetainLicense
            // 
            this.tsmManageDetainLicense.Image = global::DVLD_3Tier.Properties.Resources.Detain_32;
            this.tsmManageDetainLicense.Name = "tsmManageDetainLicense";
            this.tsmManageDetainLicense.Size = new System.Drawing.Size(295, 34);
            this.tsmManageDetainLicense.Text = "Manage Detain License";
            this.tsmManageDetainLicense.Click += new System.EventHandler(this.tsmManageDetainLicense_Click);
            // 
            // tsmReleaseDetainLicense
            // 
            this.tsmReleaseDetainLicense.Image = global::DVLD_3Tier.Properties.Resources.Release_Detained_License_64;
            this.tsmReleaseDetainLicense.Name = "tsmReleaseDetainLicense";
            this.tsmReleaseDetainLicense.Size = new System.Drawing.Size(295, 34);
            this.tsmReleaseDetainLicense.Text = "Release Detain License";
            this.tsmReleaseDetainLicense.Click += new System.EventHandler(this.tsmReleaseDetainLicense_Click);
            // 
            // tsmManageApplicationTypes
            // 
            this.tsmManageApplicationTypes.Image = global::DVLD_3Tier.Properties.Resources.Application_Types_64;
            this.tsmManageApplicationTypes.Name = "tsmManageApplicationTypes";
            this.tsmManageApplicationTypes.Size = new System.Drawing.Size(323, 34);
            this.tsmManageApplicationTypes.Text = "Manage Application Types";
            this.tsmManageApplicationTypes.Click += new System.EventHandler(this.tsmManageApplicationTypes_Click);
            // 
            // tsmManageTestTypes
            // 
            this.tsmManageTestTypes.Image = global::DVLD_3Tier.Properties.Resources.Test_Type_64;
            this.tsmManageTestTypes.Name = "tsmManageTestTypes";
            this.tsmManageTestTypes.Size = new System.Drawing.Size(323, 34);
            this.tsmManageTestTypes.Text = "Manage Test Types";
            this.tsmManageTestTypes.Click += new System.EventHandler(this.tsmManageTestTypes_Click);
            // 
            // toolstrip4
            // 
            this.toolstrip4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUserInfo,
            this.tsmChangePassword,
            this.tsmSignOut});
            this.toolstrip4.Image = global::DVLD_3Tier.Properties.Resources.account_settings_64;
            this.toolstrip4.Name = "toolstrip4";
            this.toolstrip4.Size = new System.Drawing.Size(186, 29);
            this.toolstrip4.Text = "Account Settings";
            // 
            // tsmUserInfo
            // 
            this.tsmUserInfo.Image = global::DVLD_3Tier.Properties.Resources.PersonDetails_32;
            this.tsmUserInfo.Name = "tsmUserInfo";
            this.tsmUserInfo.Size = new System.Drawing.Size(254, 34);
            this.tsmUserInfo.Text = "User Info";
            this.tsmUserInfo.Click += new System.EventHandler(this.tsmUserInfo_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = global::DVLD_3Tier.Properties.Resources.Password_32;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(254, 34);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Image = global::DVLD_3Tier.Properties.Resources.SignOut_64;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(254, 34);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::DVLD_3Tier.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1324, 654);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolstrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolstrip3;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenu;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenu2;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReplacementForLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmManageDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainLicense;
    }
}

