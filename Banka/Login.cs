using BankaLogic;

namespace Banka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (MethodClass.UserAuth(LoginTB.Text, PasswordTB.Text))
            {
                Main main = new Main();
                AppContext.context.MainForm = main;
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
            
        }
    }
}