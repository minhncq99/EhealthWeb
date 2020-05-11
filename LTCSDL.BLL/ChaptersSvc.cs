using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;

namespace LTCSDL.BLL
{
    public class ChaptersSvc : GenericSvc<ChaptersRep, Chapter>
    {
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        public override SingleRsp Update(Chapter m)
        {
            var res = new SingleRsp();

            var m1 = m.ChapterId > 0 ? _rep.Read(m.ChapterId) : null;
            if(m1 == null)
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
    }
}
