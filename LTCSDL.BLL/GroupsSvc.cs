using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.Common.Rsp;
using LTCSDL.Common.Req;

namespace LTCSDL.BLL
{
    public class GroupsSvc : GenericSvc<GroupsRep, Group>
    {
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            var m = _rep.Read(id);
            res.Data = m;
                
            return res;
        }

        public SingleRsp CreateGroup(string GroupName, int ChapterId)
        {
            var res = _rep.CreateGroup(GroupName, ChapterId);
            return res;
        }

        public SingleRsp UpdateGroup(int GroupId, string GroupName, int ChapterId)
        {
            var res = _rep.UpdateGroup(GroupId, GroupName, ChapterId);
            return res;
        }

        public SingleRsp GetGroupByChapterId(int chapterId)
        {
            var res = _rep.GetGroupByChapterId(chapterId);
            return res;
        }

        public SingleRsp DeleteGroup(int chapterId)
        {
            var res = _rep.DeleteGroup(chapterId);
            return res;
        }
    }
}
