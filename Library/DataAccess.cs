using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class DataAccess
    {
        static string[] directories;
        static string[] subDirectories;

        public static string[] GetDirectoryNames()
        {
            GetDirectories();
            string[] output = new string[directories.Length];

            for(int i = 0; i < directories.Length; i++)
            {
                output[i] = Path.GetFileNameWithoutExtension(directories[i]);
            }

            return output;
        }

        public static string[] GetSubDirectoryNames(string fileName)
        {
            GetSubDirectories(fileName);
            string[] output = new string[subDirectories.Length];

            for (int i = 0; i < subDirectories.Length; i++)
            {
                output[i] = Path.GetFileNameWithoutExtension(subDirectories[i]);
            }

            return output;
        }

        private static void GetDirectories()
        {
            directories = Directory.GetDirectories(StartupValidator.ContentsPath);
        }
        
        private static void GetSubDirectories(string fileName)
        {
            subDirectories = Directory.GetDirectories($@"{StartupValidator.ContentsPath}\{fileName}");
        }


    }
}
