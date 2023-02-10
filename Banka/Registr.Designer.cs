namespace Banka
{
    partial class Registr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordTB2 = new System.Windows.Forms.TextBox();
            this.VisibleCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrB = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(12, 81);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(174, 23);
            this.LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(12, 134);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(151, 23);
            this.PasswordTB.TabIndex = 1;
            // 
            // PasswordTB2
            // 
            this.PasswordTB2.Location = new System.Drawing.Point(12, 189);
            this.PasswordTB2.Name = "PasswordTB2";
            this.PasswordTB2.Size = new System.Drawing.Size(151, 23);
            this.PasswordTB2.TabIndex = 2;
            // 
            // VisibleCB
            // 
            this.VisibleCB.AutoSize = true;
            this.VisibleCB.Image = ((System.Drawing.Image)(resources.GetObject("VisibleCB.Image")));
            this.VisibleCB.Location = new System.Drawing.Point(169, 130);
            this.VisibleCB.Name = "VisibleCB";
            this.VisibleCB.Size = new System.Drawing.Size(45, 30);
            this.VisibleCB.TabIndex = 3;
            this.VisibleCB.UseVisualStyleBackColor = true;
            this.VisibleCB.CheckedChanged += new System.EventHandler(this.VisibleCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторите пароль";
            // 
            // RegistrB
            // 
            this.RegistrB.Location = new System.Drawing.Point(71, 250);
            this.RegistrB.Name = "RegistrB";
            this.RegistrB.Size = new System.Drawing.Size(129, 23);
            this.RegistrB.TabIndex = 7;
            this.RegistrB.Text = "Зарегестрироваться ";
            this.RegistrB.UseVisualStyleBackColor = true;
            this.RegistrB.Click += new System.EventHandler(this.RegistrB_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 37);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(151, 23);
            this.NameTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Имя пользователя";
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.RegistrB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisibleCB);
            this.Controls.Add(this.PasswordTB2);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Name = "Registr";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LoginTB;
        private TextBox PasswordTB;
        private TextBox PasswordTB2;
        private CheckBox VisibleCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RegistrB;
        private TextBox NameTB;
        private Label label4;
    }
}