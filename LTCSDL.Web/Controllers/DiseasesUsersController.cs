using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTCSDL.BLL;
using LTCSDL.Common.Req;
using LTCSDL.Common.Rsp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LTCSDL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseasesUsersController : ControllerBase
    {
        public DiseasesUsersController()
        {
            _svc = new Diseases_UsersSvc();
        }

        [HttpGet("get-all")]
        public IActionResult getAllDU()
        {
            var res = new SingleRsp();
            var t = _svc.All;
            res.Data = t;

            return Ok(res);
        }

        [HttpGet("get-by-id/{userId}/{diseaseId}")]
        public IActionResult getById(int userId, int diseaseId)
        {
            var res = _svc.Read(userId, diseaseId);

            return Ok(res);
        }
        

        [HttpPost("create")]
        public IActionResult Create([FromBody]Diseases_UsersReq req)
        {
            var res = _svc.CreateDU(req);

            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody]Diseases_UsersReq req)
        {
            var res = _svc.UpdateDU(req);

            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody]Diseases_UsersReq req)
        {
            var res = _svc.Delete(req.UserId, req.DiseaseId);

            return Ok(res);
        }

        [HttpGet("get-by-user-id/{userId}")]
        public IActionResult getByUserId(int userId)
        {
            var res = _svc.getByUserId(userId);

            return Ok(res);
        }

        [HttpGet("get-by-disease-id/{diseaseId}")]
        public IActionResult getByDiseaseId(int diseaseId)
        {
            var res = _svc.getByDiseaseId(diseaseId);

            return Ok(res);
        }

        [HttpGet("get-top-10")]
        public IActionResult getTop10()
        {
            var res = _svc.getTop10Disease();

            return Ok(res);
        }

        private readonly Diseases_UsersSvc _svc;
    }
}