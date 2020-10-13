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
        AppUser user = new AppUser();
        Project currentProject = new Project();
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
            Login formLogin = new Login();
            SelProject selectProject = new SelProject();
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
                //Select project when opening program for the first time.
                //Current project set to selected project, and slected project added to preferences
                while (selectProject.isSelected == false && selectProject.ShowDialog(this) == DialogResult.OK)
                {
                    projectRepository = selectProject.NewRepository;
                    currentProject = selectProject.SelectedProject;
                    preferenceRepository.SetPreference(user.UserName, currentProject.Name, currentProject.Id.ToString());
                }
                if (selectProject.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("No project selected. Closing application.", "Attention");
                    Close();
                }

                //Update form title to include project name
                Text += " - " + currentProject.Name;

            }
        }

        private void sel_project_Click(object sender, EventArgs e)
        {
            //Select a project after initial project.
            //currentProject and preferenceRepository based on selected projects
            SelProject selectProject = new SelProject();
            while (selectProject.isSelected == false && selectProject.ShowDialog(this) == DialogResult.OK)
            {
                projectRepository = selectProject.NewRepository;
                currentProject = selectProject.SelectedProject;
                preferenceRepository.SetPreference(user.UserName, currentProject.Name, currentProject.Id.ToString());
            }
            if (selectProject.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("No project selected.", "Attention");
            }
            else
                //Updating title
                Text =  "Main - " + currentProject.Name;
        }

        private void crt_project_Click(object sender, EventArgs e)
        {
            //Opens create window; repository updated to contain created item.
            Create_Project createProject = new Create_Project(projectRepository);
            while (createProject.isCreated == false && createProject.ShowDialog(this) == DialogResult.OK)
            {
                projectRepository = createProject.ProjectRepository;
            }
            if (createProject.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Project succesfully created.", "Attention");
            }
        }

        private void mdfy_project_Click(object sender, EventArgs e)
        {
            //Select a project to be modified from project repo
            Project projectToModify = new Project();
            SelProject selectProject = new SelProject();
            while (selectProject.isSelected == false && selectProject.ShowDialog(this) == DialogResult.OK)
            {
                projectRepository = selectProject.NewRepository;
                projectToModify = selectProject.SelectedProject;
            }

            if (selectProject.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("No project selected for modification.", "Attention");
            }
            //Open modify project window, where user modifies project.
            else
            {
                Modify_Project modifyProject = new Modify_Project(projectRepository, currentProject, projectToModify);
                while (modifyProject.isModified == false && modifyProject.ShowDialog(this) == DialogResult.OK)
                {
                    projectRepository = modifyProject.ProjectRepository;
                }
                if (modifyProject.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Project " + projectToModify.Id + " - " + projectToModify.Name + " succesfully modified.", "Attention");
                }
            }
        }

        private void rmv_project_Click(object sender, EventArgs e)
        {
            //Select a project to be removed from project repo
            Project projectToRemove = new Project();
            SelProject selectProject = new SelProject();
            while (selectProject.isSelected == false && selectProject.ShowDialog(this) == DialogResult.OK)
            {
                projectRepository = selectProject.NewRepository;
                projectToRemove = selectProject.SelectedProject;
            }

            if (selectProject.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("No project selected for removal.", "Attention");
            }
            //Open remove project window, where user confirms project to remove.
            else
            {
                Remove_Project removeProject = new Remove_Project(projectRepository, currentProject, projectToRemove);
                while (removeProject.isRemoved == false && removeProject.ShowDialog(this) == DialogResult.OK)
                {
                    projectRepository = removeProject.ProjectRepository;
                }
                if(removeProject.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Project " + projectToRemove.Id + " - " + projectToRemove.Name + " succesfully removed.", "Attention");
                }
            }
        }
    }
}
