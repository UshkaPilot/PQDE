using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PQDE.Controller
{
    class Commands
    {
        static public void Open()
        {
            var dlg = new System.Windows.Forms.OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                String fileName = dlg.FileName;
            }

        }
    }
}
