using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class DiseasesController : ControllerBase
    {
        public DiseasesController()
        {
            _svc = new DiseasesSvc();
        }

        [HttpPost("get-by-id")]
        public IActionResult getDiseaseById([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);

            return Ok(res);
        }

        [HttpPost("get-all")]
        public IActionResult getAllDiseases()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult createDisease([FromBody]DiseaseReq req)
        {
            var res = _svc.CreateDisease(req);

            return Ok(res);
        }

        [HttpPost("update")]
        public IActionResult updateDisease([FromBody]DiseaseReq req)
        {
            var res = _svc.UpdateDisease(req);

            return Ok(res);
        }

        [HttpPost("get-by-number-id")]
        public IActionResult getDiseaseByNumberId([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.GetDiseaseByNumberId(req.Id);

            return Ok(res);
        }

        [HttpPost("delete")]
        public IActionResult deleteDisease([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.DeleteDisease(req.Id);

            return Ok(res);
        }

        private readonly DiseasesSvc _svc;
    }
}