using Core.DataAccess.Abstracts;
using Models.Entities.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DataAcces.Abstracts
{
    public interface ICharactersRepository : IRepository<Characters>
    {
        Characters FindByName(string name);
        IEnumerable<Characters> GetByName(string name);
        IEnumerable<Characters> GetByType(short CharacterType);
        IEnumerable<Characters> GetByRelationCharacter(int idCharacter);
        IEnumerable<Characters> GetByRelationCharacter(int idCharacter,int idRelationType);
    }
}
