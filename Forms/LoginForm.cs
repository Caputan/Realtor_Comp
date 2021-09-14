using System;
using System.Windows.Forms;
using RieltorComp.Data.Tables;
using ApplicationContext = RieltorComp.Data.ApplicationContext;


namespace RieltorComp
{
    public partial class LoginForm : Form
    {
        private readonly ApplicationContext _db = new();
        private readonly UsersTable _usersTable;
        public LoginForm()
        {
            _usersTable = new UsersTable(_db);
            InitializeComponent();
        }


        private void signInButton_Click(object sender, EventArgs e)
        {
            var login = loginTB.Text;
            var password = passwordTB.Text;

            var user = _usersTable.GetUser(login);
            if(user == null || user.Password != password)
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }

            switch (user.Role)
            {
                case "rieltor":
                    new RealtorForm(user.Username).ShowDialog();
                    break;
                case "admin":
                    new AdminForm().ShowDialog();
                    break;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}