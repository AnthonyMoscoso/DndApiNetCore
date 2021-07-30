using Core.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    public class RelationshipDto : IEntity 
    {
        public int IdRelation { get; set; }
        public CharacterDto Character { get; set; }
        public CharacterDto Character1 { get; set; }
        public RelationShipTypeDto RelationType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int _Id { get => IdRelation; set => IdRelation = value; }
    }
}
