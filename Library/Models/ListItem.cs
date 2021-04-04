using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class ListItem
    {
        public enum Type
        {
            Folder,
            Item
        }

        private string _path;

        private string _name;

        private List<string> _data = new List<string>();

        public Type ListItemType { get; set; }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }


        public string Path
        {
            get { return _path; }
            private set { _path = value; }
        }

        public ListItem(string name, string path)
        {
            SetPath(path);
            SetName(name);
        }

        public void SetPath(string path)
        {
            if (Validator.ValidatePath(path))
            {
                Path = path;
            }
            else
            {
                Logger.LogError("Invalid Path");
            }
        }

        public void SetName(string name)
        {
            if (Validator.ValidateFileName(name))
            {
                Name = name;
            }
            else
            {
                Logger.LogError("Invalid file name");
            }
        }

        public void AddData(string data)
        {
            _data.Add(data);
        }

        public string GetData()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in _data)
            {
                builder.AppendLine(item).ToString();
            }
            return builder.ToString();
        }

    }
}
