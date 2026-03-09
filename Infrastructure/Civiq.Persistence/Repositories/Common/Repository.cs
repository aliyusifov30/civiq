using Civiq.Application.Interfaces.Repositories.Common;
using Civiq.Domain.Entities.Common;
using Civiq.Persistence.Contexts;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Persistence.Repositories.Common
{
    public class Repository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IMongoCollection<TEntity> _collection;
        private readonly CiviqContext _civiqContext;

        public Repository(IMongoCollection<TEntity> collection, CiviqContext civiqContext)
        {
            _collection = collection;
            _civiqContext = civiqContext;
        }

        public async Task Add(TEntity entity)
        {
            await _civiqContext.AddAsync(entity);
            await _civiqContext.SaveChangesAsync();
        }
        public void Delete(TEntity entity)
        {
            _civiqContext.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _civiqContext.Update(entity);
            _civiqContext.SaveChanges();
        }
        public async Task<ICollection<TEntity>> GetAll()
        {
            return await _collection
                .Find(_ => true)
                .ToListAsync();
        }
        public async Task<TEntity> GetById(Guid id)
        {
            return await _collection
            .Find(x => x.Id == id)
            .FirstOrDefaultAsync();
        }
    }
}
