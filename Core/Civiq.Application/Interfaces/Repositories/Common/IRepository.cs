using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Application.Interfaces.Repositories.Common
{
    public interface IRepository<TEntity> : IWriteRepository<TEntity>, IReadRepository<TEntity>
    {

    }
}
