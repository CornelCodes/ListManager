using Library.Data;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Contains all the methods which set and provide data
    /// </summary>
    public static class DataAccess
    {
        /// <summary>
        /// Folders and files stored in arrays
        /// </summary>
        static string[] directories;
        static string[] subDirectories;
        static string[] files;

        static DataManager dataManager = new DataManager();

        /// <summary>
        /// Gets the directory names without extensions which go to the form
        /// </summary>
        /// <returns>string array of file names</returns>
        public static string[] GetDirectoryNames()
        {
            GetDirectories();
            string[] output = new string[directories.Length];

            for (int i = 0; i < directories.Length; i++)
            {
                output[i] = Path.GetFileNameWithoutExtension(directories[i]);
            }

            return output;
        }


        /// <summary>
        /// Gets the sub directory names without extensions which go to the form
        /// </summary>
        /// <returns>string array of file names</returns>
        public static string[] GetSubDirectoryNames(string selectedFile)
        {
            GetSubDirectoriesFrom(selectedFile);
            string[] output = new string[subDirectories.Length];
            for (int i = 0; i < subDirectories.Length; i++)
            {
                output[i] = Path.GetFileNameWithoutExtension(subDirectories[i]);
            }

            return output;
        }

        /// <summary>
        /// Stores all the directories in the main path
        /// </summary>
        private static void GetDirectories(string fileName = "")
        {
            directories = Directory.GetDirectories(Startup.ContentsPath);
            Logger.LogNormal($"Getting directories from {Startup.ContentsPath}");
        }
        
        /// <summary>
        /// Stores all the sub directories in selected main path
        /// </summary>
        /// <param name="fileName">Selected file name</param>
        private static void GetSubDirectoriesFrom(string fileName)
        {
            subDirectories = Directory.GetDirectories($@"{Startup.ContentsPath}\{fileName}");
            Logger.LogNormal($@"Getting sub directories from {Startup.ContentsPath}\{fileName}");
        }

        private static void GetItemsFrom(string fileName)
        {
            files = Directory.GetFiles($@"{Startup.ContentsPath}\{fileName}");
            Logger.LogNormal($@"Getting sub directories from {Startup.ContentsPath}\{fileName}");
        }

        //Gets the user friendly file names to display in the ListBox
        public static string[] GetItemNames(string selectedFile = "")
        {
            GetItemsFrom(selectedFile);
            string[] output = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                output[i] = Path.GetFileNameWithoutExtension(files[i]);
            }

            return output;
        }

        public static string GetContentFromFile(string fileName, string parentDirectory)
        {
            bool fileLocked = false;    
            string[] fileText = null;
            string output = "";
            string path = $@"{Startup.ContentsPath}\{parentDirectory}\{fileName}\{fileName}.txt";
            if (File.Exists(path))
            {
                bool isLocked = true;
                while (isLocked)
                {
                    try
                    {
                        fileText = File.ReadAllLines(path);
                        isLocked = false;
                    }
                    catch (Exception)
                    {
                        isLocked = true;
                    }
                }
            }
            else
            {
                //If text file doesnt exist create it
                File.Create(path);
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        fileText = File.ReadAllLines(path);
                        fileLocked = false;
                        break;
                    }
                    catch (IOException)
                    {
                        fileLocked = true;
                        Logger.LogWarning("Cant access file while in use");
                    }
                }
            }
            //Convert string array to string
            if(fileLocked == false)
            {
                foreach (string line in fileText)
                {
                    output += $"{line}\r\n";
                }
            }

            return output;
        }

        public static void SaveContentToFile(string content, string fileName, string parentDirectory)
        {
            bool isLocked = true;
            while (isLocked)
            {
                try
                {
                    File.WriteAllText($@"{Startup.ContentsPath}\{parentDirectory}\{fileName}\{fileName}.txt", content);
                    isLocked = false;
                }
                catch (Exception)
                {
                    isLocked = true;
                }
            }
        }

        /// <summary>
        /// Creates a directory with the given folderName and validates the folders
        /// </summary>
        /// <param name="folderName"></param>
        public static void CreateFolder(string folderName)
        {
            //Check if folder with same name exists
            if (Directory.Exists($@"{Startup.ContentsPath}\{folderName}"))
            {
                Logger.LogWarning($@"Folder: {folderName} already exist in {Startup.ContentsPath}");
            }
            else
            {

                Logger.LogNormal($"Creating folder {folderName}");
            }

        }

        public static void AddItem(string itemName)
        {
            dataManager.CreateItem(itemName, Models.ListItem.Type.Item);
        }
        
    }
}
