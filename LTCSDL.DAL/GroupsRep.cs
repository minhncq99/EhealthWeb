using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;

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
    }
}
