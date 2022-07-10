using System;
using DocEasy;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EasyDoc
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.LightBlue500, Accent.LightGreen200, TextShade.WHITE);
            btnUp.Text = char.ConvertFromUtf32(8593);
            btnDown.Text = char.ConvertFromUtf32(8595);
        }

        private void btnMerge_Click_1(object sender, EventArgs e)
        {
            clsMergeDocs.MergeDocument(lstSelection);
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            clsMergeDocs.MoveUp(lstSelection);
        }

        private void btnDown_Click_1(object sender, EventArgs e)
        {
            clsMergeDocs.MoveDown(lstSelection);
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            clsHelper.ChooseFiles(lstSelection,true);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clsHelper.CleanupUI(lstSelection);
        }

        private void btnSelectTab2_Click(object sender, EventArgs e)
        {
            clsHelper.ChooseFiles(lstvEditPdf);
        }

        private void btnLockFile_Click(object sender, EventArgs e)
        {
            if (lstvEditPdf.Items.Count > 0)
            {
                if (!clsEditPdf.IsDocumentLocked(lstvEditPdf.Items[0].ImageKey))
                {
                    frmUserInput userInput = new frmUserInput();
                    if (userInput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        clsEditPdf.ProtectPdfFile(lstvEditPdf.Items[0].ImageKey, clsHelper.userPassword);
                        clsHelper.CleanupUI(lstvEditPdf);
                    }
                }
                else
                {
                    MaterialMessageBox.Show("File is already password protected");
                }
            }
        }

        private void btnUnlockFile_Click(object sender, EventArgs e)
        {
            clsHelper.isUnlock = true;
            if (lstvEditPdf.Items.Count > 0)
            {
                if (clsEditPdf.IsDocumentLocked(lstvEditPdf.Items[0].ImageKey))
                {
                    frmUserInput userInput = new frmUserInput();
                    if (userInput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (clsEditPdf.UnProtectPdf(lstvEditPdf.Items[0].ImageKey, clsHelper.userPassword))
                        {
                            clsHelper.CleanupUI(lstvEditPdf);
                        }
                    }
                }
                else
                {
                    MaterialMessageBox.Show("File is not password protected");
                }
            }
            clsHelper.isUnlock = false;
        }

        private void btnClearTab2_Click(object sender, EventArgs e)
        {
            clsHelper.CleanupUI(lstvEditPdf);
        }

    }
}
