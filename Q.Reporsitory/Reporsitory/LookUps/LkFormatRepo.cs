using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Q.EF.Models;
using Q.Reporsitory.Reporsitory.Generic;
using Q.VM.HelperClasses;
using Q.VM.ViewModels;

namespace Q.Reporsitory.Reporsitory.LookUps
{
    public class LkFormatRepo : IGenericRepo<LkFormatVM>
    {
        private readonly IMapper _mapper;
        public LkFormatRepo(IMapper mapper)
        {
            _mapper = mapper;
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


                QARATOKATABNContext qdb = new QARATOKATABNContext();
                var objLst = await (from x in qdb.LkFormats
                                    select new CustomOption
                                    {
                                        Id = x.Id.ToString(),
                                        NameAr = x.Name
                                    }).ToListAsync();
                return objLst;

            }
            catch (Exception ex)
            {
                //
                return null;
            }
        }

        public Task<decimal> Update(LkFormatVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
