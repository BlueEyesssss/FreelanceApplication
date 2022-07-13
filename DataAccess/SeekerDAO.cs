using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BusinessObject;


namespace DataAccess
{
    public class SeekerDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static SeekerDAO instance = null;
        private static readonly object instanceLock = new object();
        public static SeekerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SeekerDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Seeker> GetListSeekerByid(int seekerid)
        {
            List<Seeker> ListSeeker = new List<Seeker>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "SELECT U.UserID, U.userName, U.password, U.balance, U.Phone, U.location, S.seekerID, S.overview, S.school, S.major FROM[User] U, Seeker S WHERE U.UserID = S.seekerID and seekerID = @id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListSeeker.Add(new Seeker
                            {
                                UserId = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Password = reader.GetString(2),
                                Balance = reader.GetDecimal(3),
                                Phone = reader.GetString(4),
                                Location = reader.GetString(5),
                                SeekerId = reader.GetInt32(6),
                                Overview = reader.GetString(7),
                                School = reader.GetString(8),
                                Major = reader.GetString(9),

                            });
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
            return ListSeeker;
        }

        public List<string> getSkillSeekerHas(int seekerid)
        {
            List<string> check = new List<string>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select hs.seekerID, skillName " +
                        "from HasSkill hs, Skill s " +
                        "where seekerID = @seid and hs.skillID = s.skillID";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@seid", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            check.Add(reader.GetString(1));
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
            return check;
        }

        public List<Seeker> GetListSeeker()
        {
            List<Seeker> ListSeeker = new List<Seeker>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "SELECT U.UserID, U.userName, U.password, U.balance, U.Phone, U.location, S.seekerID, S.overview, S.school, S.major FROM[User] U, Seeker S WHERE U.UserID = S.seekerID";
                    commad = new SqlCommand(sql, connect);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListSeeker.Add(new Seeker
                            {
                                UserId = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Password = reader.GetString(2),
                                Balance = reader.GetDecimal(3),
                                Phone = reader.GetString(4),
                                Location = reader.GetString(5),
                                SeekerId = reader.GetInt32(6),
                                Overview = reader.GetString(7),
                                School = reader.GetString(8),
                                Major = reader.GetString(9),

                            });
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
            return ListSeeker;
        }

    }
}
