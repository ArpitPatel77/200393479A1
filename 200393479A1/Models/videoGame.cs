using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200393479A1.Models
{
    public class videoGame
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual string Requirements { get; set;}

        [DisplayName("Game Store Price")]
        [DataType(DataType.Currency)]
        public virtual decimal Price { get; set; }

        public virtual string Publiser { get; set; }

        public virtual string Developer { get; set; }

        public virtual Genre Genre { get; set; }

         
    }
}