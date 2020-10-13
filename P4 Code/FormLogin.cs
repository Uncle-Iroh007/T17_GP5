using P3_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Code
{
    public partial class Login : Form
    {
        public AppUser LoginUser = new AppUser();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FakeAppUserRepository test = new FakeAppUserRepository();
            string USER_NAME = userNameInput.Text;
            string PASSWORD = passwordInput.Text;
            bool result = test.Login(USER_NAME, PASSWORD);

            if (result == true)
            {
                test.SetAuthentication(USER_NAME, result);
                LoginUser = test.GetByUserName(USER_NAME);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password.", "Attention");
            }

        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
