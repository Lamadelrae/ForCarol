using ForCarol.Core.Constants;
using System;
using System.Windows.Forms;

namespace ForCarol.Main
{
    public partial class LastBox : Form
    {
        public LastBox()
            => InitializeComponent();

        private void LastBox_Load(object sender, EventArgs e)
            => TextBox.Text = Messages.FinalMessage;

        private void pictureBox2_Click(object sender, EventArgs e) { }
    }
}