using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCarol.Controller
{
    public class MainController
    {
        private string FilePath = @"ReadMe.txt";

        public void WriteRiddle()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    using (StreamWriter sw = File.CreateText(FilePath))
                    {
                        sw.WriteLine("Hey you! I see you've come acrross this Text File, I want you to write the answer to the riddle below the riddle. After the answer is submitted in here, re-open the program.");
                        sw.WriteLine(" ");
                        sw.WriteLine("What costs nothing but is worth everything, weighs nothing but lasts a lifetime, that one person can't own but two can share?");
                    }

                    MessageBox.Show("Check the Program's folder and find out for yourself.");
                }
                else
                    MessageBox.Show("The file already exists.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Uh oh, something happened, please ask your boyfriend to take a look");
                MessageBox.Show(exc.ToString());
            }
        }
        public bool VerifyRiddleAnswer()
        {
            try
            {
                //Making a list of the text file
                List<string> RiddleTxt = new List<string>();

                string RiddleLine = "";

                using (Stream file = File.Open(FilePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while ((RiddleLine = sr.ReadLine()) != null)
                        {
                            RiddleTxt.Add(RiddleLine);
                        }
                        sr.Close();
                    }
                    file.Close();
                }

                //Actual Verification
                if (RiddleTxt[3].ToString() == "love" || RiddleTxt[3].ToString() == "Love" || RiddleTxt[3].ToString() == "Love.")
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception exc)
            {
                return false;
            }
        }
    }
}
