using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroCala.Models
{
    public class SuperHero
    {
        [Key]
        public int ID { get; set; }
        public string superHeroName { get; set; }
        public string alterEgo { get; set; }
        public string primarySuperHeroAbility { get; set; }
        public string secondarySuperHeroAbility { get; set; }
        public string catchPhrase { get; set; }


    }
}