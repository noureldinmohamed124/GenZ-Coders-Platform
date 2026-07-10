using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenZCoders.Application.Abstractions.Presistance
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken ct = default);
    }
}
