using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public interface IProjectRepository
    {
        string Add(Project project);
        string Remove(int projectId);

        string Modify(int projectID, Project project);

        List<Project> GetAll();

        bool IsDuplicateName(string projectName);

    }
}
