using System;
using System.Windows.Forms;
using RieltorComp.Data.Tables;
using RieltorComp.Models;
using ApplicationContext = RieltorComp.Data.ApplicationContext;

namespace RieltorComp
{
    public partial class AddNewPropertyForm : Form
    {
        private readonly string _realtorName;

        private readonly string _ownerName = "";
        private readonly string _ownerPassport = "";
        private readonly string _address = "";
        private readonly string _area = "";
        private readonly string _roomNum = "";

        private readonly PropertiesTable _propertiesTable;
        private readonly ClientsTable _clientsTable;

        public AddNewPropertyForm(string realtorName)
        {
            var db = new ApplicationContext();
            _propertiesTable = new PropertiesTable(db);
            _clientsTable = new ClientsTable(db);

            _realtorName = realtorName;

            InitializeComponent();
        }
        
        private void createPropertyButton_Click(object sender, EventArgs e)
        {
            if (adressTB.Text == "" || areaTB.Text == "" || roomNumTB.Text == "" || ownerNameTB.Text == ""
                || ownerPassportTB.Text == "")
            {
                MessageBox.Show(@"Заполните все поля");
                return;
            }
            
            var property = _propertiesTable.GetProperty(adressTB.Text);
            if (property!= null)
            {
                MessageBox.Show("Такой адрес уже существует");
                return;
            }
           
            Properties newProperty = new Properties()
            {
                Owner_FIO = ownerNameTB.Text,
                Owner_Passport = ownerPassportTB.Text,
                Address = adressTB.Text,
                Living_Area = areaTB.Text,
                Number_Of_Rooms = int.Parse(roomNumTB.Text)
            };
            _propertiesTable.CreateProperty(newProperty);
        
            Hide();
            new RealtorForm(_realtorName).ShowDialog();
            Close();
            
                
            
        }

        private void cancelPropertyButton_Click(object sender, EventArgs e)
        {
            Hide();
            new RealtorForm(_realtorName).ShowDialog();
            Close();
        }


        private void AddNewPropertyForm_Shown(object sender, EventArgs e)
        {
            ownerNameTB.Text = _ownerName;
            ownerPassportTB.Text = _ownerPassport;
            adressTB.Text = _address;
            areaTB.Text = _area;
            roomNumTB.Text = _roomNum;
        }
    }
}