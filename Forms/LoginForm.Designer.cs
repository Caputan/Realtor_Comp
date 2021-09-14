using System.ComponentModel;

namespace RieltorComp
{
    partial class LoginForm
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
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(177, 93);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(144, 22);
            this.loginTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(177, 141);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(144, 22);
            this.passwordTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(160, 298);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(161, 42);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 410);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;

        #endregion
    }
}