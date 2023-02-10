namespace Banka
{
    partial class Login
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistrButton = new System.Windows.Forms.Button();
            this.JoinButton = new System.Windows.Forms.Button();
            this.VisibleCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(12, 112);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(185, 23);
            this.PasswordTB.TabIndex = 0;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(12, 48);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(185, 23);
            this.LoginTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // RegistrButton
            // 
            this.RegistrButton.Location = new System.Drawing.Point(12, 178);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(94, 23);
            this.RegistrButton.TabIndex = 4;
            this.RegistrButton.Text = "Регистрация";
            this.RegistrButton.UseVisualStyleBackColor = true;
            this.RegistrButton.Click += new System.EventHandler(this.RegistrButton_Click);
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(152, 178);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(75, 23);
            this.JoinButton.TabIndex = 5;
            this.JoinButton.Text = "Войти";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // VisibleCB
            // 
            this.VisibleCB.AutoSize = true;
            this.VisibleCB.Image = ((System.Drawing.Image)(resources.GetObject("VisibleCB.Image")));
            this.VisibleCB.Location = new System.Drawing.Point(203, 108);
            this.VisibleCB.Name = "VisibleCB";
            this.VisibleCB.Size = new System.Drawing.Size(45, 30);
            this.VisibleCB.TabIndex = 6;
            this.VisibleCB.UseVisualStyleBackColor = true;
            this.VisibleCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 241);
            this.Controls.Add(this.VisibleCB);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.RegistrButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.PasswordTB);
            this.Name = "Login";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PasswordTB;
        private TextBox LoginTB;
        private Label label1;
        private Label label2;
        private Button RegistrButton;
        private Button JoinButton;
        private CheckBox VisibleCB;
    }
}