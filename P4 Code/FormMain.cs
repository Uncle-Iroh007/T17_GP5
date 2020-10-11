using P3_Code;
using P5;
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
        Login formLogin = new Login();
        AppUser user = new AppUser();
        SelProject selectProject = new SelProject();
        Project project = new Project();
        FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
        FakeProjectRepository projectRepository = new FakeProjectRepository();
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
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
                while (selectProject.isSelected == false && selectProject.ShowDialog(this) == DialogResult.OK)
                {
                    projectRepository = selectProject.NewRepository;
                    project = selectProject.SelectedProject;
                    preferenceRepository.SetPreference(user.UserName, project.Name, project.Id.ToString());
                }
                Text += " - " + project.Name;

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
