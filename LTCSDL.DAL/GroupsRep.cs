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
        public SingleRsp CreateGroup(string GroupName, int ChapterId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        Group NewGroup = new Group();
                        NewGroup.Name = GroupName;
                        NewGroup.ChapterId = ChapterId;
                        var t = context.Groups.Add(NewGroup);
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

        public SingleRsp UpdateGroup(int GroupId, string GroupName, int ChapterId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Groups.Find(GroupId);
                        if (res.Data == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            Group NewGroup = new Group();
                            NewGroup.GroupId = GroupId;
                            NewGroup.Name = GroupName;
                            NewGroup.ChapterId = ChapterId;
                            context.Entry(res.Data).CurrentValues.SetValues(NewGroup);
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
                        res.Data = context.Groups.Find(groupId);
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
