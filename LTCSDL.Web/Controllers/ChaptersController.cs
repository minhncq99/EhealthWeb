using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        public ChaptersController()
        {
            _svc = new ChaptersSvc();
        }

        [HttpPost("get-by-id")]
        public IActionResult getChaperById([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);

            return Ok(res);
        }

        [HttpPost("get-all")]
        public IActionResult getAllChapters()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult createChapter([FromBody]ChapterReq req)
        {
            var res = _svc.CreateChapter(req);

            return Ok(res);
        }

        [HttpPost("update")]
        public IActionResult updateChapter([FromBody]ChapterReq req)
        {
            var res = _svc.UpdateChapter(req);

            return Ok(res);
        }

        [HttpPost("delete")]
        public IActionResult deleteChapter([FromBody]ChapterReq req)
        {
            var res = _svc.Delete(req.ChapterId);

            return Ok(res);
        }

        [HttpPost("search")]
        public IActionResult searchChapter(SearchChapterReq req)
        {
            var res = _svc.SearchChapter(req.Keyword, req.Page, req.Size);

            return Ok(res);
        }
        private readonly ChaptersSvc _svc;
    }
}