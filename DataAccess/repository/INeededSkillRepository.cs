using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.repository
{
    public interface INeededSkillRepository
    {
        bool Create(NeededSkill NeededSkill);

        List<Skill> GetSkillByProjectID(int ProjectID);

        bool DeleteNeedeSkillByProjectID(int ProjectID);
    }
}
