using System;
using System.Windows.Forms;
using RieltorComp.Data.Tables;
using RieltorComp.Models;
using ApplicationContext = RieltorComp.Data.ApplicationContext;

namespace RieltorComp
{
    public partial class AddNewClientForm : Form
    {
        private readonly string _realtorName;
        private readonly string _clientName = "";
        private readonly string _clientPassport = "";

        private readonly ClientsTable _clientsTable;
        public AddNewClientForm(string realtorName)
        {
            var db = new ApplicationContext();
            _clientsTable = new ClientsTable(db);
            
            _realtorName = realtorName;

            InitializeComponent();
        }

        private void createSellButton_Click(object sender, EventArgs e)
        {
            if (clientTB.Text == "" || passportTB.Text == "")
            {
                MessageBox.Show(@"Заполните все поля");
            } 
            else
            {
                var clientByPassport = _clientsTable.GetClientByPassport(passportTB.Text);
                if (clientByPassport != null)
                {
                    MessageBox.Show("Клиент с таким паспортом уже существует");
                    return;
                }

                if (passportTB.Text.Length < 10)
                {
                    MessageBox.Show("Неправильно введены паспортные данные");
                    return;
                }

                Clients newClient = new Clients()
                {
                    FIO = clientTB.Text,
                    Passport = passportTB.Text
                };
                _clientsTable.CreateClient(newClient);

                Hide();
                new RealtorForm(_realtorName).ShowDialog();
                Close();
            }
        }
        
        private void cancelSellButton_Click(object sender, EventArgs e)
        {
            Hide();
            new RealtorForm(_realtorName).ShowDialog();
            Close();
        }


        private void AddNewClientForm_Shown(object sender, EventArgs e)
        {
            clientTB.Text = _clientName;
            passportTB.Text = _clientPassport;
        }
    }
}