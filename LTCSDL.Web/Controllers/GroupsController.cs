﻿using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        public GroupsController()
        {
            _svc = new GroupsSvc();
        }

        [HttpPost("get-by-id")]
        public IActionResult getGroupById([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);

            return Ok(res);
        }
    
        [HttpPost("get-all")]
        public IActionResult getAllGroups()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }
        private readonly GroupsSvc _svc;
    }
}