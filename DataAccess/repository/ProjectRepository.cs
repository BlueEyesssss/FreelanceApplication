using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class ProjectRepository : IProjectRepository
    {
        public bool checkProjectStarted(int projectid) => ProjectDAO.Instance.checkProjectStarted(projectid);

        public bool CreateProject(Project Project) => ProjectDAO.Instance.Create(Project);
        

        public List<Project> getListProject() => ProjectDAO.Instance.getListProject();

        public int getProjectIDByProject(Project Project) => ProjectDAO.Instance.getProjectIDByProject(Project);

        public bool Update(Project Project) => ProjectDAO.Instance.Update(Project);

        public string getSkillProjectNeed(int projectid) => ProjectDAO.Instance.getSkillProjectNeed(projectid);

        public bool Delete(int ProjectID) => ProjectDAO.Instance.Delete(ProjectID);

        public List<Project> getListProjectByHirerID(int HirerID) => ProjectDAO.Instance.getListProjectByHirerID(HirerID);
    }
}
