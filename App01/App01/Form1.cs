namespace App01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var defaultUsernames = new[] { "admin", "user" };
            var defaultPasswds = new[] { "admin", "user" };
            bool loginFlag = false;

            for (int i = 0; i < defaultUsernames.Length; i++){
                if ((defaultUsernames[i] == txtUsernameEntry.Text) && (defaultPasswds[i] == txtPasswordEntry.Text)) {
                    loginFlag = true;
                    break;
                }
            }

            if (loginFlag)
            {
                // ---------- This part will lead to the main menu part --------------------
            }

            else
                System.Windows.Forms.MessageBox.Show("Invalid username or password, please try again!", "TRY AGAIN", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}