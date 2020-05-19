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

        [HttpGet("get-by-id/{id}")]
        public IActionResult getNumberById(int id)
        {
            var res = new SingleRsp();
            res = _svc.Read(id);

            return Ok(res);
        }

        [HttpGet("get-all")]
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

        [HttpPut("update")]
        public IActionResult updateNumber([FromBody]NumberReq req)
        {
            var res = _svc.UpdateNumber(req);

            return Ok(res);
        }

        [HttpGet("get-by-group-id/{id}")]
        public IActionResult getNumberByGroupId(int id)
        {
            var res = new SingleRsp();
            res = _svc.GetNumberByGroupId(id);

            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult deleteNumber([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.DeleteNumber(req.Id);

            return Ok(res);
        }
        private readonly NumbersSvc _svc;
    }
}