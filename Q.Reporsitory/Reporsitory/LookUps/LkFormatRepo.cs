using AutoMapper;
using Q.EF.Models;
using Q.Reporsitory.Reporsitory.Generic;
using Q.VM.HelperClasses;
using Q.VM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.Reporsitory.Reporsitory.LookUps
{
    public class LkFormatRepo : IGenericRepo<LkFormatVM>
    { private readonly IMapper _mapper;
        public LkFormatRepo(IMapper mapper) {
            _mapper = mapper;
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
                QARATOKATABNContext qdb = new QARATOKATABNContext();
                var objLst = (from x in qdb.LkFormats
                             select new CustomOption { 
                                 Id = x.Id.ToString(),
                                 NameAr = x.Name
                             }).ToList();
                return objLst;

            }
            catch(Exception ex) {
                //
                return null;
            }
        }

        public decimal Update(LkFormatVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
