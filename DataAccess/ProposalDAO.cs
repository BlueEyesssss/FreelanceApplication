using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProposalDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static ProposalDAO instance;
        public static ProposalDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProposalDAO();
                }
                return instance;
            }
        }
        public List<Proposal> getListSubmitedProposal(int seekerid)
        {
            List<Proposal> listP = new List<Proposal>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select proposalID, projectID, seekerID,  " +
                        "paymentAmount, status, createdDate, message " +
                        "from Proposal " +
                        "where seekerID = @id and status = 'proposal sent'";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Proposal
                            {
                                ProposalId = reader.GetInt32(0),
                                ProjectId = reader.GetInt32(1),
                                SeekerId = reader.GetInt32(2),
                                PaymentAmount = reader.GetDecimal(3),
                                Status = reader.GetString(4),
                                CreatedDate = reader.GetDateTime(5),
                                Message = reader.GetString(6)
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
            return listP;
        }

        public List<Proposal> getListReceivedJob(int seekerid)
        {
            List<Proposal> listP = new List<Proposal>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select proposalID, projectID, seekerID,  " +
                        "paymentAmount, status, createdDate, message " +
                        "from Proposal " +
                        "where seekerID = @id and status = 'job started'";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Proposal
                            {
                                ProjectId = reader.GetInt32(0),
                                ProposalId = reader.GetInt32(1),
                                SeekerId = reader.GetInt32(2),
                                PaymentAmount = reader.GetDecimal(3),
                                Status = reader.GetString(4),
                                CreatedDate = reader.GetDateTime(5),
                                Message = reader.GetString(6)
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
            return listP;
        }

        //fix lai query
        public List<Proposal> getListProposalSentToHirerID(int ProjectID)
        {
            List<Proposal> listP = new List<Proposal>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select A.proposalID, A.projectID, A.seekerID, A.paymentAmount, A.status, A.createdDate, A.message from Proposal A where status = 'proposal sent' AND A.projectID = @id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", ProjectID);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Proposal
                            {
                                ProposalId = reader.GetInt32(0),
                                ProjectId = reader.GetInt32(1),
                                SeekerId = reader.GetInt32(2),
                                PaymentAmount = reader.GetDecimal(3),
                                Status = reader.GetString(4),
                                CreatedDate = reader.GetDateTime(5),
                                Message = reader.GetString(6)
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
            return listP;
        }

        public List<Proposal> getListProposalAcceptedByHirerID(int HirerID)
        {
            List<Proposal> listP = new List<Proposal>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select A.proposalID, A.projectID, A.seekerID, A.paymentAmount, A.status, A.createdDate, A.message, B.projectName, B.description, B.location, B.complexity, B.expectedDuration, B.createdDate, D.fullName, C.major, D.phone  from Proposal A, Project B, Seeker C, [User] D where A.projectID = B.projectID and A.seekerID = C.seekerID and D.userID = C.seekerID  and status = 'job started' AND B.hirerID = @id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", HirerID);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Proposal
                            {
                                ProposalId = reader.GetInt32(0),
                                ProjectId = reader.GetInt32(1),
                                SeekerId = reader.GetInt32(2),
                                PaymentAmount = reader.GetDecimal(3),
                                Status = reader.GetString(4),
                                CreatedDate = reader.GetDateTime(5),
                                Message = reader.GetString(6),
                                Project = new Project
                                {
                                    ProjectName = reader.GetString(7),
                                    Description = reader.GetString(8),
                                    Location = reader.GetString(9),
                                    Complexity = reader.GetString(10),
                                    ExpectedDuration = reader.GetString(11),
                                    CreatedDate = reader.GetDateTime(12),

                                },
                                Seeker = new Seeker
                                {
                                    FullName = reader.GetString(13),
                                    Major = reader.GetString(14),
                                    Phone = reader.GetString(15),
                                },
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
            return listP;
        }

        public bool createProposal(Proposal proposal)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "insert into Proposal(projectID, seekerID, paymentAmount, status, message) " +
                        "values(@projectID, @seekerID, @paymentAmount, @status, @message)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@projectID", proposal.ProjectId);
                    commad.Parameters.AddWithValue("@seekerID", proposal.SeekerId);
                    commad.Parameters.AddWithValue("@paymentAmount", proposal.PaymentAmount);
                    commad.Parameters.AddWithValue("@status", proposal.Status);
                    commad.Parameters.AddWithValue("@message", proposal.Message);
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

        public bool UpdateStatus(int ProposalID, string status)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "UPDATE Proposal SET status = @status FROM PROPOSAL WHERE proposalID = @id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@status", status);
                    commad.Parameters.AddWithValue("@id", ProposalID);
                    
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

        public bool Update(Proposal Proposal, string status)
        {



            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "UPDATE Proposal SET status = @status where proposalID = @id";
                    commad = new SqlCommand(sql, connect);

                    commad.Parameters.AddWithValue("@status", status);

                    commad.Parameters.AddWithValue("@id", Proposal.ProposalId);
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

        public Proposal getJobApply(int projectid, int seekerid)
        {
            Proposal proposal = null;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select paymentAmount, message " +
                        "from Proposal " +
                        "where projectID = @proid and seekerID = @seekerid";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@proid", projectid);
                    commad.Parameters.AddWithValue("@seekerid", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            proposal = new Proposal
                            {
                                PaymentAmount = reader.GetDecimal(0),
                                Message = reader.GetString(1)
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
            return proposal;
        }

        public bool deleteProposal(Proposal proposal)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "delete Proposal " +
                        "where projectID = @projectID and seekerID = @seekerID";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@projectID", proposal.ProjectId);
                    commad.Parameters.AddWithValue("@seekerID", proposal.SeekerId);
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
