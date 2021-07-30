using Core.DataAccess.Abstracts;
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
    public class CharactersEFRepository : EFBaseRepository<Characters>, ICharactersRepository
    {
        public CharactersEFRepository(DungeonsContext context, string identificator = "IdCharacter") : base(context, identificator)
        {
        }

        public Characters FindByName(string name)
        {
            return _table.SingleOrDefault(w => w.Name.Equals(name));
        }

        public IEnumerable<Characters> GetByName(string name)
        {
            return _table.Where(w => w.Name.Contains(name));
        }

        public IEnumerable<Characters> GetByRelationCharacter(int idCharacter)
        {
            return _table.Where(w => 
            w.RelationShip.Any(w => w.IdCharacter.Equals(idCharacter) || w.IdCharacter1.Equals(idCharacter)) 
            || w.RelationShip1.Any(w => w.IdCharacter.Equals(idCharacter) || w.IdCharacter1.Equals(idCharacter)));
        }

        public IEnumerable<Characters> GetByRelationCharacter(int idCharacter, int idRelationType)
        {
            return _table.Where(w => w.RelationShip.Any(w => (w.IdCharacter.Equals(idCharacter) 
            || w.IdCharacter1.Equals(idCharacter)) 
            && w.IdRelationType.Equals(idCharacter))
             || w.RelationShip1.Any(w => w.IdCharacter.Equals(idCharacter) 
             || w.IdCharacter1.Equals(idCharacter) 
             && w.IdRelationType.Equals(idCharacter)))                                                                           ;
             

        }

        public IEnumerable<Characters> GetByType(short CharacterType)
        {
            return _table.Where(w => w.CharacterType == CharacterType);
        }
    }
}
