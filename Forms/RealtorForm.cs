using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using RieltorComp.Data.Tables;
using RieltorComp.Models;
using ApplicationContext = RieltorComp.Data.ApplicationContext;

namespace RieltorComp
{
    public partial class RealtorForm : Form
    {
        private readonly string _realtorName;

        private readonly ClientsTable _clientsTable;
        private readonly ServicesTable _servicesTable;
        private readonly PropertiesTable _propertiesTable;
        private readonly ContractsTable _contractsTable;
        private readonly UsersTable _usersTable;
        public RealtorForm(string realtorName)
        {
            _realtorName = realtorName;
            var db = new ApplicationContext();

            _clientsTable = new ClientsTable(db);
            _servicesTable = new ServicesTable(db);
            _propertiesTable = new PropertiesTable(db);
            _contractsTable = new ContractsTable(db);
            _usersTable = new UsersTable(db);
               
            InitializeComponent();

            string[] clientsHeaders = new[]
            {
                @"ФИО клиента",
                @"Паспортные данные клиента"
            };

            CreateDataGrid(clientsDataGrid, 2, clientsHeaders, 566);
            
            string[] servicesHeaders = new[]
            {
                @"Название сервиса"
            };

            CreateDataGrid(servicesDataGrid, 1, servicesHeaders, 565);

            string[] propertiesHeaders = new[]
            {
                @"ФИО собственника",
                @"Паспорт собственника",
                @"Адрес",
                @"Жилая площадь",
                @"Количество комнат"
            };

            CreateDataGrid(propertiesDataGrid, 5, propertiesHeaders, 875);
            
            string[] allContractsHeaders = new[]
            {
                @"ФИО риелтора",
                @"ФИО собственника",
                @"Паспорт собственника",
                @"ФИО клиента",
                @"Паспортные данные клиента",
                @"Адрес недвижимости",
                @"Выполненная услуга",
                @"Цена"
            };

            CreateDataGrid(allContractsDataGrid, 8, allContractsHeaders, 1000);

            UpdateDataGrid();
        }

        private void CreateDataGrid(DataGridView dataGridView, int columnsCount, string[] headers, int dataGridWidth)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnCount = columnsCount;
            for (int i = 0; i < headers.Length; i++)
            {
                dataGridView.Columns[i].HeaderText = headers[i];
                dataGridView.Columns[i].Width = dataGridWidth / columnsCount;
            }
        }
        
        private void UpdateDataGrid()
        {
            var clients = _clientsTable.GetClients();

            clientsDataGrid.Rows.Clear();
            foreach (var client in clients)
            {
                clientsDataGrid.Rows.Add(new[]
                {
                    client.FIO,
                    client.Passport
                });
            }   
            
            var services = _servicesTable.GetServices();

            servicesDataGrid.Rows.Clear();
            foreach (var service in services)
            {
                servicesDataGrid.Rows.Add(new[]
                {
                    service.Service_Name
                });
            }
            
            var properties = _propertiesTable.GetProperties();

            propertiesDataGrid.Rows.Clear();
            foreach (var property in properties)
            {
                propertiesDataGrid.Rows.Add(new[]
                {
                    property.Owner_FIO,
                    property.Owner_Passport,
                    property.Address,
                    property.Living_Area,
                    property.Number_Of_Rooms.ToString()
                });
            }
            
            var contracts = _contractsTable.GetContracts();

            allContractsDataGrid.Rows.Clear();
            foreach (var contract in contracts)
            {
                var client = _clientsTable.GetClientById(contract.Client.Id);
                var property = _propertiesTable.GetPropertyById(contract.Property.Id);
                var user = _usersTable.GetUser(_realtorName);
                var service = _servicesTable.GetService(contract.Service_Done.Service_Name);
                
                allContractsDataGrid.Rows.Add(new[]
                {
                    user.Username,
                    property.Owner_FIO,
                    property.Owner_Passport,
                    client.FIO,
                    client.Passport,
                    property.Address,
                    service.Service_Name,
                    contract.Service_Price.ToString()
                });
            }
        }

