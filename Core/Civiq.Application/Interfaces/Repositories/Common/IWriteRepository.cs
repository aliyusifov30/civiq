using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Application.Interfaces.Repositories.Common
{
    public interface IWriteRepository<TEntity>
    {
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
