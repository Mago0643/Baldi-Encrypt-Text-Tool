using System;
using System.Globalization;
using System.Media;
using System.Windows.Forms;

namespace BaldiEncryptedText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DECODE
        private void Decode_Text_Changed(object sender, EventArgs e)
        {
            if (Decode_Text.Text == "" | Decode_Text.Text == null)
            {
                Decode_Output.Text = "";
                return;
            }
            // passPhase is always baldi.
            // how did i know? i saw the source code.
            Decode_Output.Text = StringCipher.Decrypt(Decode_Text.Text, "baldi");
        }

        private void Decode_Copy_Click(object sender, EventArgs e)
        {
            if (Decode_Output.Text == null | Decode_Output.Text == "") return;
            Clipboard.SetText(Decode_Output.Text);
        }

        // ENCODE
        private void Encode_TextChanged(object sender, EventArgs e)
        {
            if (Encode_Text.Text == "" | Encode_Text.Text == null)
            {
                Encode_Output.Text = "";
                return;
            }
            // passPhase is always baldi.
            Encode_Output.Text = StringCipher.Encrypt(Encode_Text.Text, "baldi");
        }

        private void Encode_Copy(object sender, EventArgs e)
        {
            if (Encode_Output.Text == null | Encode_Output.Text == "") return;
            Clipboard.SetText(Encode_Output.Text);
        }

        private void Really(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Exclamation.Play();
            string curLang = CultureInfo.CurrentCulture.Name;
            DialogResult result;
            switch (curLang)
            {
                case "ko-KR": // bcuz im korean
                    {
                        result = MessageBox.Show("프로그램을 종료할까요?", "진짜로요?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    }
                default:
                    {
                        result = MessageBox.Show("Close the Program?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    }
            }
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                return;
            }
            e.Cancel = true;
        }
    }
}
