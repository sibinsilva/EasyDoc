using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger;
using System;
using System.IO;
using MaterialSkin.Controls;
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
                    merger.Save(newPath);
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
                    merger.Save(newPath);
                    result = true;
                }
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Password does not match");
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
