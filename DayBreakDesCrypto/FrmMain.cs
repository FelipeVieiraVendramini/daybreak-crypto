using System.Security.Cryptography;
using System.Text;

namespace DayBreakDesCrypto
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            TxtEncodedText.Text = DesHelper.Encrypt(TxtPlainText.Text);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            TxtPlainText.Text = DesHelper.Decrypt(TxtEncodedText.Text);
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            string password = TxtPassword.Text;
            TxtPasswordMD5.Text = MD5Util.MD5(username + password, Encoding.UTF8);
        }
    }
}