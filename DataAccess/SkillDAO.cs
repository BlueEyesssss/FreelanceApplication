using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
    public class SkillDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static SkillDAO instance;
        public static SkillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SkillDAO();
                }
                return instance;
            }
        }

        public bool clearAllSkillSeeker(int seekerid)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "delete HasSkill where seekerID =@id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", seekerid);
                    check = commad.ExecuteNonQuery() > 0 ? true : false;
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
        public List<Skill> GetSkills()
        {
            List<Skill> ListSkill = new List<Skill>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "SELECT skillID, skillName FROM Skill";
                    commad = new SqlCommand(sql, connect);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListSkill.Add(new Skill
                            {
                                SkillId = reader.GetInt32(0),
                                SkillName = reader.GetString(1),
                                
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
            return ListSkill;
        }

        public bool addSkill(int seekerid, int skillid)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "insert into HasSkill(seekerID, skillID) " +
                        "values(@seid, @skid)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@seid", seekerid);
                    commad.Parameters.AddWithValue("@skid", skillid);
                    check = commad.ExecuteNonQuery() > 0 ? true : false;
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

    }
}
