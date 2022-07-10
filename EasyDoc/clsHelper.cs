using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocEasy
{
    public static class clsHelper
    {
        public static string userPassword = null;
        public static bool isUnlock = false;
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

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should be more than 8 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
