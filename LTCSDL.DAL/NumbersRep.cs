using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Rsp;
using System;

namespace LTCSDL.DAL
{
    public class NumbersRep : GenericRep<EhealthContext, Number>
    {
        #region -- Override
        public override Number Read(int id)
        {
            var res = All.FirstOrDefault(p => p.NumberId == id);
            return res;
        }

        public int Remove(int id)
        {
            var res = All.First(p => p.NumberId == id);
            res = base.Delete(res);
            return res.NumberId;
        }

        #endregion

        #region
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       public SingleRsp CreateNumber(Number number)
        {
            var res = new SingleRsp();

            using(var context = new EhealthContext())
            {
                using(var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Numbers.Add(number);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch(Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }

            return res;
        }

        public SingleRsp UpdateNumber(Number number)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Numbers.Update(number);
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

        public SingleRsp GetNumberByGroupId(int groupId)
        {
            var res = new SingleRsp();
            res.Data = All.Where(p => p.GroupId == groupId);
            return res;
        }
        #endregion
    }
}
