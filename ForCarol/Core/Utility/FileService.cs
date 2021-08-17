using ForCarol.Core.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForCarol.Core.Utility
{
    public static class FileService
    {
        public static void WriteToFile(string message)
            => File.WriteAllText(Paths.FilePath, message);

        public static void WriteToFile(List<string> messages)
            => messages.ForEach(i => File.WriteAllText(Paths.FilePath, i));

        public static List<string> GetFileContents()
            => File.ReadAllLines(Paths.FilePath).ToList();
    }
}
