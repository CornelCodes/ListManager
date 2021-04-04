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
        /// <summary>
        /// Used to safely invoke a controls properties on the form from another thread
        /// </summary>
        SafeInvoke _safeInvoker = new SafeInvoke();

        public Dashboard()
        {
            InitializeComponent();
            //Add continous loop to UpdateDisplay on another thread and not locking the UI
            UpdateDisplay();
        }

        /// <summary>
        /// Updates the display with the folders
        /// </summary>
        public void UpdateDisplay()
        {
            //Gets the folders and items in the root to display in the list boxes
            SetFolders();
            SetItemsOnDisplay();
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

        private void SetItemsOnDisplay()
        {
            SetListBox(DataAccess.GetSubDirectoryNames(foldersListBox.SelectedItem.ToString()), itemsListBox);
        }

        private void SetContent()
        {
            contentsTextBox.Text = DataAccess.GetContentFromFile(itemsListBox.SelectedItem.ToString(), foldersListBox.SelectedItem.ToString());
        }

        private void foldersListBox_MouseDown(object sender, MouseEventArgs e)
        {
            SetItemsOnDisplay();
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
            Form createFolderForm = new CreateFolder();
            this.Enabled = false;
            createFolderForm.Enabled = true;
            createFolderForm.Show();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Form addItemForm = new CreateFolder();
            this.Enabled = false;
            addItemForm.Enabled = true;
            addItemForm.Text = "Add Item";
            addItemForm.Show();
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
