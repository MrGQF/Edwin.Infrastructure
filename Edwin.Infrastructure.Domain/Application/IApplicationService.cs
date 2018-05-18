using Edwin.Infrastructure.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edwin.Infrastructure.Domain.Application
{
    public interface IApplicationService<TEntity, TPrimaryKey> : IQueries<TEntity, TPrimaryKey>, ICommand<TEntity, TPrimaryKey>
        where TEntity : IEntity<TPrimaryKey>
    {
    }
}
