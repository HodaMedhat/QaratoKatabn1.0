using Q.VM.HelperClasses;

namespace Q.Service.Service.Generic
{
    public interface IGenericService<TEntity>
    {
        public Task<decimal> Add(TEntity entity);
        public Task<decimal> Update(TEntity entity);
        public Task<decimal> Deactivate(int id);
        public Task<IList<CustomOption>> GetDropList(string id = "0");
        public Task<IList<TEntity>> GetAllList(int id = 0);
        public Task<TEntity> Find(int id);
    }
}
