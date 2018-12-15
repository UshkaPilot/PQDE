using PQDE.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PQDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Commands.Open();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                Commands.Open();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
