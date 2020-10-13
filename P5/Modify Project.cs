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
    public partial class Modify_Project : Form
    {
        public FakeProjectRepository ProjectRepository;
        public Project projectToModify;
        public Project currentProject;
        public List<Project> allProjects;
        public bool isModified = false;

        public Modify_Project(FakeProjectRepository currentRepository, Project current, Project toModify)
        {
            InitializeComponent();
            currentProject = current;
            projectToModify = toModify;
            ProjectRepository = currentRepository;
            allProjects = ProjectRepository.GetAll();
        }
        
        private void Modify_Project_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBox1.Text = projectToModify.Name;
        }

        private void mdfy_Click(object sender, EventArgs e)
        {
            Project updatedProject = new Project();
            string newName = textBox1.Text;
            // remove extra whitespace
            newName.Trim();
            updatedProject.Id = projectToModify.Id;
            updatedProject.Name = newName;
            //Check if current project
            if (currentProject != projectToModify)
            {
                //Modify
                string result = ProjectRepository.Modify(projectToModify.Id, updatedProject);
                //If no errors, modify succesful
                if (result == FakeProjectRepository.NO_ERROR)
                {
                    this.DialogResult = DialogResult.OK;
                    this.isModified = true;
                    this.Close();
                }
                //If there is an error, display in message box and close modify form 
                else
                {
                    MessageBox.Show(result, "Attention");
                    this.Close();
                }
            }
            //If the project is the same as the current, give error in message box
            else
            {
                MessageBox.Show(FakeProjectRepository.MODIFIED_PROJECT_ID_ERROR, "Attention");
                this.Close();
            }

        }

        private void cnclMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
