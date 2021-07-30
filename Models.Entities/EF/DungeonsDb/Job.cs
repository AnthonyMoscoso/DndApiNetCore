using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF
{
    public class Job
    {
        public int IdJob { get; set; }
        public string JobTittle { get; set; }
        public string JobDescription { get; set; }
        public string UrlImage { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public virtual ICollection<Characters> Characters { get; set; }
    }
}
