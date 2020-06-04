using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using System;
using LTCSDL.Common.Rsp;
using System.Dynamic;
using System.Security.Cryptography;

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
        public SingleRsp CreateDiseasesUsers(Disease_User du)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
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

        public SingleRsp UpdateDiseasesUsers(Disease_User du)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Diseases_Users
                            .FirstOrDefault(p => p.UserId == du.UserId && p.DiseaseId == du.DiseaseId);


                        if (t == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            context.Entry(t).CurrentValues.SetValues(du);

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
                        var t = context.Diseases_Users.FirstOrDefault(p => p.DiseaseId == diseaseId && p.UserId == userId);
                        context.Remove(t);
                        res.Data = t;
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
        #endregion
    }
}
