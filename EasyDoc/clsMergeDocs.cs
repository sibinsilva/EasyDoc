using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Windows.Forms;

namespace EasyDoc
{
    public enum MoveDirection { Up = -1, Down = 1 };
    internal static class clsMergeDocs
    {
        private static string targetPath = null;

        private static void MoveListViewItems(ListView listView1, MoveDirection direction)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0) { return; }

                ListViewItem item = listView1.SelectedItems[0];
                int newIndex = item.Index + (int)direction;

                if (newIndex < 0 || newIndex >= listView1.Items.Count) { return; }

                var currentView = listView1.View;
                listView1.BeginUpdate();
                listView1.View = View.Details;
                listView1.Items.Remove(item);
                listView1.Items.Insert(newIndex, item);
                listView1.EnsureVisible(newIndex);
                listView1.View = currentView;
                listView1.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void MoveUp(ListView lstSelection)
        {
            MoveListViewItems(lstSelection, MoveDirection.Up);
        }

        internal static void MoveDown(ListView lstSelection)
        {
            MoveListViewItems(lstSelection, MoveDirection.Down);
        }

        internal static void MergeDocument(ListView lstSelection)
        {
            try
            {
                string[] arrFiles = GetFileNames(lstSelection);
                using (var targetDoc = new PdfDocument())
                {
                    foreach (var pdf in arrFiles)
                    {
                        using (var pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                        {
                            for (var i = 0; i < pdfDoc.PageCount; i++)
                                targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                    targetPath = clsHelper.UserSaveFile();
                    targetDoc.Save(targetPath);
                    MessageBox.Show("File saved to :" + targetPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsHelper.CleanupUI(lstSelection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string[] GetFileNames(ListView lstSelection)
        {
            string[] files = new string[lstSelection.Items.Count];
            try
            {
                for (int i = 0; i < lstSelection.Items.Count; i++)
                {
                    files[i] = lstSelection.Items[i].ImageKey;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return files;
        }
    }
}
