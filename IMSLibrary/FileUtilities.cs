using System;
using System.Drawing;

namespace IMSLibrary
{
    public static class FileUtilities
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
                return false;
            }
            return true;
        }

    }
}
