using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class HirerDAO
    {
        private static HirerDAO instance = null;
        private static readonly object instanceLock = new object();
        public static HirerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HirerDAO();
                    }
                    return instance;
                }
            }
        }

        public Hirer GetHirerById(int HirerId)
        {
            Hirer Hirer = null;
            try
            {
                using var Context = new FreelanceWinFormContext();
                Hirer = Context.Hirers.SingleOrDefault(x => x.HirerId == HirerId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Hirer;
        }

        //ham nay can luu y
        private Hirer GetHirerByUserName(string UserName)
        {
            Hirer Hirer = null;
            try
            {
                using var Context = new FreelanceWinFormContext();
                Hirer = Context.Hirers.SingleOrDefault(x => x.UserName == UserName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Hirer;
        }

        public void Create(Hirer Hirer)
        {
            try
            {
                Hirer _Hirer = GetHirerById(Hirer.HirerId);
                //can check UserName
                
                
                if (_Hirer == null)
                {
                    using var Context = new FreelanceWinFormContext();
                    
                    Context.Hirers.Add(Hirer);
                    Context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
