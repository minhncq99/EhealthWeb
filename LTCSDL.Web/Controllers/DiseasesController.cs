using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IActionResult getDiseaseById([FromBody] SimpleReq req)
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

        private readonly DiseasesSvc _svc;
    }
}