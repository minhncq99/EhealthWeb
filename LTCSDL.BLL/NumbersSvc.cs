using LTCSDL.DAL.Models;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.Common.Rsp;
using LTCSDL.Common.Req;

namespace LTCSDL.BLL
{
    public class NumbersSvc : GenericSvc<NumbersRep, Number>
    {
        #region -- Override
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }
        #endregion

        public SingleRsp CreateNumber(string Name, int GroupId)
        {
            var res = _rep.CreateNumber(Name, GroupId);
            return res;
        }

        public SingleRsp UpdateNumber(int NumberId, string Name, int GroupId)
        {
            var res = _rep.UpdateNumber(NumberId, Name, GroupId);
            return res;
        }

        public SingleRsp GetNumberByGroupId(int groupId)
        {
            var res = _rep.GetNumberByGroupId(groupId);
            return res;
        }

        public SingleRsp DeleteNumber(int numberId)
        {
            var res = _rep.DeleteNumber(numberId);
            return res;
        }
    }
}
