using System;
using System.Windows.Forms;
using RieltorComp.Data.Tables;
using RieltorComp.Models;
using ApplicationContext = RieltorComp.Data.ApplicationContext;

namespace RieltorComp
{
    public partial class RentForm : Form
    {
        private readonly string _realtorName;
        private readonly string _ownerName;
        private readonly string _ownerPassport;
        private readonly string _clientName;
        private readonly string _propertyAddress;

        private readonly ContractsTable _contractsTable;
        private readonly ClientsTable _clientsTable;
        private readonly PropertiesTable _propertiesTable;
        private readonly UsersTable _usersTable;
        private readonly ServicesTable _servicesTable;
        
        public RentForm(string ownerName, string ownerPassport, string clientName, 
            string clientPassport, string propertyAddress, string realtorName)
        {
            var db = new ApplicationContext();
            _contractsTable = new ContractsTable(db);
            _clientsTable = new ClientsTable(db);
            _propertiesTable = new PropertiesTable(db);
            _usersTable = new UsersTable(db);
            _servicesTable = new ServicesTable(db);
            
            _realtorName = realtorName;
            _ownerName = ownerName;
            _ownerPassport = ownerPassport;
            _clientName = clientName;
            _propertyAddress = propertyAddress;
            
            InitializeComponent();

            clientTB.Text = _clientName;
            passportTB.Text = clientPassport.ToString();
            adressTB.Text = _propertyAddress;
        }

        private void createRentButton_Click(object sender, EventArgs e)
        {
            if (rentPriceTB.Text == "" || rentPeriodTB.Text == "")
            {
                MessageBox.Show(@"Заполните все поля");
            }
            else
            {
                var client = _clientsTable.GetClient(_clientName);
                var property = _propertiesTable.GetProperty(_propertyAddress);
                var user = _usersTable.GetUser(_realtorName);
                var service = _servicesTable.GetService("Аренда недвижимости");
                
                Contracts newContract = new Contracts()
                {
                    Realtor = user,
                    Property = property,
                    Client = client,
                    Service_Done = service,
                    Service_Date = DateTime.Now.ToString("dd/MM/yyyy"),
                    Service_Price = double.Parse(rentPriceTB.Text),
                    Service_Period = rentPeriodTB.Text
                };
                _contractsTable.CreateContract(newContract);
                
                Hide();
                new RealtorForm(_realtorName).ShowDialog();
                Close();
            }
        }
        
        private void cancelRentButton_Click(object sender, EventArgs e)
        {
            Hide();
            new RealtorForm(_realtorName).ShowDialog();
            Close();
        }
    }
}