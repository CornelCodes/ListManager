
namespace WinFormUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foldersPanel = new System.Windows.Forms.Panel();
            this.foldersPanelLabel = new System.Windows.Forms.Label();
            this.createFolderButton = new System.Windows.Forms.Button();
            this.foldersListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.contentsTextBox = new System.Windows.Forms.TextBox();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.foldersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // foldersPanel
            // 
            this.foldersPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.foldersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foldersPanel.Controls.Add(this.foldersPanelLabel);
            this.foldersPanel.Controls.Add(this.createFolderButton);
            this.foldersPanel.Controls.Add(this.foldersListBox);
            this.foldersPanel.Location = new System.Drawing.Point(13, 13);
            this.foldersPanel.Name = "foldersPanel";
            this.foldersPanel.Size = new System.Drawing.Size(200, 477);
            this.foldersPanel.TabIndex = 0;
            // 
            // foldersPanelLabel
            // 
            this.foldersPanelLabel.AutoSize = true;
            this.foldersPanelLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldersPanelLabel.Location = new System.Drawing.Point(3, 0);
            this.foldersPanelLabel.Name = "foldersPanelLabel";
            this.foldersPanelLabel.Size = new System.Drawing.Size(109, 40);
            this.foldersPanelLabel.TabIndex = 0;
            this.foldersPanelLabel.Text = "Folders";
            // 
            // createFolderButton
            // 
            this.createFolderButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createFolderButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFolderButton.Location = new System.Drawing.Point(2, 438);
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.Size = new System.Drawing.Size(194, 34);
            this.createFolderButton.TabIndex = 1;
            this.createFolderButton.Text = "Create Folder";
            this.createFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createFolderButton.UseVisualStyleBackColor = false;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // foldersListBox
            // 
            this.foldersListBox.FormattingEnabled = true;
            this.foldersListBox.ItemHeight = 30;
            this.foldersListBox.Location = new System.Drawing.Point(3, 57);
            this.foldersListBox.Name = "foldersListBox";
            this.foldersListBox.Size = new System.Drawing.Size(193, 364);
            this.foldersListBox.TabIndex = 0;
            this.foldersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.foldersListBox_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deleteItemButton);
            this.panel1.Controls.Add(this.itemsLabel);
            this.panel1.Controls.Add(this.addItemButton);
            this.panel1.Controls.Add(this.itemsListBox);
            this.panel1.Location = new System.Drawing.Point(219, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 419);
            this.panel1.TabIndex = 2;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteItemButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemButton.Location = new System.Drawing.Point(120, 380);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 34);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteItemButton.UseVisualStyleBackColor = false;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel.Location = new System.Drawing.Point(3, -1);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(87, 40);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(3, 380);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(111, 34);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 30;
            this.itemsListBox.Location = new System.Drawing.Point(2, 59);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(193, 304);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemsListBox_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.contentsTextBox);
            this.panel2.Controls.Add(this.contentsLabel);
            this.panel2.Location = new System.Drawing.Point(425, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 419);
            this.panel2.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(192, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // contentsTextBox
            // 
            this.contentsTextBox.Location = new System.Drawing.Point(3, 59);
            this.contentsTextBox.Multiline = true;
            this.contentsTextBox.Name = "contentsTextBox";
            this.contentsTextBox.Size = new System.Drawing.Size(314, 355);
            this.contentsTextBox.TabIndex = 1;
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentsLabel.Location = new System.Drawing.Point(3, 4);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(131, 40);
            this.contentsLabel.TabIndex = 0;
            this.contentsLabel.Text = "Contents";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(219, 13);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(407, 35);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(632, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 34);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 502);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.foldersPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.foldersPanel.ResumeLayout(false);
            this.foldersPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel foldersPanel;
        private System.Windows.Forms.Label foldersPanelLabel;
        private System.Windows.Forms.Button createFolderButton;
        private System.Windows.Forms.ListBox foldersListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.TextBox contentsTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
    }
}

