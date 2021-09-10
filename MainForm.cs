using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// https://docs.microsoft.com/en-us/ef/ef6/fundamentals/databinding/winforms

namespace BookShop_netframework472
{
    public partial class MainForm : Form
    {
        public Model1Container database;
        public User CurrentUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
            database = new Model1Container();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(CurrentUser == null)
            {
                return;
            }

        }
               
            

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudBooksForm crudBooksForm = new CrudBooksForm(database);// создаем форму crudBooksForm
            crudBooksForm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e) // создаем форму registrationForm
        {
            RegistrationForm registrationForm = new RegistrationForm(database);
            registrationForm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) // создаем форму loginForm
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        public void UpdateCurrentUser()// показываем на форме пользователя, который зарегистрировался
        {
            this.Text = CurrentUser?.Login;//this.Text  ( this - главная форма, Text - шапка формы - Max 3 ),
                                           //CurrentUser - текущий зарегистрированній пользователь, CurrentUser?.Login -если user не зарегистрировался,
                                           //CurrentUser равен null, чтобы не было ошибки, когда null вызывает login
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)//форма для покупок
        {
            BuyBookForm buyBookForm = new BuyBookForm(this);
            buyBookForm.ShowDialog();
        }
    }
}
