using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;

namespace LTCSDL.DAL
{
    public class NumbersRep : GenericRep<EhealthContext, Number>
    {
        #region -- Override
        public override Number Read(int id)
        {
            var res = All.FirstOrDefault(p => p.NumberId == id);
            return res;
        }

        public int Remove(int id)
        {
            var res = All.First(p => p.NumberId == id);
            res = base.Delete(res);
            return res.NumberId;
        }

        #endregion
    }
}
