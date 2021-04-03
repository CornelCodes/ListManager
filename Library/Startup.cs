using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Startup
    {
        /// <summary>
        /// Setting default paths and getting current pc username 
        /// </summary>
        private static string systemUserName = Environment.UserName;
        private static string folderPath = $@"C:\Users\{systemUserName}";
        private static string[] filePaths = Directory.GetDirectories(folderPath);

        public static string ContentsPath { get; private set; } = $@"{folderPath}\ListManager";

        /// <summary>
        /// Run at start to create neccessary data and folders
        /// </summary>
        public static void Initialize()
        {
            bool fileExists = FolderExists(folderPath, filePaths);

            if(fileExists == false)
            {
                Directory.CreateDirectory($@"{folderPath}\ListManager");
            }
        }

        /// <summary>
        /// Creates directory if path does not exist
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="filePaths"></param>
        /// <returns></returns>
        private static bool FolderExists(string folderPath, string[] filePaths)
        {
            bool output = false; ;

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
