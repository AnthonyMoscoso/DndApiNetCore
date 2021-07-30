using Models.Entities.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF
{
    public class RelationShipType
    {
        public int IdRelationType { get; set; }
        public string RelationName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public virtual IEnumerable<RelationShip> RelationShip { get; set; }
    }
}
