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
    public class LkPubilsherRepo : IGenericRepo<LkPubilsherVM>
    {
        private readonly IMapper _mapper;
        public LkPubilsherRepo(IMapper mapper) { 
            _mapper = mapper;
        }
        public decimal Add(LkPubilsherVM entity)
        {
            decimal ret = 0;
            try
            {
                QARATOKATABNContext qdb = new QARATOKATABNContext();



                return ret;
            }
            catch (Exception ex)
            {
                //
                return ret;
            }
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
            try
            {
                QARATOKATABNContext qdb = new QARATOKATABNContext();
                var objLst = (from x in qdb.LkPubilshers
                              select new CustomOption
                              {
                                  Id = x.Id.ToString(),
                                  NameAr = x.Name
                              }).ToList();
                return objLst;

            }
            catch (Exception ex)
            {
                //
                return null;
            }
        }

        public decimal Update(LkPubilsherVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
