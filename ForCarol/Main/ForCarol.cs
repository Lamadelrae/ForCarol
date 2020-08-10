using ForCarol.Controller;
using ForCarol.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForCarol
{
    public partial class ForCarol : Form
    {

        private string FilePath = @"ReadMe.txt";

        public ForCarol()
        {
            InitializeComponent();
            VeriFyFileExistence();
        }

        private void VeriFyFileExistence()
        {
            if (File.Exists(FilePath))
            {
                VerifyAnswer.Visible = true;
            }
            else
                VerifyAnswer.Visible = false;
        }

        private void ExecuteVerification()
        {
            try
            {
                var Controller = new MainController();

                var verification = Controller.VerifyRiddleAnswer();

                if (verification == false)
                {
                    MessageBox.Show("Check your answer.");
                }
                else if (verification == true)
                {
                    var frm = new LastBox();

                    frm.ShowDialog();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                MessageBox.Show("Check with your boyfriend what happened");
            }

        }

        private void btnCarol_Click(object sender, EventArgs e)
        {
            var Controller = new MainController();

            Controller.WriteRiddle();
        }

        private void VerifyAnswer_Click(object sender, EventArgs e)
        {
            ExecuteVerification();
        }
    }
}
