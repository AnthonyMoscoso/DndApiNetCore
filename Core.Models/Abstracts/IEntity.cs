using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Abstracts
{
    public interface IEntity
    {
        public int _Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
