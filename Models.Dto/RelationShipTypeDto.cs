using Core.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    public class RelationShipTypeDto : IEntity
    {
        public int IdRelationType { get; set; }
        public string RelationName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int _Id { get => IdRelationType; set => IdRelationType = value; }
    }
}
