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

        private readonly ChaptersSvc _svc;
    }
}