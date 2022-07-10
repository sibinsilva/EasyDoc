using System;
using MaterialSkin.Controls;

namespace DocEasy
{
    public partial class frmUserInput : MaterialForm
    {
        public frmUserInput()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string errorMsg = null;
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (clsHelper.ValidatePassword(txtPassword.Text,out errorMsg) || clsHelper.isUnlock)
                {
                    clsHelper.userPassword = txtPassword.Text;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MaterialMessageBox.Show(errorMsg);
                }
            }
            else
            {
                MaterialMessageBox.Show("Password should not be empty",false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
