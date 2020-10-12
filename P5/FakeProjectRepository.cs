using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeProjectRepository : IProjectRepository
    {

       
        public const string NO_ERROR="";
        public const string MODIFIED_PROJECT_ID_ERROR = "Cannot modify your current session project.";
        public const string DUPLPICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        public const string NO_PROJECT_FOUND_ERROR = "No project found.";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        private static List<Project> projects;

        public FakeProjectRepository() {

            if(projects == null)
            {
                projects = new List<Project>();

                projects.Add(new Project
                {
                    Id = 1,
                    Name = "Accounting project"

                }) ;

                projects.Add(new Project
                {

                    Id=2,
                    Name = "Big expensive project"

                });

                projects.Add(new Project
                {

                    Id = 3,
                    Name = "Some other project"

                });

            }


        }
        public int GetNextId()
        {
            //Finds maximum current idea and returns max + 1 for next Id
            int currentMax = 0;
            foreach(Project project in projects)
            {
                if (project.Id > currentMax)
                currentMax = project.Id;
            }
            return currentMax + 1;
        }

        public string Add(Project project, out int Id)
        {
            //Check for empty project name
            if (project.Name == "")
            {
                Id = -1;
                return EMPTY_PROJECT_NAME_ERROR;
            }

            //Check for duplicate projects
            if (IsDuplicateName(project.Name))
            {
                Id = -1;
                return DUPLPICATE_PROJECT_NAME_ERROR;
            }

            //Set Id of project
            project.Id = GetNextId();

            //Add project
            projects.Add(project);

            Id = project.Id;
            return NO_ERROR;
        }

        public string Remove(int projectId)
        {
            bool exists = false;
            Project projectToRemove = new Project();
            //Select project by id; set exists flag to true
            foreach (Project existingProject in projects)
            {
                if(existingProject.Id == projectId)
                {
                    exists = true;
                    projectToRemove = existingProject;
                }
            }
            //Return does not exist if cannot be found
            if (!exists)
                return NO_PROJECT_FOUND_ERROR;

            //Remove from list, return no error
            projects.Remove(projectToRemove);
            return NO_ERROR;
        }

        public string Modify(int projectID, Project project)
        {
            string a = string.Empty;
            return a;

        }

        public List<Project> GetAll()
        {
            //returns list of projects in repository
            return projects;
        }

        public bool IsDuplicateName(string projectName)
        {
            //Checks if project with same name alread exists
            foreach (Project existingProject in projects)
            {
                if (projectName == existingProject.Name)
                {
                    return true;
                }
            }
            return false;
        }      

    }
}
