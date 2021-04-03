using Library;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        SafeInvoke _safeInvoker = new SafeInvoke();

        public Dashboard()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            SetFolders();
            SetSubFolders();
        }

        private void SetListBox(string[] input, ListBox target)
        {
            _safeInvoker.Invoke(delegate
            {
                target.DataSource = input;
            });
        }

        private void SetFolders()
        {
            SetListBox(DataAccess.GetDirectoryNames(), foldersListBox);
        }

        private void SetSubFolders()
        {
            SetListBox(DataAccess.GetSubDirectoryNames(foldersListBox.SelectedItem.ToString()), itemsListBox);
        }

        private void SetContent()
        {
            contentsTextBox.Text = DataAccess.GetContentFromFile(itemsListBox.SelectedItem.ToString(), foldersListBox.SelectedItem.ToString());
        }

        private void foldersListBox_MouseDown(object sender, MouseEventArgs e)
        {
            SetSubFolders();
        }

        private void itemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            SetContent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataAccess.SaveContentToFile(contentsTextBox.Text, itemsListBox.SelectedItem.ToString(), foldersListBox.SelectedItem.ToString());
        }

        private void createFolderButton_Click(object sender, EventArgs e)
        {

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
 */
