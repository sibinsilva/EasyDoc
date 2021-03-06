using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDoc
{
    public static class clsHelper
    {
        public static string userPassword = null;
        public static bool isUnlock = false;
        public static ListViewItem listViewItem = null;
        internal static void ChooseFiles(ListView lstSelection, bool bMultiSelect = false)
        {
            OpenFileDialog lstFiles = new OpenFileDialog();
            lstFiles.Multiselect = bMultiSelect;
            lstFiles.Filter = "Pdf Files|*.pdf";
            lstFiles.ShowDialog();
            if (lstFiles.FileNames.Length > 0)
            {
                foreach (string file in lstFiles.FileNames)
                {
                    lstSelection.Items.Add(Path.GetFileName(file), file);
                }
            }
        }

        internal static string UserSaveFile(string fileName = "MergedFiles")
        {
            string filePath = null;
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = fileName; // Default file name
                saveFile.DefaultExt = ".pdf"; // Default file extension
                saveFile.Filter = "PDF documents (.pdf)|*.pdf"; // Filter files by extension 

                // Show save file dialog box
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFile.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filePath;
        }


        internal static void CleanupUI(ListView lstSelection)
        {
            lstSelection.Clear();
            userPassword = null;
        }

        internal static bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            var hasMiniMaxChars = new Regex(@".{4,25}");
            
            if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should be more than 4 characters";
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static void DisplayMouseClickOptions(ListView lstSelection, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                foreach (ListViewItem item in lstSelection.Items)
                {
                    if (item.Bounds.Contains(new Point(e.X, e.Y)))
                    {
                        lstSelection.ContextMenuStrip = new ContextMenuStrip();
                        lstSelection.ContextMenuStrip.Items.Add("Preview");
                        lstSelection.ContextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
                        lstSelection.ContextMenuStrip.Show();
                        break;
                    }
                }
            }
        }

        private static void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            clsViewPdf.PreviewPdf(listViewItem);
        }
    }
}
