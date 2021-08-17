using ForCarol.Controller;
using ForCarol.Core.Constants;
using ForCarol.Main;
using System;
using System.IO;
using System.Windows.Forms;

namespace ForCarol
{
    public partial class ForCarol : Form
    {
        public ForCarol()
        {
            InitializeComponent();
            VeriFyFileExistence();
        }

        private void btnCarol_Click(object sender, EventArgs e)
            => MessageBox.Show(new MainController().WriteRiddle());

        private void VerifyAnswer_Click(object sender, EventArgs e)
            => ExecuteVerification();

        private void VeriFyFileExistence()
            => VerifyAnswer.Visible = File.Exists(Paths.FilePath);

        private void ExecuteVerification()
        {
            try
            {
                if (new MainController().VerifyRiddleAnswer())
                    new LastBox().ShowDialog();
                else
                    MessageBox.Show("Check your answer.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                MessageBox.Show("Check with your boyfriend what happened");
            }
        }
    }
}
