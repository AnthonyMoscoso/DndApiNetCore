using Core.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    public class CharacterDto : IEntity
    {
        #region Atributes 
        public int IdCharacter { get; set; }
        public short CharacterType { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string UrlImage { get; set; }
       
        #endregion


        public JobDto Job { get; set; }
        public int _Id { get => IdCharacter; set => IdCharacter = value; }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }


    }
}
