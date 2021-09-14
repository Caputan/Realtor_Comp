using System.ComponentModel;

namespace RieltorComp
{
    partial class AddNewPropertyForm
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
            this.areaTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelPropertyButton = new System.Windows.Forms.Button();
            this.createPropertyButton = new System.Windows.Forms.Button();
            this.roomNumTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ownerPassportTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ownerNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // areaTB
            // 
            this.areaTB.Location = new System.Drawing.Point(253, 143);
            this.areaTB.Name = "areaTB";
            this.areaTB.Size = new System.Drawing.Size(152, 22);
            this.areaTB.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(85, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 44;
            this.label5.Text = "Жилая площадь";
            // 
            // cancelPropertyButton
            // 
            this.cancelPropertyButton.Location = new System.Drawing.Point(263, 332);
            this.cancelPropertyButton.Name = "cancelPropertyButton";
            this.cancelPropertyButton.Size = new System.Drawing.Size(142, 37);
            this.cancelPropertyButton.TabIndex = 43;
            this.cancelPropertyButton.Text = "Отмена";
            this.cancelPropertyButton.UseVisualStyleBackColor = true;
            this.cancelPropertyButton.Click += new System.EventHandler(this.cancelPropertyButton_Click);
            // 
            // createPropertyButton
            // 
            this.createPropertyButton.Location = new System.Drawing.Point(85, 332);
            this.createPropertyButton.Name = "createPropertyButton";
            this.createPropertyButton.Size = new System.Drawing.Size(142, 37);
            this.createPropertyButton.TabIndex = 42;
            this.createPropertyButton.Text = "Подтвердить";
            this.createPropertyButton.UseVisualStyleBackColor = true;
            this.createPropertyButton.Click += new System.EventHandler(this.createPropertyButton_Click);
            // 
            // roomNumTB
            // 
            this.roomNumTB.Location = new System.Drawing.Point(253, 181);
            this.roomNumTB.Name = "roomNumTB";
            this.roomNumTB.Size = new System.Drawing.Size(152, 22);
            this.roomNumTB.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(85, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Количество комнат";
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(253, 105);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(152, 22);
            this.adressTB.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Адрес недвижимости";
            // 
            // ownerPassportTB
            // 
            this.ownerPassportTB.Location = new System.Drawing.Point(253, 62);
            this.ownerPassportTB.Name = "ownerPassportTB";
            this.ownerPassportTB.Size = new System.Drawing.Size(152, 22);
            this.ownerPassportTB.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(85, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 48;
            this.label3.Text = "Паспорт собственника";
            // 
            // ownerNameTB
            // 
            this.ownerNameTB.Location = new System.Drawing.Point(253, 24);
            this.ownerNameTB.Name = "ownerNameTB";
            this.ownerNameTB.Size = new System.Drawing.Size(152, 22);
            this.ownerNameTB.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(85, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 46;
            this.label4.Text = "Имя собственника";
            // 
            // AddNewPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 524);
            this.Controls.Add(this.ownerPassportTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ownerNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.areaTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelPropertyButton);
            this.Controls.Add(this.createPropertyButton);
            this.Controls.Add(this.roomNumTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.label1);
            this.Name = "AddNewPropertyForm";
            this.Text = "Добавление недвижимости";
            this.Shown += new System.EventHandler(this.AddNewPropertyForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ownerPassportTB;
        private System.Windows.Forms.TextBox ownerNameTB;

        private System.Windows.Forms.TextBox roomNumTB;
        private System.Windows.Forms.Button cancelPropertyButton;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Button createPropertyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox areaTB;

        #endregion
    }
}