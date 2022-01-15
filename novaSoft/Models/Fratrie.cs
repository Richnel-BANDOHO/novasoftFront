using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace novaSoft.Models
{
    public class Fratrie
    {
        public long fratrieId { get; set; }
        public long membreFamilleId { get; set; }
        public string LienDeParente { get; set; }
        public string classeMembrFam { get; set; }
    }
}