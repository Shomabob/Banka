using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLogic;

namespace Banka
{
    public partial class Registr : Form
    {
        
        public Registr()
        {
            InitializeComponent();
            PasswordTB2.UseSystemPasswordChar = true;
        }
  
        private void VisibleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (VisibleCB.Checked)
            {
                PasswordTB.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = false;
            }
            
        }

        private void RegistrB_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = LoginTB.Text;
            user.Password = PasswordTB.Text;
            user.UserName = NameTB.Text;
            Capcha capcha = new Capcha();

            if (capcha.ShowDialog()==DialogResult.OK)
            {
                MethodClass.Registration(user);
            }
            else
            {
                MessageBox.Show("Капча не была введена");
            }    

        }
    }
}
