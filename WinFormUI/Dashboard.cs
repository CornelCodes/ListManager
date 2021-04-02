using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            displayUpdateBackgroundWorker.RunWorkerAsync();
        }

        private void GetFolders()
        {
            foldersListBox.DataSource = DataAccess.GetDirectoryNames();
        }

        private void GetSubFolder()
        {
            itemsListBox.DataSource = DataAccess.GetSubDirectoryNames(foldersListBox.SelectedItem.ToString());
        }

        private void UpdateDashboard()
        {
            GetFolders();
            GetSubFolder();
        }

        private void displayUpdateBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                UpdateDashboard();
            }
        }
    }
}
/**
 * Continue here
 * ERROR : 
 * Cross-thread operation not valid: Control 'textBox1' accessed 
 * from a thread other than the thread it was created on [duplicate].
 * Look into:
 * 1.Reflection
 * 2.Make thread-safe calls to Windows Forms controls
 * 3.Threading issue
