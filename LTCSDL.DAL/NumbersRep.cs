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
        public SingleRsp CreateNumber(string Name, int GroupId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        Number newNumber = new Number();
                        newNumber.Name = Name;
                        newNumber.GroupId = GroupId;
                        var t = context.Numbers.Add(newNumber);
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

        public SingleRsp UpdateNumber(int NumberId, string Name, int GroupId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Numbers.Find(NumberId);
                        if (res.Data == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            Number newNumber = new Number();
                            newNumber.NumberId = NumberId;
                            newNumber.Name = Name;
                            newNumber.GroupId = GroupId;
                            context.Entry(res.Data).CurrentValues.SetValues(newNumber);

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

        public SingleRsp GetNumberByGroupId(int groupId)
        {
            var res = new SingleRsp();
            res.Data = All.Where(p => p.GroupId == groupId);
            return res;
        }

        public SingleRsp DeleteNumber(int numberId)
        {
            var res = new SingleRsp();

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Numbers.Find(numberId);
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
