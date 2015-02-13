using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Atmosphere.Extensions
{
    public static class IOExtensions
    {
        public static void Clean(this DirectoryInfo dir, bool removeEmptyDirs = true)
        {
            if (dir == null)
            {
                throw new ArgumentNullException("dir");
            }

            dir.Refresh();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(String.Format("Directory does not exist: {0}", dir.FullName));
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo sub in dir.GetDirectories())
            {
                sub.Clean(removeEmptyDirs);

                sub.Delete();
            }
        }

        public static bool AreContentsSame(this FileInfo file1, FileInfo file2)
        {
            if (file1 == null)
                throw new ArgumentNullException("left");
            if (file2 == null)
                throw new ArgumentNullException("right");

            bool same = false;

            if (file1 == file2)
            {
                same = true;
            }
            else if (file1.Length == file2.Length)
            {
                int byte1 = 0;
                int byte2 = 0;

                using (FileStream file1stream = new FileStream(file1.FullName, FileMode.Open, FileAccess.Read))
                using (FileStream file2stream = new FileStream(file2.FullName, FileMode.Open, FileAccess.Read))
                {
                    do
                    {
                        byte1 = file1stream.ReadByte();
                        byte2 = file2stream.ReadByte();
                    }
                    while (byte1 == byte2 && byte1 != -1);
                }

                same = (byte1 - byte2) == 0;
            }    

            return same;
        }
    }
}

