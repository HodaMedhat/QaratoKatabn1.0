using AutoMapper;
using Q.EF.Models;
using Q.Reporsitory.Reporsitory.Generic;
using Q.VM.HelperClasses;
using Q.VM.ViewModels;

namespace Q.Service.Service.LookUps
{
    public class LkAuthorRepo : IGenericRepo<LkAuthorVM>
    {
        private readonly IMapper _mapper;
        public LkAuthorRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<decimal> Add(LkAuthorVM entity)
        {
            try
            {
                QARATOKATABNContext qdb = new QARATOKATABNContext();
                qdb.Add(entity);
                await qdb.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public Task<decimal> Deactivate(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LkAuthorVM> Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<LkAuthorVM>> GetAllList(int id = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomOption>> GetDropList(string id = "0")
        {
            throw new NotImplementedException();
        }

        public Task<decimal> Update(LkAuthorVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
