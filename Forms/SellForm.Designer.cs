using System.ComponentModel;

namespace RieltorComp
{
    partial class SellForm
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
            this.cancelSellButton = new System.Windows.Forms.Button();
            this.createSellButton = new System.Windows.Forms.Button();
            this.sellPriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passportTB
            // 
            this.passportTB.Location = new System.Drawing.Point(263, 76);
            this.passportTB.Name = "passportTB";
            this.passportTB.ReadOnly = true;
            this.passportTB.Size = new System.Drawing.Size(152, 22);
            this.passportTB.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(95, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "Паспорт клиета";
            // 
            // cancelSellButton
            // 
            this.cancelSellButton.Location = new System.Drawing.Point(273, 318);
            this.cancelSellButton.Name = "cancelSellButton";
            this.cancelSellButton.Size = new System.Drawing.Size(142, 37);
            this.cancelSellButton.TabIndex = 33;
            this.cancelSellButton.Text = "Отмена";
            this.cancelSellButton.UseVisualStyleBackColor = true;
            this.cancelSellButton.Click += new System.EventHandler(this.cancelSellButton_Click);
            // 
            // createSellButton
            // 
            this.createSellButton.Location = new System.Drawing.Point(95, 318);
            this.createSellButton.Name = "createSellButton";
            this.createSellButton.Size = new System.Drawing.Size(142, 37);
            this.createSellButton.TabIndex = 32;
            this.createSellButton.Text = "Подтвердить";
            this.createSellButton.UseVisualStyleBackColor = true;
            this.createSellButton.Click += new System.EventHandler(this.createSellButton_Click);
            // 
            // sellPriceTB
            // 
            this.sellPriceTB.Location = new System.Drawing.Point(263, 154);
            this.sellPriceTB.Name = "sellPriceTB";
            this.sellPriceTB.Size = new System.Drawing.Size(152, 22);
            this.sellPriceTB.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(95, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Стоимость";
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(263, 114);
            this.adressTB.Name = "adressTB";
            this.adressTB.ReadOnly = true;
            this.adressTB.Size = new System.Drawing.Size(152, 22);
            this.adressTB.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(95, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Адрес";
            // 
            // clientTB
            // 
            this.clientTB.Location = new System.Drawing.Point(263, 38);
            this.clientTB.Name = "clientTB";
            this.clientTB.ReadOnly = true;
            this.clientTB.Size = new System.Drawing.Size(152, 22);
            this.clientTB.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя клиента";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.passportTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelSellButton);
            this.Controls.Add(this.createSellButton);
            this.Controls.Add(this.sellPriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientTB);
            this.Controls.Add(this.label1);
            this.Name = "SellForm";
            this.Text = "Купля/Продажа";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Button cancelSellButton;
        private System.Windows.Forms.TextBox clientTB;
        private System.Windows.Forms.Button createSellButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sellPriceTB;
        private System.Windows.Forms.TextBox passportTB;

        #endregion
    }
}