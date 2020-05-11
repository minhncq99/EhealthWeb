using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;

namespace LTCSDL.DAL
{
    public class ChaptersRep : GenericRep<EhealthContext, Chapter>
    {
        #region -- Overide --
        public override Chapter Read(int id)
        {
            var res = All.FirstOrDefault(p => p.ChapterId == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = All.First(p => p.ChapterId == id);
            m = base.Delete(m);
            return m.ChapterId;
        }
        #endregion
    }
}
