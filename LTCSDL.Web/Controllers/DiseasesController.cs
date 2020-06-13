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

        [HttpGet("get-all")]
        public IActionResult getAllDiseases()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;

            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult getDiseaseById(int id)
        {
            var res = _svc.Read(id);

            return Ok(res);
        }
        
        [HttpPost("create")]
        public IActionResult createDisease([FromBody]DiseaseReq req)
        {
            var res = _svc.CreateDisease(req.EnglishName, req.VietnameseName, req.Symptom, req.NumberId);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult updateDisease([FromBody]DiseaseReq req)
        {
            var res = _svc.UpdateDisease(req.DiseaseId, req.EnglishName, req.VietnameseName, req.Symptom, req.NumberId);

            return Ok(res);
        }

        [HttpGet("get-by-number-id/{id}")]
        public IActionResult getDiseaseByNumberId(int id)
        {
            var res = _svc.GetDiseaseByNumberId(id);

            return Ok(res);
        }

        [HttpGet("get-by-chaper-id")]
        public IActionResult getDiseaseByChapterId(int id)
        {
            var res = _svc.GetDiseaseByChapterId(id);

            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult deleteDisease([FromBody]SimpleReq req)
        {
            var res = _svc.DeleteDisease(req.Id);

            return Ok(res);
        }


        [HttpPost("search-vietnamese-name")]
        public IActionResult deleteDisease(SearchReq req)
        {
            var res = _svc.SearchChapterVietnameseName(req.Keyword, req.Page, req.Size);

            return Ok(res);
        }
        private readonly DiseasesSvc _svc;
    }
}