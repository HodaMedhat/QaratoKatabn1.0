using Q.Reporsitory.Reporsitory.Generic;
using Q.Service.Service.Generic;
using Q.VM.HelperClasses;
using Q.VM.ViewModels;

namespace Q.Service.Service.LookUps
{
    public class LkFormatService : IGenericService<LkFormatVM>
    {
        private readonly IGenericRepo<LkFormatVM> _lkFormat;
        public LkFormatService(IGenericRepo<LkFormatVM> lkFormat)
        {
            _lkFormat = lkFormat;
        }
        public Task<decimal> Add(LkFormatVM entity)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> Deactivate(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LkFormatVM> Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<LkFormatVM>> GetAllList(int id = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CustomOption>> GetDropList(string id = "0")
        {
            try
            {
                return await _lkFormat.GetDropList(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<decimal> Update(LkFormatVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
