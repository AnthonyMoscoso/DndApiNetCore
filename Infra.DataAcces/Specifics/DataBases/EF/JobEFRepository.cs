using Core.DataAccess.Specifics.DataBases;
using Infra.DataAcces.Abstracts;
using Microsoft.EntityFrameworkCore;
using Models.Entities.EF;
using Models.Entities.EntityFW.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.DataAcces.Specifics.DataBases.EF
{
    public class JobEFRepository : EFBaseRepository<Job>, IJobRepository
    {
        public JobEFRepository(DungeonsContext context, string identificator="IdJob") : base(context, identificator)
        {
        }

        public Job FindByTittle(string tittle)
        {
            return _table.FirstOrDefault( w=> w.JobTittle.Equals(tittle));
        }

        public IEnumerable<Job> GetBytitle(string title)
        {
            return _table.Where(w=> w.JobTittle.Contains(title));
        }
    }
}
