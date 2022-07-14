using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class HirerRepository : IHirerRepository
    {
        public bool checkDuplicateuserName(string username) => UserDAO.Instance.checkDuplicateuserName(username);

        public bool createHirer(Hirer Hirer) => UserDAO.Instance.createHirer(Hirer);

        public bool createUser(Hirer Hirer) => UserDAO.Instance.createUser1(Hirer);

        public int getHirerId(Hirer Hirer) => UserDAO.Instance.getHirerId(Hirer);

        public List<Hirer> GetHirers() => UserDAO.Instance.getListHirer();

        public Hirer GetHirerByHirerID(int HirerID) => HirerDAO.Instance.GetHirerByHirerID(HirerID);

        public bool Update(Hirer Hirer) => HirerDAO.Instance.Update(Hirer);


    }
}
