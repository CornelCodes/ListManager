using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class StartupValidator
    {
        private static string systemUserName = Environment.UserName;
        private static string folderPath = $@"C:\Users\{systemUserName}";
        private static string[] filePaths = Directory.GetDirectories(folderPath);

        public static string ContentsPath { get; private set; } = $@"{folderPath}\ListManager";

        public static void Initialize()
        {
            bool fileExists = FolderExists(folderPath, filePaths);

            if(fileExists == false)
            {
                Directory.CreateDirectory($@"{folderPath}\ListManager");
            }
        }

        private static bool FolderExists(string folderPath, string[] filePaths)
        {
            bool output = false; ;
            //Check if folder exists on pc
            foreach (string folder in filePaths)
            {
                if (folder == $@"{folderPath}\ListManager")
                {
                    output = true;
                    break;
                }
                else
                {
                    output = false;
                }
            }

            return output;
        }
    }
}
