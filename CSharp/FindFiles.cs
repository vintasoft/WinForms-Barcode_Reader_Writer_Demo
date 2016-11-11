using System.Collections.Generic;
using System.IO;

namespace BarcodeDemo
{
    internal class FindFiles
    {

        public static string[] GRAPHIC_FILES = new string[] {
            "*.bmp", "*.jpg", "*.jpeg", "*.jpe", "*.jfif", "*.tif", "*.tiff",
            "*.png", "*.gif", "*.wmf", "*.emf", "*.pdf"
        };



        public static string[] Find(string path, string[] masks)
        {
            List<string> result = new List<string>();
            foreach (string mask in masks)
            {
                string[] filenames = Directory.GetFiles(path, mask);
                foreach (string filename in filenames)
                {
                    string lowerFilename = filename.ToLower();
                    if (!result.Contains(lowerFilename))
                        result.Add(lowerFilename);
                }
            }
            result.Sort();
            return result.ToArray();
        }

    }
}
