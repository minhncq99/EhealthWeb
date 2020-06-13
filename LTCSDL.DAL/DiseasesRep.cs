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
        public SingleRsp CreateDisease(string EnglishName, string VietnameseName, 
            string Symptom, int NumberId)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        Disease newDisease = new Disease();
                        newDisease.EnglishName = EnglishName;
                        newDisease.VietnameseName = VietnameseName;
                        newDisease.Symptom = Symptom;
                        newDisease.NumberId = NumberId;
                        var t = context.Diseases.Add(newDisease);
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

        public SingleRsp UpdateDisease(int DiseaseId, string EnglishName, 
            string VietnameseName, string Symptom, int NumberId)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Diseases.Find(DiseaseId);
                        if (res.Data == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            Disease newDisease = new Disease();
                            newDisease.DiseaseId = DiseaseId;
                            newDisease.EnglishName = EnglishName;
                            newDisease.VietnameseName = VietnameseName;
                            newDisease.Symptom = Symptom;
                            newDisease.NumberId = NumberId;

                            context.Entry(res.Data).CurrentValues.SetValues(newDisease);

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

        public SingleRsp GetDiseaseByNumberId(int numberId)
        {
            var res = new SingleRsp();
            res.Data = All.Where(p => p.NumberId == numberId);
            return res;
        }

        public SingleRsp GetDiseaseByChapterId(int chapterId)
        {
            var res = new SingleRsp();
            var context = new EhealthContext();
            
            res.Data = context.Diseases
                .Join(
                    context.Numbers,
                    disease => disease.DiseaseId,
                    number => number.NumberId,
                    (disease, number) => new { disease, number }
                ).Join(
                    context.Groups,
                    x => x.number.NumberId,
                    group => group.GroupId,
                    (x, group) => new
                    {
                        name = x.disease.DiseaseId,
                        EnglishName = x.disease.EnglishName,
                        VietnameseName = x.disease.VietnameseName,
                        Symptom = x.disease.Symptom,
                        ChapterId = group.ChapterId,
                    }
                ).Where(p => p.ChapterId == chapterId);
            return res;
        }

        public SingleRsp DeleteDisease(int diseaseId)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Diseases.Find(diseaseId);
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
        #endregion
    }
}
