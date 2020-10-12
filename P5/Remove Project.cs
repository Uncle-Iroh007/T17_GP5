using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class Remove_Project : Form
    {
        public FakeProjectRepository ProjectRepository;
        public Project projectToRemove;
        public Project currentProject;
        public List<Project> allProjects;
        public bool isRemoved = false;
        public Remove_Project(FakeProjectRepository currentRepository, Project current,Project toRemove)
        {
            InitializeComponent();
            currentProject = current;
            projectToRemove = toRemove;
            ProjectRepository = currentRepository;
            allProjects = ProjectRepository.GetAll();
        }

        private void cnclRmv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rmvPrj_Click(object sender, EventArgs e)
        {
            //have project removed if it is not the same as the current project
            if (currentProject != projectToRemove)
            {
                //Remove
                string result = ProjectRepository.Remove(projectToRemove.Id);
                //If no errors, remove succesful
                if (result == FakeProjectRepository.NO_ERROR)
                {
                    this.DialogResult = DialogResult.OK;
                    this.isRemoved = true;
                    this.Close();
                }
                //If project not found, give error in message box
                else if (result == FakeProjectRepository.NO_PROJECT_FOUND_ERROR)
                {
                    MessageBox.Show(FakeProjectRepository.NO_PROJECT_FOUND_ERROR, "Attention");
                    this.Close();
                }
            }
            //If the project is the same as the current, give error in message box
            else
            {
                MessageBox.Show("Cannot modify your current session project.", "Attention");
                this.Close();
            }
        }

        private void Remove_Project_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //Display name of projectToRemove in label
            removeName.Text = projectToRemove.Name;
        }
    }
}
