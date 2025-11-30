using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.Isp
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll(Guid id);
        T GetById(Guid id);
    }
}