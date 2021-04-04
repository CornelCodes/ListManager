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
    public partial class CreateFolder : Form
    {
        public delegate void CloseEvent();
        public CloseEvent WindowClosed;
        Dashboard _parentForm;
        ListBox _folderListBox;

        public CreateFolder()
        {
            _parentForm = (Dashboard)Application.OpenForms["Dashboard"];
            InitializeComponent();
        }

        private void createFolderButton_Click(object sender, EventArgs e)
        {
            switch (this.Text.ToLower())
            {
                case "create folder":
                    DataAccess.CreateFolder(folderNameTextBox.Text);
                    break;
                case "add item":
                    DataAccess.AddItem(folderNameTextBox.Text);
                    break;
            }
            //Call update method on Dashboard
            _parentForm.UpdateDisplay();
            _parentForm.Enabled = true;
            _parentForm.Focus();
            this.Close();
        }

    }
}
