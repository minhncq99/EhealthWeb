using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Req;
using System.Linq;

namespace LTCSDL.BLL
{
    public class DiseasesSvc : GenericSvc<DiseasesRep, Disease>
    {
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        public SingleRsp CreateDisease(string EnglishName, string VietnameseName,
            string Symptom, int NumberId)
        {
            var res = _rep.CreateDisease(EnglishName, VietnameseName, Symptom, NumberId);
            return res;
        }

        public SingleRsp UpdateDisease(int DiseaseId, string EnglishName,
            string VietnameseName, string Symptom, int NumberId)
        {
            var res = _rep.UpdateDisease(DiseaseId, EnglishName, VietnameseName, Symptom, NumberId);
            return res;
        }

        public SingleRsp GetDiseaseByNumberId(int id)
        {
            var res = _rep.GetDiseaseByNumberId(id);

            return res;
        }

        public SingleRsp GetDiseaseByChapterId(int id)
        {
            var res = _rep.GetDiseaseByChapterId(id);

            return res;
        }

        public SingleRsp DeleteDisease(int diseaseId)
        {
            var res = _rep.DeleteDisease(diseaseId);

            return res;
        }

        public object SearchChapterVietnameseName(string keyword, int page, int size)
        {
            var chap = All.Where(x => x.VietnameseName.Contains(keyword));
            var offset = (page - 1) * size;
            var total = chap.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = chap.OrderBy(x => x.VietnameseName).Skip(offset).Take(size).ToList();

            var res = new
            {
                Data = data,
                TotalRecord = total,
                TotalPage = totalPage,
                Page = page,
                Size = size,
            };

            return res;
        }
    }
}
