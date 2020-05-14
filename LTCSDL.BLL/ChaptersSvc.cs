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

        public SingleRsp CreateChapter(ChapterReq chapterReq)
        {
            var res = new SingleRsp();
            Chapter chapter = new Chapter();
            chapter.ChapterId = chapterReq.ChapterId;
            chapter.Name = chapterReq.Name;
            res = _rep.CreateChapter(chapter);
            return res;
        }

        public SingleRsp UpdateChapter(ChapterReq chapterReq)
        {
            var res = new SingleRsp();
            Chapter chapter = new Chapter();
            chapter.ChapterId = chapterReq.ChapterId;
            chapter.Name = chapterReq.Name;
            res = _rep.UpdateChapter(chapter);
            return res;
        }

        public override SingleRsp Delete(int id)
        {
            var res = new SingleRsp();
            var m = _rep.DeleteChapter(id);
            res.Data = m;

            return res;
        }

        public object SearchChapter(string keyword, int page, int size)
        {
            var chap = All.Where(x => x.Name.Contains(keyword));
            var offset = (page - 1) * size;
            var total = chap.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = chap.OrderBy(x => x.Name).Skip(offset).Take(size).ToList();

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
