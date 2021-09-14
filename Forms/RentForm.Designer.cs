using System.ComponentModel;

namespace RieltorComp
{
    partial class RentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentPriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentPeriodTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createRentButton = new System.Windows.Forms.Button();
            this.cancelRentButton = new System.Windows.Forms.Button();
            this.passportTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя клиента";
            // 
            // clientTB
            // 
            this.clientTB.Location = new System.Drawing.Point(256, 107);
            this.clientTB.Name = "clientTB";
            this.clientTB.ReadOnly = true;
            this.clientTB.Size = new System.Drawing.Size(152, 22);
            this.clientTB.TabIndex = 1;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(256, 183);
            this.adressTB.Name = "adressTB";
            this.adressTB.ReadOnly = true;
            this.adressTB.Size = new System.Drawing.Size(152, 22);
            this.adressTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(88, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адресс";
            // 
            // rentPriceTB
            // 
            this.rentPriceTB.Location = new System.Drawing.Point(256, 223);
            this.rentPriceTB.Name = "rentPriceTB";
            this.rentPriceTB.Size = new System.Drawing.Size(152, 22);
            this.rentPriceTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(88, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена аренды";
            // 
            // rentPeriodTB
            // 
            this.rentPeriodTB.Location = new System.Drawing.Point(256, 267);
            this.rentPeriodTB.Name = "rentPeriodTB";
            this.rentPeriodTB.Size = new System.Drawing.Size(152, 22);
            this.rentPeriodTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(88, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Срок аренды";
            // 
            // createRentButton
            // 
            this.createRentButton.Location = new System.Drawing.Point(88, 387);
            this.createRentButton.Name = "createRentButton";
            this.createRentButton.Size = new System.Drawing.Size(142, 37);
            this.createRentButton.TabIndex = 8;
            this.createRentButton.Text = "Подтвердить";
            this.createRentButton.UseVisualStyleBackColor = true;
            this.createRentButton.Click += new System.EventHandler(this.createRentButton_Click);
            // 
            // cancelRentButton
            // 
            this.cancelRentButton.Location = new System.Drawing.Point(266, 387);
            this.cancelRentButton.Name = "cancelRentButton";
            this.cancelRentButton.Size = new System.Drawing.Size(142, 37);
            this.cancelRentButton.TabIndex = 9;
            this.cancelRentButton.Text = "Отмена";
            this.cancelRentButton.UseVisualStyleBackColor = true;
            this.cancelRentButton.Click += new System.EventHandler(this.cancelRentButton_Click);
            // 
            // passportTB
            // 
            this.passportTB.Location = new System.Drawing.Point(256, 145);
            this.passportTB.Name = "passportTB";
            this.passportTB.ReadOnly = true;
            this.passportTB.Size = new System.Drawing.Size(152, 22);
            this.passportTB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(88, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Паспорт клиета";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 522);
            this.Controls.Add(this.passportTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelRentButton);
            this.Controls.Add(this.createRentButton);
            this.Controls.Add(this.rentPeriodTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rentPriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientTB);
            this.Controls.Add(this.label1);
            this.Name = "RentForm";
            this.Text = "Аренда недвижимости";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passportTB;

        private System.Windows.Forms.Button cancelRentButton;
        private System.Windows.Forms.Button createRentButton;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rentPeriodTB;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox rentPriceTB;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientTB;

        #endregion
    }
}