        private void addClientToContractButton_Click(object sender, EventArgs e)
        {
            var selectedRows = clientsDataGrid.SelectedRows;

            if (selectedRows.Count > 0)
            {
                clientTB.Text = selectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void addServiceToContractButton_Click(object sender, EventArgs e)
        {
            var selectedRows = servicesDataGrid.SelectedRows;

            if (selectedRows.Count > 0)
            {
                serviceTB.Text = selectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void addPropertyToContractButton_Click(object sender, EventArgs e)
        {
            var selectedRows = propertiesDataGrid.SelectedRows;

            if (selectedRows.Count > 0)
            {
                propertyTB.Text = selectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void createContractButton_Click(object sender, EventArgs e)
        {
            if (clientTB.Text == "" || serviceTB.Text == "" || propertyTB.Text == "")
            {
                MessageBox.Show(@"Заполните все поля");
                return;
            }

            var property = _propertiesTable.GetProperty(propertyTB.Text);
            var client = _clientsTable.GetClient(clientTB.Text);
            if (client.Passport == property.Owner_Passport)
            {
                MessageBox.Show("Клиент не может быть владельцем");
                return;
            }
            switch (serviceTB.Text)
            {
                case @"Аренда недвижимости":
                    Hide();
                    new RentForm(property.Owner_FIO, property.Owner_Passport, 
                        clientTB.Text, client.Passport, propertyTB.Text, _realtorName).ShowDialog();
                    Close();
                    break;
                case @"Ипотека":
                    Hide();
                    new LoanForm(property.Owner_FIO, property.Owner_Passport, 
                        clientTB.Text, client.Passport, propertyTB.Text, _realtorName).ShowDialog();
                    Close();
                    break;
                case @"Купля/Продажа":
                    Hide();
                    new SellForm(property.Owner_FIO, property.Owner_Passport, 
                        clientTB.Text, client.Passport, propertyTB.Text, _realtorName).ShowDialog();
                    Close();
                    break;
            }
        }

        private void addNewClientButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddNewClientForm(_realtorName).ShowDialog();
            Close();
        }

        private void addNewPropertyButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddNewPropertyForm(_realtorName).ShowDialog();
            Close();
        }

        private void printContractButton_Click(object sender, EventArgs e)
        {
            var selectedRows = allContractsDataGrid.SelectedRows;
            var contract = new Contracts();

            if (selectedRows.Count > 0)
            {
                contract = _contractsTable.GetContract(selectedRows[0].Cells[5].Value.ToString());
            }
            Rectangle r = new Rectangle(400, 700);

            Document doc = new Document(r);
            
            EncodingProvider ppp = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);
            
            PdfWriter.GetInstance(doc, new FileStream(@"Договор.pdf", FileMode.Create));
            doc.Open();
            
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            var client = _clientsTable.GetClientById(contract.Client.Id);
            var property = _propertiesTable.GetPropertyById(contract.Property.Id);
            
            Chunk c1 = new Chunk(@"ДОГОВОР");
            Chunk c2 = new Chunk(Chunk.NEWLINE + @"Г-н/жа " + client.FIO + @" паспорт "
                                 + client.Passport + @", с одной Стороны, и Г-н/жа " 
                                 + property.Owner_FIO + @" паспорт " + property.Owner_Passport
                                 + @", с другой Стороны заключили настоящий договор о нижеследующем");
            Chunk c3 = new Chunk(Chunk.NEWLINE + @"1. Предмет Договора");
            Chunk c4 = new Chunk(Chunk.NEWLINE + @"Указанное помещение находится по адресу: " +
                                 property.Address + @", здесь и далее именуемая Квартира");
            Chunk c5 = new Chunk(Chunk.NEWLINE + @"Квартира имеет следующие характеристики:");


            Chunk c6 = new Chunk(Chunk.NEWLINE + @"жилая площадь: " + property.Living_Area);
            Chunk c7 = new Chunk(Chunk.NEWLINE + @"количество комнат " + property.Number_Of_Rooms);
            Chunk c8 = new Chunk(Chunk.NEWLINE + @"2. Условия Оплаты");
            Chunk c9 = new Chunk(Chunk.NEWLINE + @"Стоимость помещения составляет: " + contract.Service_Price);
            Chunk c10 = new Chunk(Chunk.NEWLINE + @"Срок окончательного погашения кредита устанавливается - " + contract.Service_Period);
            Chunk c11 = new Chunk(Chunk.NEWLINE + @"Кредитная ставка составляет " + contract.Service_Persent);
            Chunk c12 = new Chunk(Chunk.NEWLINE + @"Дата: " + contract.Service_Date);
            Chunk c13 = new Chunk(Chunk.NEWLINE + @"Подпись: ");

            Phrase p1 = new Phrase();
            p1.Add(c1);
            p1.Add(c2);
            p1.Add(c3);
            p1.Add(c4);
            p1.Add(c5);
            p1.Add(c6);
            p1.Add(c7);
            p1.Add(c8);
            p1.Add(c9);
            p1.Add(c10);
            p1.Add(c11);
            p1.Add(c12);
            p1.Add(c13);

            Paragraph par1 = new Paragraph(p1.Content, font);

            doc.Add(par1);
            
            doc.Close();
            
            MessageBox.Show(@"Договор создан");
        }
    }
}