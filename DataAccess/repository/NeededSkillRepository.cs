using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.repository
{
    public class NeededSkillRepository : INeededSkillRepository
    {
        public bool Create(NeededSkill NeededSkill) => NeededSkillDAO.Instance.Create(NeededSkill);

        public List<Skill> GetSkillByProjectID(int ProjectID) => NeededSkillDAO.Instance.GetSkillByProjectID(ProjectID);

        public bool DeleteNeedeSkillByProjectID(int ProjectID) => NeededSkillDAO.Instance.DeleteNeedeSkillByProjectID(ProjectID);
    }
}
