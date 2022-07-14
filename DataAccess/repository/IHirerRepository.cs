using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.repository
{
    public interface IHirerRepository
    {

        bool createHirer(Hirer Hirer);
        bool createUser(Hirer user);
        int getHirerId(Hirer Hirer);
        bool checkDuplicateuserName(string UserName);

        List<Hirer> GetHirers();

        Hirer GetHirerByHirerID(int HirerID);

        bool Update(Hirer Hirer);
    }
}
