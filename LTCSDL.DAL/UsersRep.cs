using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using System;
using LTCSDL.Common.Rsp;
namespace LTCSDL.DAL
{
    public class UsersRep : GenericRep<EhealthContext, User>
    {
        #region -- Overide --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override User Read(int id)
        {
            var res = All.FirstOrDefault(p => p.UserId == id);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Remove(int id)
        {
            var m = All.First(p => p.UserId == id);
            m = base.Delete(m);
            return m.UserId;
        }


        #endregion

        #region -- Methods --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SingleRsp CreateUser(User user)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Users.Add(user);
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

        public SingleRsp UpdateUser(User user)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Users.Update(user);
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

        public SingleRsp DeleteUser(int userId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Users.Find(userId);
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
