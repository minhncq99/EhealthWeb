using System;
using System.Collections.Generic;
using System.Text;
using LTCSDL.Common.Rsp;
using LTCSDL.Common.BLL;
using LTCSDL.DAL;
using LTCSDL.DAL.Models;

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

        public override SingleRsp Update(Disease m)
        {
            var res = new SingleRsp();

            var m1 = m.DiseaseId > 0 ? _rep.Read(m.DiseaseId) : null;
            if(m1 == null)
            {
                res.SetError("EZ103", "No data");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }

            return res;
        }
    }
}
