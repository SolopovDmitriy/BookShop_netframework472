using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_netframework472
{
    public partial class RegistrationForm : Form
    {
        public Model1Container database;

        public RegistrationForm(Model1Container database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
               
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if(database.UserSet.Any(u => u.Login.Equals(textBoxLogin.Text)))//определяет существует хотя-бы один user с таким логином
            {
                MessageBox.Show("This login is exists");
                return;
            }


            User user = new User
            {
                Login = textBoxLogin.Text,
                Password = Helper.CreateMD5(textBoxPassword.Text)
            };
            database.UserSet.Add(user);
            database.SaveChanges();            
            this.Close();
        }
    }
}
