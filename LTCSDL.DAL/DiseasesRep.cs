using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Rsp;
using System;

namespace LTCSDL.DAL
{
    public class DiseasesRep : GenericRep<EhealthContext, Disease>
    {
        #region -- Override --
        public override Disease Read(int id)
        {
            var res = All.FirstOrDefault(p => p.DiseaseId == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = base.All.First(p => p.DiseaseId == id);
            m = base.Delete(m);
            return m.DiseaseId;
        }

        #endregion

        #region
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SingleRsp CreateDisease(Disease disease)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Diseases.Add(disease);
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

        public SingleRsp UpdateDisease(Disease disease)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Diseases.Update(disease);
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

        public SingleRsp GetDiseaseByNumberId(int numberId)
        {
            var res = new SingleRsp();
            res.Data = All.Where(p => p.NumberId == numberId);
            return res;
        }

        #endregion
    }
}
