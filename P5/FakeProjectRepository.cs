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
        public const string MODIFIED_PROJECT_ID_ERROR = "ERROR! Project ID Modified.";
        public const string DUPLPICATE_PROJECT_NAME_ERROR = "ERROR! Project Name Already Exists.";
        public const string NO_PROJECT_FOUND_ERROR = "ERROR! Project Not Found.";
        public const string EMPTY_PROJECT_NAME_ERROR = "ERROR! Project Name Cannot be Empty.";

        private static List<Project> projects;

        public FakeProjectRepository() {

            if(projects == null)
            {
                projects = new List<Project>();

                projects.Add(new Project
                {
                    id = 1,
                    Name = "Internship Project"

                }) ;

                projects.Add(new Project
                {

                    id=2,
                    Name = "Software Eng P5"

                });

            }


        }
            public int GetNextId()
            {
                int a = 0;
                return a;
            }



            public string Add(Project project) {

                string a = string.Empty;
                return a;
            }
            public string Remove(int projectId)
            {

                string a = string.Empty;
                return a;
            }

            public string Modify(int projectID, Project project)
            {
                string a = string.Empty;
                return a;

            }

            public List<Project> GetAll()
            {

                List<Project> projcts = new List<Project>();

                return projcts;
            }

            public bool IsDuplicateName(string projectName)
            {

                bool a = true;
                return a;
            }


        

    }
}
