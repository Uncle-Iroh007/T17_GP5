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
    public partial class SelProject : Form
    {
        public FakeProjectRepository NewRepository = new FakeProjectRepository();
        public Project SelectedProject;
        public List<Project> projects = new List<Project>();
        public bool isSelected = false;
        public SelProject()
        {
            InitializeComponent();
        }

        private void cncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selPrjt_Click(object sender, EventArgs e)
        {
            //Selected project set to project in list where selected
            SelectedProject = projects[ProjectOptions.SelectedIndex];
            isSelected = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SelProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //Gets all projects in newRepository
            projects = NewRepository.GetAll();
            //Load each item into select screen
            foreach (Project project in projects)
            {
                ProjectOptions.Items.Add(project.Id.ToString() + " - " + project.Name);
            }
            ProjectOptions.SelectedIndex = 0;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
