using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("get-all")]
        public IActionResult getAllGroups()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }


        [HttpGet("get-by-id/{id}")]
        public IActionResult getGroupById(int id)
        {
            var res = _svc.Read(id);

            return Ok(res);
        }
    
        [HttpPost("create")]
        public IActionResult createGroup([FromBody]GroupReq req)
        {
            var res = _svc.CreateGroup(req.Name, req.ChapterId);

            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult updateGroup([FromBody]GroupReq req)
        {
            var res = _svc.UpdateGroup(req.GroupId, req.Name, req.ChapterId);

            return Ok(res);
        }

        [HttpGet("get-by-chapter-id/{id}")]
        public IActionResult getGroupByChapterId(int id)
        {
            var res = _svc.GetGroupByChapterId(id);

            return Ok(res);
        }

        [HttpDelete("delete-group")]
        public IActionResult deleteGroup([FromBody]SimpleReq req)
        {
            var res = _svc.DeleteGroup(req.Id);

            return Ok(res);
        }

        private readonly GroupsSvc _svc;
    }
}