using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.repository
{
    public interface ISkillRepository
    {
        List<Skill> GetSkills();
        bool addSkill(int seekerid, int skillid);
    }
}
