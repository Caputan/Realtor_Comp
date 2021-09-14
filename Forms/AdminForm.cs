using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using RieltorComp.Data.Tables;
using RieltorComp.Models;
using ApplicationContext = RieltorComp.Data.ApplicationContext;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.ApplicationServices;
using Font = iTextSharp.text.Font;
using Rectangle = iTextSharp.text.Rectangle;

namespace RieltorComp
{
    public partial class AdminForm : Form
    {
        private readonly ContractsTable _contractsTable;
        private readonly PropertiesTable _propertiesTable;
        private readonly UsersTable _usersTable;
        private readonly ClientsTable _clientsTable;
        private readonly ServicesTable _servicesTable;
        
        public AdminForm()
        {
            var db = new ApplicationContext();
            
            _clientsTable = new ClientsTable(db);
            _servicesTable = new ServicesTable(db);
            _propertiesTable = new PropertiesTable(db);
            _contractsTable = new ContractsTable(db);
            _usersTable = new UsersTable(db);
               
            InitializeComponent();

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
            
            string[] usersHeaders = new[]
            {
                @"ФИО риелтора",
                @"Пароль риелтора",
                @"Роль риелтора"
            };

            CreateDataGrid(allContractsDataGrid, 3, usersHeaders, 663);

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
            var services = _servicesTable.GetServices();
            var properties = _propertiesTable.GetProperties();
            
            var users = _usersTable.GetUsers();

            usersDataGrid.Rows.Clear();
            foreach (var user in users)
            {
                usersDataGrid.Rows.Add(new[]
                {
                    user.Username,
                    user.Password,
                    user.Role
                });
            }
            
            var contracts = _contractsTable.GetContracts();

            allContractsDataGrid.Rows.Clear();
            foreach (var contract in contracts)
            {
                var client = _clientsTable.GetClientById(contract.Client.Id);
                var property = _propertiesTable.GetPropertyById(contract.Property.Id);
                var user = _usersTable.GetUser(contract.Realtor.Username);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text == "" || passwordTB.Text == "" || roleTB.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var newUser = new Users()
            {
                Username = userNameTB.Text,
                Password = passwordTB.Text,
                Role = roleTB.Text
            };
            
            _usersTable.CreateUser(newUser);
            UpdateDataGrid();
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
            EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
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

            Phrase p1 = new Phrase
            {
                c1,
                c2,
                c3,
                c4,
                c5,
                c6,
                c7,
                c8,
                c9,
                c10,
                c11,
                c12,
                c13
            };

            Paragraph par1 = new Paragraph(p1.Content, font);

            doc.Add(par1);
            
            doc.Close();
            
            MessageBox.Show(@"Договор создан");
        }
    }
}