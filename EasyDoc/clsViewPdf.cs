using GroupDocs.Merger;
using GroupDocs.Merger.Domain.Common;
using GroupDocs.Merger.Domain.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDoc
{
    internal static class clsViewPdf
    {
        internal static void PreviewPdf(ListViewItem listViewItem)
        {
            string path = listViewItem.ImageKey;
            try
            {
                //I think this is easier
                Process.Start(path);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
