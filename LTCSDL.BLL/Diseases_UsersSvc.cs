using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;
using LTCSDL.Common.Req;
using System.Linq;

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

        public override SingleRsp Update(Disease_User du)
        {
            var res = new SingleRsp();

            var m1 = du.UserId > 0 && du.DiseaseId > 0 ? _rep.Read(du.UserId, du.DiseaseId) : null;
            if (m1 == null)
            {
                res.SetError("EZ103", "No data");
            }
            else
            {
                res = base.Update(du);
                res.Data = du;
            }
            return base.Update(du);
        }

        public SingleRsp CreateDU(Diseases_UsersReq req)
        {
            var res = new SingleRsp();
            Disease_User du = new Disease_User();
            du.DiseaseId = req.DiseaseId;
            du.UserId = req.UserId;
            du.Saved = req.Saved;
            res = _rep.CreateDiseasesUsers(du);

            return res;
        }

        public SingleRsp UpdateDU(Diseases_UsersReq duReq)
        {
            var res = new SingleRsp();
            Disease_User du = new Disease_User();
            du.DiseaseId = duReq.DiseaseId;
            du.UserId = duReq.UserId;
            du.Saved = duReq.Saved;

            res = _rep.UpdateDiseasesUsers(du);
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
    }
}
