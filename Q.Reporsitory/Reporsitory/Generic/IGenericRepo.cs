using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q.VM.HelperClasses;

namespace Q.Reporsitory.Reporsitory.Generic
{
    public interface IGenericRepo<TEntity>
    {
        public decimal Add(TEntity entity);
        public decimal Update(TEntity entity);
        public decimal Deactivate(int id);
        public IList<CustomOption> GetDropList(string id = "0");
        public IList<TEntity> GetAllList(int id = 0);
        public TEntity Find(int id);

    }
}
