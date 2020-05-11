using LTCSDL.DAL.Models;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.Common.Rsp;
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

        public override SingleRsp Update(Number m)
        {
            var res = new SingleRsp();

            var m1 = m.NumberId > 0 ? _rep.Read(m.NumberId) : null;

            if (m1 != null)
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
        #endregion
    }
}
