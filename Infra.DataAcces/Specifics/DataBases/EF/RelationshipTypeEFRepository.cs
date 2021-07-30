using Core.DataAccess.Specifics.DataBases;
using Infra.DataAcces.Abstracts;
using Microsoft.EntityFrameworkCore;
using Models.Entities.EF;
using Models.Entities.EntityFW.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DataAcces.Specifics.DataBases.EF
{
    public class RelationshipTypeEFRepository : EFBaseRepository<RelationShipType>, IRelationShipTypeRepository
    {
        public RelationshipTypeEFRepository(DungeonsContext context, string identificator ="IdRelationType") : base(context, identificator)
        {
        }
    }
}
