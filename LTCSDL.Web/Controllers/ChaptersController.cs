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

        [HttpGet("get-all")]
        public IActionResult getAllChapters()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult getChaperById(int id)
        {
            var res = _svc.Read(id);

            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult createChapter([FromBody]ChapterReq req)
        {
            var res = _svc.CreateChapter(req.Name);

            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult updateChapter([FromBody]ChapterReq req)
        {
            var res = _svc.UpdateChapter(req.ChapterId, req.Name);

            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult deleteChapter([FromBody]ChapterReq req)
        {
            var res = _svc.Delete(req.ChapterId);

            return Ok(res);
        }

        [HttpPost("search")]
        public IActionResult searchChapter([FromBody]SearchReq req)
        {
            var res = _svc.SearchChapter(req.Keyword, req.Page, req.Size);

            return Ok(res);
        }
        private readonly ChaptersSvc _svc;
    }
}