using BusinessLayer;
using DVLD_3Tier.Applications.Applications_Types;
using DVLD_3Tier.Applications.Local_Driving_License;
using DVLD_3Tier.Drivers;
using DVLD_3Tier.Global_Classes;
using DVLD_3Tier.People;
using DVLD_3Tier.Tests.TestTypes;
using DVLD_3Tier.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_3Tier
{           // test here
    public partial class FrmMain : Form
    {

        frmLogin _frmLogin;
        public FrmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _frmLogin = frmLogin;
        }

        private void tsmPeople_Click(object sender, EventArgs e)
        {
            Form frm = new FrmListPeople();
            frm.ShowDialog();
        }

        private void tsmDrivers_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void tsmUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void tsmLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
        }

        private void tsmInternationalLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("international license");
        }

        private void tsmRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("renew license");
        }

        private void tsmReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("replacement for lost or damaged license");
        }

        private void tsmRetakeTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("retake test");
        }

        private void tsmLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }

        private void tsmInternationalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("international license application");
        }

        private void tsmDetainLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("detain license");
        }

        private void tsmManageDetainLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("manage deatain license");
        }

        private void tsmReleaseDetainLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("release detain license");
        }

        private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("release detain license");
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
           frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }

        private void tsmUserInfo_Click(object sender, EventArgs e)
        {

            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

       
    }
}
