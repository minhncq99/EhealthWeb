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

        [HttpPost("create")]
        public IActionResult createNumber([FromBody]NumberReq req)
        {
            var res = _svc.CreateNumber(req);

            return Ok(res);
        }

        [HttpPost("update")]
        public IActionResult updateNumber([FromBody]NumberReq req)
        {
            var res = _svc.UpdateNumber(req);

            return Ok(res);
        }

        [HttpPost("get-by-group-id")]
        public IActionResult getNumberByGroupId([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.GetNumberByGroupId(req.Id);

            return Ok(res);
        }

        [HttpPost("delete")]
        public IActionResult deleteNumber([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.DeleteNumber(req.Id);

            return Ok(res);
        }
        private readonly NumbersSvc _svc;
    }
}