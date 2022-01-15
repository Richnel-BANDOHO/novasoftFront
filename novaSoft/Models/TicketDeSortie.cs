using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace novaSoft.Models
{
    public class TicketDeSortie
    {
       
        [Required]
        public String eleveName { get; set; }
        [Required]
        public String eleveFirstName { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public String motifDuTicket { get; set; }
        [Required]
        public String classeEleve { get; set; }
        [Required]
        public String matriculeEleve { get; set; }
    }
}