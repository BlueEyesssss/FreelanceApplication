using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
    public class HirerDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

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


        public Hirer GetHirerByHirerID(int HirerID)
        {
            Hirer Hirer = null;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select userID, userName, password, fullName, balance, phone, location FROM [User] WHERE userID = @id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", HirerID);
                  
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Hirer = new Hirer
                            {
                                UserId = reader.GetInt32(0),
                                HirerId = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Password = reader.GetString(2),
                                FullName = reader.GetString(3),
                                Balance = reader.GetDecimal(4),
                                Phone = reader.GetString(5),
                                Location = reader.GetString(6),


                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return Hirer;
        }

    }
}
