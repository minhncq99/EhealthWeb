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
            var res = _svc.Read(id);

            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult createUser([FromBody]UserReq req)
        {

            var res = _svc.CreateUser(req.FullName, req.UserName, req.Password, req.Email, req.Job, req.TypeUser);

            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult updateUser(UserReq req)
        {
            var res = _svc.UpdateUser(req.UserId ,req.FullName, req.UserName, req.Password, req.Email, req.Job, req.TypeUser);

            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult deleteUser([FromBody]UserReq req)
        {
            var res = _svc.Delete(req.UserId);
            return Ok(res);
        }

        private readonly UsersSvc _svc;
    }
}