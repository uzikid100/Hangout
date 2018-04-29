using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangout.Models.Infrastructure
{
    public interface IRepository<T>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
