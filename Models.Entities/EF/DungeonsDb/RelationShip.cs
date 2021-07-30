using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF
{
    public class RelationShip
    {
        public int IdRelation { get; set; }
        public int IdCharacter { get; set; }
        public int IdCharacter1 { get; set; }
        public int IdRelationType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public virtual Characters Character { get; set; }
        public virtual Characters Character1 { get; set; }
        public virtual RelationShipType RelationType { get; set; }
    }
}
