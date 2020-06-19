using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Req;
using System.Linq;
using System.Collections.Generic;

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


        public SingleRsp CreateUser(string FullName, string UserName, string Password,
            string Email, string Job, int TypeUser)
        {
            var res = _rep.CreateUser(FullName, UserName, Password, Email, Job, TypeUser);

            return res;
        }

        public SingleRsp UpdateUser(int UserId, string FullName, string UserName, string Password,
            string Email, string Job, int TypeUser)
        {
            var res = _rep.UpdateUser(UserId, FullName, UserName, Password, Email, Job, TypeUser);
            return res;
        }

        public override SingleRsp Delete(int id)
        {
            var res = _rep.DeleteUser(id);

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

        public object checkTypeUser(int userId)
        {
            return base._rep.checkTypeUser(userId);
        }
    }
}
