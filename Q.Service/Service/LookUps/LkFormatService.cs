using Q.Reporsitory.Reporsitory.Generic;
using Q.Service.Service.Generic;
using Q.VM.HelperClasses;
using Q.VM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.Service.Service.LookUps
{
    public class LkFormatService : IGenericService<LkFormatVM>
    {
        private readonly IGenericRepo<LkFormatVM> _lkFormat;
        public LkFormatService(IGenericRepo<LkFormatVM> lkFormat) {
            _lkFormat = lkFormat;
        }
        public decimal Add(LkFormatVM entity)
        {
            throw new NotImplementedException();
        }

        public decimal Deactivate(int id)
        {
            throw new NotImplementedException();
        }

        public LkFormatVM Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<LkFormatVM> GetAllList(int id = 0)
        {
            throw new NotImplementedException();
        }

        public IList<CustomOption> GetDropList(string id = "0")
        {
            try
            {
                return _lkFormat.GetDropList(id);
            }
            catch (Exception ex) {
                return null;
            }
        }

        public decimal Update(LkFormatVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
