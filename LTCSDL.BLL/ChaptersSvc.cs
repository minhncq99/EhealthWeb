using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Req;
using System.Linq;

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

        public SingleRsp CreateChapter(string ChapterName)
        {
            var res = _rep.CreateChapter(ChapterName);
            return res;
        }

        public SingleRsp UpdateChapter(int ChapterId, string ChapterName)
        {
            var res = _rep.UpdateChapter(ChapterId, ChapterName);
            return res;
        }

        public override SingleRsp Delete(int id)
        {
            var res = new SingleRsp();
            res = _rep.DeleteChapter(id);

            return res;
        }

        public SingleRsp SearchChapter(string keyword, int page, int size)
        {
            var res = _rep.SearchChapter(keyword, page, size);

            return res;
        }
    }
}
