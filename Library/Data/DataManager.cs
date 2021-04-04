using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class DataManager
    {
        string defaultFilePath = $@"{Startup.ContentsPath}\TempData";
        public List<ListItem> folders;
        public List<ListItem> items;

        public DataManager()
        {
            folders = new List<ListItem>();
            items = new List<ListItem>();
        }

        /// <summary>
        /// Store data in a text file
        /// </summary>
        private void StoreData(ListItem listItem)
        {
            //Creates the temp data folder if it does not exist
            if (Directory.Exists(defaultFilePath) == false)
            {
                Directory.CreateDirectory(defaultFilePath);
            }

            //Creates the text file if it does not exist
            if (File.Exists($@"{defaultFilePath}\{listItem.Name}.txt"))
            {
                File.AppendAllText($@"{defaultFilePath}\{listItem.Name}.txt", listItem.GetData());
            }
            else
            {
                switch (listItem.ListItemType)
                {
                    case ListItem.Type.Folder:
                        folders.Add(listItem);
                        break;

                    case ListItem.Type.Item:
                        items.Add(listItem);
                        break;
                }

                File.WriteAllText($@"{defaultFilePath}\{listItem.Name}.txt", $"ListManager TempData:\r\n{listItem.GetData()}");
            }
        }

        public void CreateItem(string itemName ,ListItem.Type type)
        {
            string path = "";
            switch (type)
            {
                case ListItem.Type.Folder:
                    path = $@"{Startup.ContentsPath}\{itemName}";
                    break;

                case ListItem.Type.Item:
                    path = $@"{Startup.ContentsPath}";
                    break;
            }
            ListItem item = new ListItem(itemName, path);
            item.ListItemType = type;
            StoreData(item);
        }

    }
}
