namespace RieltorComp
{
    partial class RealtorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientsDataGrid = new System.Windows.Forms.DataGridView();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.propertiesDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rieltorTB = new System.Windows.Forms.TabControl();
            this.contractsCreationTabPage = new System.Windows.Forms.TabPage();
            this.propertyTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewClientButton = new System.Windows.Forms.Button();
            this.addNewPropertyButton = new System.Windows.Forms.Button();
            this.addPropertyToContractButton = new System.Windows.Forms.Button();
            this.addServiceToContractButton = new System.Windows.Forms.Button();
            this.createContractButton = new System.Windows.Forms.Button();
            this.addClientToContractButton = new System.Windows.Forms.Button();
            this.contractsTabPage = new System.Windows.Forms.TabPage();
            this.printContractButton = new System.Windows.Forms.Button();
            this.allContractsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.clientsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.servicesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.propertiesDataGrid)).BeginInit();
            this.rieltorTB.SuspendLayout();
            this.contractsCreationTabPage.SuspendLayout();
            this.contractsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.allContractsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsDataGrid
            // 
            this.clientsDataGrid.AllowUserToResizeColumns = false;
            this.clientsDataGrid.AllowUserToResizeRows = false;
            this.clientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGrid.Location = new System.Drawing.Point(6, 6);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.RowTemplate.Height = 24;
            this.clientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGrid.Size = new System.Drawing.Size(566, 291);
            this.clientsDataGrid.TabIndex = 0;
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.AllowUserToResizeColumns = false;
            this.servicesDataGrid.AllowUserToResizeRows = false;
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Location = new System.Drawing.Point(631, 6);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowTemplate.Height = 24;
            this.servicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGrid.Size = new System.Drawing.Size(565, 291);
            this.servicesDataGrid.TabIndex = 1;
            // 
            // propertiesDataGrid
            // 
            this.propertiesDataGrid.AllowUserToResizeColumns = false;
            this.propertiesDataGrid.AllowUserToResizeRows = false;
            this.propertiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDataGrid.Location = new System.Drawing.Point(8, 393);
            this.propertiesDataGrid.Name = "propertiesDataGrid";
            this.propertiesDataGrid.RowTemplate.Height = 24;
            this.propertiesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.propertiesDataGrid.Size = new System.Drawing.Size(875, 291);
            this.propertiesDataGrid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rieltorTB
            // 
            this.rieltorTB.Controls.Add(this.contractsCreationTabPage);
            this.rieltorTB.Controls.Add(this.contractsTabPage);
            this.rieltorTB.Location = new System.Drawing.Point(0, 0);
            this.rieltorTB.Name = "rieltorTB";
            this.rieltorTB.SelectedIndex = 0;
            this.rieltorTB.Size = new System.Drawing.Size(1210, 777);
            this.rieltorTB.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.rieltorTB.TabIndex = 4;
            // 
            // contractsCreationTabPage
            // 
            this.contractsCreationTabPage.Controls.Add(this.propertyTB);
            this.contractsCreationTabPage.Controls.Add(this.label3);
            this.contractsCreationTabPage.Controls.Add(this.serviceTB);
            this.contractsCreationTabPage.Controls.Add(this.label2);
            this.contractsCreationTabPage.Controls.Add(this.clientTB);
            this.contractsCreationTabPage.Controls.Add(this.label1);
            this.contractsCreationTabPage.Controls.Add(this.addNewClientButton);
            this.contractsCreationTabPage.Controls.Add(this.addNewPropertyButton);
            this.contractsCreationTabPage.Controls.Add(this.addPropertyToContractButton);
            this.contractsCreationTabPage.Controls.Add(this.addServiceToContractButton);
            this.contractsCreationTabPage.Controls.Add(this.createContractButton);
            this.contractsCreationTabPage.Controls.Add(this.addClientToContractButton);
            this.contractsCreationTabPage.Controls.Add(this.servicesDataGrid);
            this.contractsCreationTabPage.Controls.Add(this.clientsDataGrid);
            this.contractsCreationTabPage.Controls.Add(this.propertiesDataGrid);
            this.contractsCreationTabPage.Location = new System.Drawing.Point(4, 25);
            this.contractsCreationTabPage.Name = "contractsCreationTabPage";
            this.contractsCreationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractsCreationTabPage.Size = new System.Drawing.Size(1202, 748);
            this.contractsCreationTabPage.TabIndex = 0;
            this.contractsCreationTabPage.Text = "Создание договоров";
            this.contractsCreationTabPage.UseVisualStyleBackColor = true;
            // 
            // propertyTB
            // 
            this.propertyTB.Location = new System.Drawing.Point(1025, 492);
            this.propertyTB.Name = "propertyTB";
            this.propertyTB.ReadOnly = true;
            this.propertyTB.Size = new System.Drawing.Size(166, 22);
            this.propertyTB.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(904, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Недвижимость";
            // 
            // serviceTB
            // 
            this.serviceTB.Location = new System.Drawing.Point(1025, 453);
            this.serviceTB.Name = "serviceTB";
            this.serviceTB.ReadOnly = true;
            this.serviceTB.Size = new System.Drawing.Size(166, 22);
            this.serviceTB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(904, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Услуга";
            // 
            // clientTB
            // 
            this.clientTB.Location = new System.Drawing.Point(1025, 411);
            this.clientTB.Name = "clientTB";
            this.clientTB.ReadOnly = true;
            this.clientTB.Size = new System.Drawing.Size(166, 22);
            this.clientTB.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(904, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Клиент";
            // 
            // addNewClientButton
            // 
            this.addNewClientButton.Location = new System.Drawing.Point(243, 303);
            this.addNewClientButton.Name = "addNewClientButton";
            this.addNewClientButton.Size = new System.Drawing.Size(205, 35);
            this.addNewClientButton.TabIndex = 13;
            this.addNewClientButton.Text = "Добавить нового клиента\r\n";
            this.addNewClientButton.UseVisualStyleBackColor = true;
            this.addNewClientButton.Click += new System.EventHandler(this.addNewClientButton_Click);
            // 
            // addNewPropertyButton
            // 
            this.addNewPropertyButton.Location = new System.Drawing.Point(285, 690);
            this.addNewPropertyButton.Name = "addNewPropertyButton";
            this.addNewPropertyButton.Size = new System.Drawing.Size(250, 35);
            this.addNewPropertyButton.TabIndex = 12;
            this.addNewPropertyButton.Text = "Добавить новую недвижимость";
            this.addNewPropertyButton.UseVisualStyleBackColor = true;
            this.addNewPropertyButton.Click += new System.EventHandler(this.addNewPropertyButton_Click);
            // 
            // addPropertyToContractButton
            // 
            this.addPropertyToContractButton.Location = new System.Drawing.Point(6, 690);
            this.addPropertyToContractButton.Name = "addPropertyToContractButton";
            this.addPropertyToContractButton.Size = new System.Drawing.Size(273, 35);
            this.addPropertyToContractButton.TabIndex = 11;
            this.addPropertyToContractButton.Text = "Добавить недвижимость в договор";
            this.addPropertyToContractButton.UseVisualStyleBackColor = true;
            this.addPropertyToContractButton.Click += new System.EventHandler(this.addPropertyToContractButton_Click);
            // 
            // addServiceToContractButton
            // 
            this.addServiceToContractButton.Location = new System.Drawing.Point(631, 303);
            this.addServiceToContractButton.Name = "addServiceToContractButton";
            this.addServiceToContractButton.Size = new System.Drawing.Size(221, 35);
            this.addServiceToContractButton.TabIndex = 6;
            this.addServiceToContractButton.Text = "Добавить услугу в договор";
            this.addServiceToContractButton.UseVisualStyleBackColor = true;
            this.addServiceToContractButton.Click += new System.EventHandler(this.addServiceToContractButton_Click);
            // 
            // createContractButton
            // 
            this.createContractButton.Location = new System.Drawing.Point(980, 599);
            this.createContractButton.Name = "createContractButton";
            this.createContractButton.Size = new System.Drawing.Size(190, 52);
            this.createContractButton.TabIndex = 5;
            this.createContractButton.Text = "Создать договор";
            this.createContractButton.UseVisualStyleBackColor = true;
            this.createContractButton.Click += new System.EventHandler(this.createContractButton_Click);
            // 
            // addClientToContractButton
            // 
            this.addClientToContractButton.Location = new System.Drawing.Point(6, 303);
            this.addClientToContractButton.Name = "addClientToContractButton";
            this.addClientToContractButton.Size = new System.Drawing.Size(231, 35);
            this.addClientToContractButton.TabIndex = 3;
            this.addClientToContractButton.Text = "Добавить клиента в договор";
            this.addClientToContractButton.UseVisualStyleBackColor = true;
            this.addClientToContractButton.Click += new System.EventHandler(this.addClientToContractButton_Click);
            // 
            // contractsTabPage
            // 
            this.contractsTabPage.Controls.Add(this.printContractButton);
            this.contractsTabPage.Controls.Add(this.allContractsDataGrid);
            this.contractsTabPage.Location = new System.Drawing.Point(4, 25);
            this.contractsTabPage.Name = "contractsTabPage";
            this.contractsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractsTabPage.Size = new System.Drawing.Size(1202, 748);
            this.contractsTabPage.TabIndex = 1;
            this.contractsTabPage.Text = "Договоры";
            this.contractsTabPage.UseVisualStyleBackColor = true;
            // 
            // printContractButton
            // 
            this.printContractButton.Location = new System.Drawing.Point(100, 531);
            this.printContractButton.Name = "printContractButton";
            this.printContractButton.Size = new System.Drawing.Size(208, 38);
            this.printContractButton.TabIndex = 1;
            this.printContractButton.Text = "Печать";
            this.printContractButton.UseVisualStyleBackColor = true;
            this.printContractButton.Click += new System.EventHandler(this.printContractButton_Click);
            // 
            // allContractsDataGrid
            // 
            this.allContractsDataGrid.AllowUserToResizeColumns = false;
            this.allContractsDataGrid.AllowUserToResizeRows = false;
            this.allContractsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allContractsDataGrid.Location = new System.Drawing.Point(99, 16);
            this.allContractsDataGrid.Name = "allContractsDataGrid";
            this.allContractsDataGrid.RowTemplate.Height = 24;
            this.allContractsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allContractsDataGrid.Size = new System.Drawing.Size(1000, 509);
            this.allContractsDataGrid.TabIndex = 0;
            // 
            // RielrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1207, 762);
            this.Controls.Add(this.rieltorTB);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "RealtorForm";
            this.Text = "Недвижимость";
            ((System.ComponentModel.ISupportInitialize) (this.clientsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.servicesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.propertiesDataGrid)).EndInit();
            this.rieltorTB.ResumeLayout(false);
            this.contractsCreationTabPage.ResumeLayout(false);
            this.contractsCreationTabPage.PerformLayout();
            this.contractsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.allContractsDataGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button printContractButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceTB;
        private System.Windows.Forms.TextBox propertyTB;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientTB;

        private System.Windows.Forms.Button addNewClientButton;

        private System.Windows.Forms.Button addNewPropertyButton;
        private System.Windows.Forms.Button addPropertyToContractButton;

        private System.Windows.Forms.Button createContractButton;
        private System.Windows.Forms.Button addServiceToContractButton;

        private System.Windows.Forms.DataGridView allContractsDataGrid;

        private System.Windows.Forms.Button addClientToContractButton;

        private System.Windows.Forms.TabControl rieltorTB;
        private System.Windows.Forms.TabPage contractsCreationTabPage;
        private System.Windows.Forms.TabPage contractsTabPage;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView propertiesDataGrid;
        private System.Windows.Forms.DataGridView servicesDataGrid;

        private System.Windows.Forms.DataGridView clientsDataGrid;

        #endregion
    }
}