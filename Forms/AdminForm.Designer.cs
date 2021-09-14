using System.ComponentModel;

namespace RieltorComp
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.roleTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.contractsTabPage = new System.Windows.Forms.TabPage();
            this.printContractButton = new System.Windows.Forms.Button();
            this.allContractsDataGrid = new System.Windows.Forms.DataGridView();
            this.rieltorTB = new System.Windows.Forms.TabControl();
            this.usersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.usersDataGrid)).BeginInit();
            this.contractsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.allContractsDataGrid)).BeginInit();
            this.rieltorTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.roleTB);
            this.usersTabPage.Controls.Add(this.label6);
            this.usersTabPage.Controls.Add(this.button2);
            this.usersTabPage.Controls.Add(this.passwordTB);
            this.usersTabPage.Controls.Add(this.userNameTB);
            this.usersTabPage.Controls.Add(this.label5);
            this.usersTabPage.Controls.Add(this.label4);
            this.usersTabPage.Controls.Add(this.usersDataGrid);
            this.usersTabPage.Location = new System.Drawing.Point(4, 25);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Size = new System.Drawing.Size(1202, 716);
            this.usersTabPage.TabIndex = 2;
            this.usersTabPage.Text = "Добавление новых сотрудников";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // roleTB
            // 
            this.roleTB.Location = new System.Drawing.Point(1027, 116);
            this.roleTB.Name = "roleTB";
            this.roleTB.Size = new System.Drawing.Size(134, 22);
            this.roleTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(883, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Роль сотрудника";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(1027, 76);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(134, 22);
            this.passwordTB.TabIndex = 5;
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(1027, 33);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(134, 22);
            this.userNameTB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(871, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль сотрудника";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(893, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Имя сотрудника";
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToResizeColumns = false;
            this.usersDataGrid.AllowUserToResizeRows = false;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(10, 13);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowTemplate.Height = 24;
            this.usersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGrid.Size = new System.Drawing.Size(663, 421);
            this.usersDataGrid.TabIndex = 1;
            // 
            // contractsTabPage
            // 
            this.contractsTabPage.Controls.Add(this.printContractButton);
            this.contractsTabPage.Controls.Add(this.allContractsDataGrid);
            this.contractsTabPage.Location = new System.Drawing.Point(4, 25);
            this.contractsTabPage.Name = "contractsTabPage";
            this.contractsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractsTabPage.Size = new System.Drawing.Size(1202, 716);
            this.contractsTabPage.TabIndex = 1;
            this.contractsTabPage.Text = "Договоры";
            this.contractsTabPage.UseVisualStyleBackColor = true;
            // 
            // printContractButton
            // 
            this.printContractButton.Location = new System.Drawing.Point(99, 531);
            this.printContractButton.Name = "printContractButton";
            this.printContractButton.Size = new System.Drawing.Size(208, 38);
            this.printContractButton.TabIndex = 11;
            this.printContractButton.Text = "Печать";
            this.printContractButton.UseVisualStyleBackColor = true;
            this.printContractButton.Click += new System.EventHandler(this.printContractButton_Click);
            // 
            // allContractsDataGrid
            // 
            this.allContractsDataGrid.AllowUserToAddRows = false;
            this.allContractsDataGrid.AllowUserToDeleteRows = false;
            this.allContractsDataGrid.AllowUserToOrderColumns = true;
            this.allContractsDataGrid.AllowUserToResizeColumns = false;
            this.allContractsDataGrid.AllowUserToResizeRows = false;
            this.allContractsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allContractsDataGrid.Location = new System.Drawing.Point(99, 16);
            this.allContractsDataGrid.Name = "allContractsDataGrid";
            this.allContractsDataGrid.ReadOnly = true;
            this.allContractsDataGrid.RowTemplate.Height = 24;
            this.allContractsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allContractsDataGrid.Size = new System.Drawing.Size(1000, 509);
            this.allContractsDataGrid.TabIndex = 0;
            // 
            // rieltorTB
            // 
            this.rieltorTB.Controls.Add(this.contractsTabPage);
            this.rieltorTB.Controls.Add(this.usersTabPage);
            this.rieltorTB.Location = new System.Drawing.Point(-2, -1);
            this.rieltorTB.Name = "rieltorTB";
            this.rieltorTB.SelectedIndex = 0;
            this.rieltorTB.Size = new System.Drawing.Size(1210, 745);
            this.rieltorTB.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.rieltorTB.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 743);
            this.Controls.Add(this.rieltorTB);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.usersTabPage.ResumeLayout(false);
            this.usersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.usersDataGrid)).EndInit();
            this.contractsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.allContractsDataGrid)).EndInit();
            this.rieltorTB.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button printContractButton;

        private System.Windows.Forms.TextBox roleTB;

        private System.Windows.Forms.DataGridView allContractsDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage contractsTabPage;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl rieltorTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TabPage usersTabPage;

        #endregion
    }
}