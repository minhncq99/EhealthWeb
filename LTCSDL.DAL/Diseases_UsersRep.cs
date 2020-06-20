using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using System;
using LTCSDL.Common.Rsp;
using System.Dynamic;
using System.Security.Cryptography;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace LTCSDL.DAL
{
    public class Diseases_UsersRep : GenericRep<EhealthContext, Disease_User>
    {
        #region -- Overide --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Disease_User Read(int userId, int diseaseId)
        {
            var res = All.FirstOrDefault(p => p.UserId == userId && p.DiseaseId == diseaseId);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Remove(int userId, int diseaseId)
        {
            var m = All.First(p => p.UserId == userId && p.DiseaseId == diseaseId);
            m = base.Delete(m);
            return m.UserId;
        }

        #endregion

        #region -- Methods --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SingleRsp CreateDiseasesUsers(int DiseaseId, int UserId, bool Saved)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        Disease_User du = new Disease_User();
                        du.DiseaseId = DiseaseId;
                        du.UserId = UserId;
                        du.Saved = Saved;
                        var t = context.Diseases_Users.Add(du);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

       

        public SingleRsp UpdateDiseasesUsers(int DiseaseId, int UserId, bool Saved)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Diseases_Users
                            .FirstOrDefault(p => p.UserId == UserId && p.DiseaseId == DiseaseId);


                        if (res.Data == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            Disease_User du = new Disease_User();
                            du.DiseaseId = DiseaseId;
                            du.UserId = UserId;
                            du.Saved = Saved;
                            context.Entry(res.Data).CurrentValues.SetValues(du);

                            context.SaveChanges();
                            tran.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp DeleteDiseasesUsers(int userId, int diseaseId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Diseases_Users.FirstOrDefault(p => p.DiseaseId == diseaseId && p.UserId == userId);
                        context.Remove(res.Data);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp getByUserId(int userId)
        {
            var res = new SingleRsp();
            var t = All.Where(p => p.UserId == userId);
            res.Data = t;

            return res;
        }

        public SingleRsp getByDiseaseId(int diseaseId)
        {
            var res = new SingleRsp();
            var t = All.Where(p => p.DiseaseId == diseaseId);
            res.Data = t;

            return res;
        }

        public SingleRsp getTop10()
        {
            var res = new SingleRsp();
            var t = All.Where(x => x.Saved == true)
                    .GroupBy(x => x.DiseaseId)
                    .Select(t => new {Disease = t.Key, Count = t.Count()})
                    .OrderByDescending(z => z.Count)
                    .Take(10)
                    .ToList();
            res.Data = t;

            return res;
        }

        public List<object> Count_Diseasea_Saved()
        {
            List<object> res = new List<object>();
            var cnn = (SqlConnection)Context.Database.GetDbConnection();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "percentDisease";
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var x = new
                        {
                            VietnameseName = row["VietnameseName"],
                            SumDiseaseSaved = row["SumDiseaseSaved"],
                        };
                        res.Add(x);
                    }
                }
            }
            catch (Exception)
            {
                res = null;
            }
            return res;
        }
        #endregion
    }
}
