using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;

namespace LTCSDL.DAL
{
    public class DiseasesRep : GenericRep<EhealthContext, Disease>
    {
        #region -- Override --
        public override Disease Read(int id)
        {
            var res = All.FirstOrDefault(p => p.DiseaseId == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = base.All.First(p => p.DiseaseId == id);
            m = base.Delete(m);
            return m.DiseaseId;
        }

        #endregion
    }
}
