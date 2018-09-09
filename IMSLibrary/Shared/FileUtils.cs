using System;
using System.Drawing;

namespace IMSLibrary
{
    public static class FileUtils
    {
        public static bool IsValidImage(string filename)
        {
            try
            {
                using (Image newImg = Image.FromFile(filename))
                { }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
    }
}
