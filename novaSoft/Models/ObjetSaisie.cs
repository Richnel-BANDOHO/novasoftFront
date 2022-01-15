using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace novaSoft.Models
{
    public class ObjetSaisie
    {

		
		public long objetId { get; set; }
		[Required( ErrorMessage ="Le nom de l'objet saisi est obligatoire", AllowEmptyStrings = false)]
		public String objetName { get; set; }
		[Required(ErrorMessage ="La condition de la saisie est obligatoire", AllowEmptyStrings = false)]
		[DataType(DataType.MultilineText)]
		public String condistionDeSaisie { get; set; }
		[Required(ErrorMessage ="L'auteur de la saisie est obligatoire", AllowEmptyStrings = false)]
		public String auteurSaisie { get; set; }
		[Required(ErrorMessage = "Le matricule de l'élève est obligatoire", AllowEmptyStrings = false)]
		public String matriculeEleve { get; set; }
	}
}