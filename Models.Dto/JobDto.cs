using Core.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    public class JobDto : IEntity
    {
        public int IdJob { get; set; }
        public string JobTittle { get; set; }
        public string JobDescription { get; set; }
        public string UrlImage { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int _Id { get => IdJob; set =>IdJob = value; }
    }
}
