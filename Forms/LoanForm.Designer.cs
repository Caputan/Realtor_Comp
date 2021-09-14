using System.ComponentModel;

namespace RieltorComp
{
    partial class LoanForm
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
            this.passportTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelLoanButton = new System.Windows.Forms.Button();
            this.createLoanButton = new System.Windows.Forms.Button();
            this.loanPeriodTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loanPriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.persentTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passportTB
            // 
            this.passportTB.Location = new System.Drawing.Point(255, 82);
            this.passportTB.Name = "passportTB";
            this.passportTB.ReadOnly = true;
            this.passportTB.Size = new System.Drawing.Size(152, 22);
            this.passportTB.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(87, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Паспорт клиета";
            // 
            // cancelLoanButton
            // 
            this.cancelLoanButton.Location = new System.Drawing.Point(265, 324);
            this.cancelLoanButton.Name = "cancelLoanButton";
            this.cancelLoanButton.Size = new System.Drawing.Size(142, 37);
            this.cancelLoanButton.TabIndex = 21;
            this.cancelLoanButton.Text = "Отмена";
            this.cancelLoanButton.UseVisualStyleBackColor = true;
            this.cancelLoanButton.Click += new System.EventHandler(this.cancelLoanButton_Click);
            // 
            // createLoanButton
            // 
            this.createLoanButton.Location = new System.Drawing.Point(87, 324);
            this.createLoanButton.Name = "createLoanButton";
            this.createLoanButton.Size = new System.Drawing.Size(142, 37);
            this.createLoanButton.TabIndex = 20;
            this.createLoanButton.Text = "Подтвердить";
            this.createLoanButton.UseVisualStyleBackColor = true;
            this.createLoanButton.Click += new System.EventHandler(this.createLoanButton_Click);
            // 
            // loanPeriodTB
            // 
            this.loanPeriodTB.Location = new System.Drawing.Point(255, 204);
            this.loanPeriodTB.Name = "loanPeriodTB";
            this.loanPeriodTB.Size = new System.Drawing.Size(152, 22);
            this.loanPeriodTB.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(87, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Срок выплат";
            // 
            // loanPriceTB
            // 
            this.loanPriceTB.Location = new System.Drawing.Point(255, 160);
            this.loanPriceTB.Name = "loanPriceTB";
            this.loanPriceTB.Size = new System.Drawing.Size(152, 22);
            this.loanPriceTB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(87, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Стоимость";
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(255, 120);
            this.adressTB.Name = "adressTB";
            this.adressTB.ReadOnly = true;
            this.adressTB.Size = new System.Drawing.Size(152, 22);
            this.adressTB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(87, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Адрес";
            // 
            // clientTB
            // 
            this.clientTB.Location = new System.Drawing.Point(255, 44);
            this.clientTB.Name = "clientTB";
            this.clientTB.ReadOnly = true;
            this.clientTB.Size = new System.Drawing.Size(152, 22);
            this.clientTB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя клиента";
            // 
            // persentTB
            // 
            this.persentTB.Location = new System.Drawing.Point(255, 243);
            this.persentTB.Name = "persentTB";
            this.persentTB.Size = new System.Drawing.Size(152, 22);
            this.persentTB.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(87, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Процентная ставка";
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 490);
            this.Controls.Add(this.persentTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passportTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelLoanButton);
            this.Controls.Add(this.createLoanButton);
            this.Controls.Add(this.loanPeriodTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loanPriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientTB);
            this.Controls.Add(this.label1);
            this.Name = "LoanForm";
            this.Text = "Ипотека";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox persentTB;

        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Button cancelLoanButton;
        private System.Windows.Forms.TextBox clientTB;
        private System.Windows.Forms.Button createLoanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passportTB;
        private System.Windows.Forms.TextBox loanPeriodTB;
        private System.Windows.Forms.TextBox loanPriceTB;

        #endregion
    }
}