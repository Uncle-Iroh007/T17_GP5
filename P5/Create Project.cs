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
    public partial class Create_Project : Form
    {
        public FakeProjectRepository ProjectRepository;
        public Project newProject = new Project();
        public bool isCreated = false;
        public Create_Project(FakeProjectRepository currentRepository)
        {
            InitializeComponent();
            ProjectRepository = currentRepository;
        }

        private void pN_Click(object sender, EventArgs e)
        {

        }

        private void cancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPrj_Click(object sender, EventArgs e)
        {
            int newProjectId;
            //Removes whitespace before and after project name
            newProject.Name = nameInput.Text.Trim(' ');
            
            //Attempt to add new project
            string result = ProjectRepository.Add(newProject, out newProjectId);

            //If no errors, succesfully added and information updated for use in caller
            if (result == FakeProjectRepository.NO_ERROR)
            {
                newProject.Id = newProjectId;
                this.DialogResult = DialogResult.OK;
                this.isCreated = true;
                this.Close();
            }
            //If errors, display message based on error
            else if (result == FakeProjectRepository.DUPLPICATE_PROJECT_NAME_ERROR)
                MessageBox.Show(FakeProjectRepository.DUPLPICATE_PROJECT_NAME_ERROR, "Attention");

            else if (result == FakeProjectRepository.EMPTY_PROJECT_NAME_ERROR )
                MessageBox.Show(FakeProjectRepository.EMPTY_PROJECT_NAME_ERROR, "Attention");

        }

        private void Create_Project_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }
    }
}
