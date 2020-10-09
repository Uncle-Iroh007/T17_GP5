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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Login formLogin = new Login();
            AppUser user = new AppUser();
            user.IsAuthenticated = false;

            while (user.IsAuthenticated == false && formLogin.ShowDialog(this) == DialogResult.OK)
            {
                user = formLogin.LoginUser;
            }

            if(formLogin.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                Text = "Main - No Project Selected";
            }
        }

        private void sel_project_Click(object sender, EventArgs e)
        {

        }

        private void crt_project_Click(object sender, EventArgs e)
        {

        }

        private void mdfy_project_Click(object sender, EventArgs e)
        {

        }

        private void rmv_project_Click(object sender, EventArgs e)
        {

        }
    }
}
