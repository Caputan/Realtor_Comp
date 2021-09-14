using System.ComponentModel;

namespace RieltorComp
{
    partial class AddNewClientForm
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
            this.clientTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passportTB
            // 
            this.passportTB.Location = new System.Drawing.Point(236, 119);
            this.passportTB.Name = "passportTB";
            this.passportTB.Size = new System.Drawing.Size(152, 22);
            this.passportTB.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(68, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 44;
            this.label5.Text = "Паспорт клиета";
            // 
            // cancelSellButton
            // 
            this.cancelSellButton.Location = new System.Drawing.Point(246, 361);
            this.cancelSellButton.Name = "cancelSellButton";
            this.cancelSellButton.Size = new System.Drawing.Size(142, 37);
            this.cancelSellButton.TabIndex = 43;
            this.cancelSellButton.Text = "Отмена";
            this.cancelSellButton.UseVisualStyleBackColor = true;
            this.cancelSellButton.Click += new System.EventHandler(this.cancelSellButton_Click);
            // 
            // createSellButton
            // 
            this.createSellButton.Location = new System.Drawing.Point(68, 361);
            this.createSellButton.Name = "createSellButton";
            this.createSellButton.Size = new System.Drawing.Size(142, 37);
            this.createSellButton.TabIndex = 42;
            this.createSellButton.Text = "Подтвердить";
            this.createSellButton.UseVisualStyleBackColor = true;
            this.createSellButton.Click += new System.EventHandler(this.createSellButton_Click);
            // 
            // clientTB
            // 
            this.clientTB.Location = new System.Drawing.Point(236, 81);
            this.clientTB.Name = "clientTB";
            this.clientTB.Size = new System.Drawing.Size(152, 22);
            this.clientTB.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Имя клиента";
            // 
            // AddNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 478);
            this.Controls.Add(this.passportTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelSellButton);
            this.Controls.Add(this.createSellButton);
            this.Controls.Add(this.clientTB);
            this.Controls.Add(this.label1);
            this.Name = "AddNewClientForm";
            this.Text = "Добавление клиента";
            this.Shown += new System.EventHandler(this.AddNewClientForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button cancelSellButton;
        private System.Windows.Forms.TextBox clientTB;
        private System.Windows.Forms.Button createSellButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passportTB;

        #endregion
    }
}