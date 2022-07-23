using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger;
using System;
using System.IO;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace EasyDoc
{
    internal static class clsEditPdf
    {
        internal static void ProtectPdfFile(string filePath, string password)
        {
            string fileName = "LockedFile_" + Path.GetFileName(filePath);
            try
			{
                AddPasswordOptions addOptions = new AddPasswordOptions(password);

                using (Merger merger = new Merger(filePath))
                {
                    merger.AddPassword(addOptions);
                    var newPath = clsHelper.UserSaveFile(fileName);
                    if (!string.IsNullOrEmpty(newPath))
                    {
                        merger.Save(newPath);
                        MessageBox.Show("File saved to :" + newPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
			catch (Exception)
			{

				throw;
			}
        }

        internal static bool UnProtectPdf(string filePath,string userPassword)
        {
            bool result = false;    
            string fileName = "UnlockedFile_" + Path.GetFileName(filePath);
            try
            {
                LoadOptions loadOptions = new LoadOptions(userPassword);

                using (Merger merger = new Merger(filePath, loadOptions))
                {
                    merger.RemovePassword();
                    string newPath = clsHelper.UserSaveFile(fileName);
                    if (!string.IsNullOrEmpty(newPath))
                    {
                        merger.Save(newPath);
                        result = true;
                        MessageBox.Show("File saved to :" + newPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Password does not match", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        internal static bool IsDocumentLocked(string fileName)
        {
            bool isProtected = false;
            try
            {
                LoadOptions loadOptions = new LoadOptions(GroupDocs.Merger.Domain.FileType.PDF);
                using (Merger merger = new Merger(fileName, loadOptions))
                {
                    isProtected = merger.IsPasswordSet();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return isProtected;
        }
    }
}
