using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.Common.Rsp;

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
    }
}
