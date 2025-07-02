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
    public class LkPubilsherService : IGenericService<LkPubilsherVM>
    {
        private readonly IGenericRepo<LkPubilsherVM> _lkPubilsher;

        public LkPubilsherService(IGenericRepo<LkPubilsherVM> lkPubilsher)
        {
            _lkPubilsher = lkPubilsher;
        }
        public decimal Add(LkPubilsherVM entity)
        {
            throw new NotImplementedException();
        }

        public decimal Deactivate(int id)
        {
            throw new NotImplementedException();
        }

        public LkPubilsherVM Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<LkPubilsherVM> GetAllList(int id = 0)
        {
            throw new NotImplementedException();
        }

        public IList<CustomOption> GetDropList(string id = "0")
        {
            throw new NotImplementedException();
        }

        public decimal Update(LkPubilsherVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
