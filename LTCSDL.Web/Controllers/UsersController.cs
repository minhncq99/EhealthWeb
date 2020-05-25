using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTCSDL.BLL;
using LTCSDL.Common.Req;
using LTCSDL.Common.Rsp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
            _svc = new UsersSvc();
        }

        [HttpGet("get-all")]
        public IActionResult getAllUser()
        {
            var res = new SingleRsp();

            res.Data = _svc.All;

            return Ok(res);
        }

        [HttpGet("get-by-user-id/{id}")]
        public IActionResult getUserById(int id)
        {
            var res = new SingleRsp();

            res.Data = _svc.Read(id);

            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult createUser(UserReq userReq)
        {
            var res = new SingleRsp();

            res.Data = _svc.CreateUser(userReq);

            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult updateUser(UserReq req)
        {
            var res = new SingleRsp();

            res.Data = _svc.UpdateUser(req);

            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult deleteUser([FromBody]UserReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.Delete(req.UserId);
            return Ok(res);
        }

        private readonly UsersSvc _svc;
    }
}