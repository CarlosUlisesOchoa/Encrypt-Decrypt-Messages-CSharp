using System;
using System.Windows.Forms;

namespace Encrypt_and_Decrypt_with_pass__UI_
{
    public partial class Encrypter : Form
    {

        private const double version = 1.2;

        ToolTip tt = new ToolTip();

        Timer timer1 = new Timer();

        public Encrypter()
        {
            InitializeComponent();
            setPasswordState(true);
            this.Text = "Encrypter v"+version;

            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Interval = 3000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            about();
            timer1.Stop();
            timer1.Enabled = false;
        }

        private string checkInputs()
        {
            if (txtInput.Text.Length == 0)      return "input";
            if (txtPassword.Text.Length == 0)   return "password";
            return "fine";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string check = checkInputs();
            switch (check)
            {
                case "fine":
                {
                    if (radBtnEncrypt.Checked)
                    {
                        txtOutput.Text = Crypt.Encrypt(txtInput.Text, txtPassword.Text);
                        MessageBox.Show(null, "Encrypted! please remember that you shall save you key too or you'll not be able to decrypt", "Encrypter - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (radBtnDecrypt.Checked)
                    {
                        txtOutput.Text = Crypt.Decrypt(txtInput.Text, txtPassword.Text);
                    }
                    break;
                }
                case "input": { goto default; }
                case "password":
                {
                    if (radBtnEncrypt.Checked)
                    {
                        txtPassword.Text = genRandomKey();
                        setPasswordState(false);
                        goto case "fine";
                    }
                    goto default;
                }
                default:
                {
                    MessageBox.Show(null, String.Format("Please check if {0} field is filled", check), "Encrypter - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            
            }
        }

        private static string genRandomKey()
        { // 93 - 122
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] key = new char[6];
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = chars[randomEx(0, chars.Length)];
            }
            String finalKey = new string(key);
            return finalKey;
        }

        private void lblClean_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtOutput.Text = String.Empty;
            radBtnEncrypt.Checked = true;
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblCharCountIn.Text = txtInput.TextLength.ToString();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            lblCharCountOut.Text = txtOutput.TextLength.ToString();
        }

        private void txtOutput_Click(object sender, EventArgs e)
        {
            txtOutput.SelectAll();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            bool ctrlV = (e.Modifiers == Keys.Control && e.KeyCode == Keys.V);
            bool shiftIns = (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert);

            if ((ctrlV || shiftIns))
            {
                if (Clipboard.GetText().ToString().Length == 128)
                {
                    radBtnDecrypt.Checked = true;
                    txtPassword.Focus();
                }
            }
        }

        private void picBoxExchange_Click(object sender, EventArgs e)
        {
            if (txtInput.TextLength == 0 || txtOutput.TextLength == 0) return;
            String aux = txtInput.Text;
            txtInput.Text = txtOutput.Text;
            txtOutput.Text = aux;
        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int randomEx(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void picBox_Eye_On_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar.Equals('•'))   setPasswordState(false);
            else                                        setPasswordState(true);
        }

        private void setPasswordState(Boolean state)
        {
            if (state)
            {
                txtPassword.PasswordChar = '•';
                picBox_Eye.Image = Properties.Resources.eye_on;
                tt.SetToolTip(picBox_Eye, "Show password");
                txtPassword.BackColor = System.Drawing.SystemColors.ControlLight;

            }
            else
            {
                txtPassword.PasswordChar = '\0';
                picBox_Eye.Image = Properties.Resources.eye_off;
                tt.SetToolTip(picBox_Eye, "Hide password");
                txtPassword.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void aboutThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about();
        }

        private void about()
        {
            AcercaDe vA = new AcercaDe();
            vA.StartPosition = FormStartPosition.CenterScreen;
            vA.Visible = true;
        }
    }
}
