using ForCarol.Core.Constants;
using ForCarol.Core.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ForCarol.Controller
{
    public class MainController
    {
        public string WriteRiddle()
        {
            if (!File.Exists(Paths.FilePath))
            {
                FileService.WriteToFile(new List<string>
                {
                    Messages.Instructions,
                    " ",
                    Messages.Riddle
                }); 

                return Messages.CheckTheProgramsFolder;
            }
            else
                return Messages.FileAlreadyExists;
        }

        public bool VerifyRiddleAnswer()
        {
            List<string> riddleText = FileService.GetFileContents();

            return riddleText[3].ToString() == "love" ||
                   riddleText[3].ToString() == "Love" ||
                   riddleText[3].ToString() == "Love.";
        }
    }
}