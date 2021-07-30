using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF
{
    public class Characters
    {
        public int IdCharacter { get; set; }
        public short CharacterType { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string UrlImage { get; set; }
        public int? IdJob { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public Job Job { get; set; }
        public virtual ICollection<RelationShip> RelationShip { get; set; }
        public virtual ICollection<RelationShip> RelationShip1 { get; set; }
    }
}
