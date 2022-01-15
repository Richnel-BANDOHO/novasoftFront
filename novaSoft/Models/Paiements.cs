using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace novaSoft.Models
{
    public class Paiements
    {
		public long paiementId { get; set; }

		public String auteur { get; set; }

		/*public DateTime datePaiement;*/

		public int montant { get; set; }

		public String mois { get; set; }


	}
}