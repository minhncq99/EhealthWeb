using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        public NumbersController()
        {
            _svc = new NumbersSvc();
        }

        [HttpPost("get-by-id")]
        public IActionResult getNumberById([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);

            return Ok(res);
        }

        [HttpPost("get-all")]
        public IActionResult getAllNumbers()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }
        private readonly NumbersSvc _svc;
    }
}