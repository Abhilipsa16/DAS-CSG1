using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FileManagementControl : UserControl
    {
        public FileManagementControl()
        {
            InitializeComponent();
            fileSidepanel.Height = btn_newFile.Height;
            fileSidepanel.Top = btn_newFile.Top;
            newFileControl1.BringToFront();
        }

        private void btn_newFile_Click(object sender, EventArgs e)
        {
            fileSidepanel.Height = btn_newFile.Height;
            fileSidepanel.Top = btn_newFile.Top;
            newFileControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileSidepanel.Height = btn_openFile.Height;
            fileSidepanel.Top = btn_openFile.Top;
            openFileControl1.BringToFront();
        }

        
    }
}
