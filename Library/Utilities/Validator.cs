using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public static class Validator
    {
        /// <summary>
        /// Validates file name returns true if name is valid
        /// </summary>
        /// <param name="fileName"></param>
        public static bool ValidateFileName(string fileName)
        {
            bool output = false;
            if(fileName != null)
            {
                if(fileName.Length > 3)
                {
                    if (fileName.Length < 100)
                    {
                        output = true;
                    }
                }
            }

            return output;
        }

        /// <summary>
        /// Validates file name returns true if name is valid
        /// </summary>
        /// <param name="path"></param>
        public static bool ValidatePath(string path)
        {
            bool output = false;
            if (path != null)
            {
                output = true;
            }

            return output;
        }
    }
}
