using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Req;
using System.Linq;

namespace LTCSDL.BLL
{
    public class UsersSvc : GenericSvc<UsersRep, User>
    {
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        public override SingleRsp Update(User m)
        {
            var res = new SingleRsp();

            var m1 = m.UserId > 0 ? _rep.Read(m.UserId) : null;
            if (m1 == null)
            {
                res.SetError("EZ103", "No data");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }
            return base.Update(m);
        }

        public SingleRsp CreateUser(UserReq userReq)
        {
            var res = new SingleRsp();
            User user = new User();
            user.FullName = userReq.FullName;
            user.UserName = userReq.UserName;
            user.Password = userReq.Password;
            user.Email = userReq.Email;
            user.Job = userReq.Job;
            user.TypeUser = userReq.TypeUser;
            res = _rep.CreateUser(user);

            return res;
        }

        public SingleRsp UpdateUser(UserReq userReq)
        {
            var res = new SingleRsp();
            User user = new User();
            user.UserId = userReq.UserId;
            user.FullName = userReq.FullName;
            user.UserName = userReq.UserName;
            user.Password = userReq.Password;
            user.Email = userReq.Email;
            user.Job = userReq.Job;
            res = _rep.UpdateUser(user);
            return res;
        }

        public override SingleRsp Delete(int id)
        {
            var res = new SingleRsp();
            var m = _rep.DeleteUser(id);

            return res;
        }

        public object SearchUserName(string keyword, int page, int size)
        {
            var user = All.Where(x => x.UserName.Contains(keyword));
            var offset = (page - 1) * size;
            var total = user.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = user.OrderBy(x => x.UserName).Skip(offset).Take(size).ToList();

            var res = new
            {
                Data = data,
                TotalRecord = total,
                TotalPage = totalPage,
                Page = page,
                Size = size,
            };

            return res;
        }
    }
}
