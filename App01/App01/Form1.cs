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
                    
                }
            }

            if (loginFlag)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Visible = true;
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

        private void txtUsernameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}