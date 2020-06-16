using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Req;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LTCSDL.BLL
{
    public class Diseases_UsersSvc : GenericSvc<Diseases_UsersRep, Disease_User>
    {
        public SingleRsp Read(int userId, int diseaseId)
        {
            var res = new SingleRsp();
            var m = _rep.Read(userId, diseaseId);
            res.Data = m;

            return res;
        }

        public SingleRsp CreateDU(Diseases_UsersReq req)
        {
            var res = _rep.CreateDiseasesUsers(req.DiseaseId, req.UserId, req.Saved);

            return res;
        }

        public SingleRsp UpdateDU(Diseases_UsersReq req)
        {
            var res = _rep.UpdateDiseasesUsers(req.DiseaseId, req.UserId, req.Saved);
            return res;
        }

        public SingleRsp Delete(int userId, int diseaseId)
        {
            var res = _rep.DeleteDiseasesUsers(userId, diseaseId);

            return res;
        }

        public SingleRsp getByUserId(int userId)
        {
            var res = _rep.getByUserId(userId);
            return res;
        }

        public SingleRsp getByDiseaseId(int diseaseId)
        {
            var res = _rep.getByDiseaseId(diseaseId);
            return res;
        }

        public SingleRsp getTop10Disease()
        {
            var res = _rep.getTop10();

            return res;
        }

        public List<object> SUM_Diseasea_Saved()
        {
            return base._rep.SUM_Diseasea_Saved();
        }
    }
}
