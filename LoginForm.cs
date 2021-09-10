using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_netframework472
{
    public partial class LoginForm : Form
    {
        public MainForm mainForm;

        public LoginForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string encryptedPassword = Helper.CreateMD5(textBoxPassword.Text);
            mainForm.CurrentUser = mainForm.database.UserSet
                .Where(user =>
                    user.Login.Equals(textBoxLogin.Text) &&
                    user.Password.Equals(encryptedPassword)
                 )
                .SingleOrDefault();
            mainForm.UpdateCurrentUser();
            this.Close();
        }
    }
}
