using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Rsp;
using System;

namespace LTCSDL.DAL
{
    public class GroupsRep : GenericRep<EhealthContext, Group>
    {
        #region -- Group --
        public override Group Read(int id)
        {
            var res = All.FirstOrDefault(p => p.GroupId == id);
            return res;
        }

        public int Remove(int id)
        {
            var res = All.First(p => p.GroupId == id);
            res = base.Delete(res);
            return res.GroupId;
        }

        #endregion

        #region -- Methods --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SingleRsp CreateGroup(Group gr)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Groups.Add(gr);
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

        public SingleRsp UpdateGroup(Group gr)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Groups.Update(gr);
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

        public SingleRsp GetGroupByChapterId(int chapterId)
        {
            var res = new SingleRsp();
            var m = All.Where(p => p.ChapterId == chapterId);
            res.Data = m;
            return res;
        }

        public SingleRsp DeleteGroup(int groupId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Groups.Find(groupId);
                        context.Remove(t);
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
