using Core.DataAccess.Abstracts;
using Models.Entities.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DataAcces.Abstracts
{
    public interface IJobRepository : IRepository<Job>
    {
        Job FindByTittle(string tittle);
        IEnumerable<Job> GetBytitle(string name);
    }
}
