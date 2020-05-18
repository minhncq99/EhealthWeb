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

        public override SingleRsp Update(Group m)
        {
            var res = new SingleRsp();

            var m1 = m.GroupId > 0 ? _rep.Read(m.GroupId) : null;
            if(m1 == null)
            {
                res.SetError("EZ103", "No data");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }
            return res;
        }

        public SingleRsp CreateGroup(GroupReq groupsReq)
        {
            var res = new SingleRsp();
            Group group = new Group();
            group.GroupId = groupsReq.GroupId;
            group.Name = groupsReq.Name;
            group.ChapterId = groupsReq.ChapterId;
            res = _rep.CreateGroup(group);
            return res;
        }

        public SingleRsp UpdateGroup(GroupReq groupsReq)
        {
            var res = new SingleRsp();
            Group group = new Group();
            group.GroupId = groupsReq.GroupId;
            group.Name = groupsReq.Name;
            group.ChapterId = groupsReq.ChapterId;
            res = _rep.UpdateGroup(group);
            return res;
        }

        public SingleRsp GetGroupByChapterId(int chapterId)
        {
            var res = new SingleRsp();
            res = _rep.GetGroupByChapterId(chapterId);
            return res;
        }

        public SingleRsp DeleteGroup(int chapterId)
        {
            var res = new SingleRsp();
            res = _rep.DeleteGroup(chapterId);
            return res;
        }
    }
}
