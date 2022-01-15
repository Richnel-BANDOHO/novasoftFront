using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace novaSoft.Models
{

	
    public class Eleve
    {
        public long eleveId { get; set; }

        /*[DisplayName("Artist")]*/
        [Required(ErrorMessage = "Le nom est obligatoire", AllowEmptyStrings = false)]
		[MinLength(3)]
        /*[Required]*/
        public string eleveName { get; set; }

		[Required(ErrorMessage = "Le prénom  est obligatoire", AllowEmptyStrings = false)]
		public string eleveFirstName { get; set; }
		/*public DateTime eleveBirthdate { get; set; }*/
		[Required(ErrorMessage = "Le sexe est obligatoire", AllowEmptyStrings = false)]
		public string eleveSexe { get; set; }
		[Required(ErrorMessage = "Le lieu de naissance  est obligatoire", AllowEmptyStrings = false)]
		public string elevePlaceOfBirth { get; set; }
		[Required(ErrorMessage = "Le l'adresse de l'élève est obligatoire", AllowEmptyStrings = false)]
		public string eleveAddress { get; set; }
		public string elevePhoneNumber { get; set; }

		[Required(ErrorMessage = "La classe est obligatoire", AllowEmptyStrings = false)]
		public string eleveClasse { get; set; }

		public string eleveMatricule { get; set; }
		[Required(ErrorMessage = "Merci de choisir une serie ou un cycle", AllowEmptyStrings = false)]
		public string eleveSerie { get; set; }

		

		/*[Required]*/
		public string elevePassword { get; set; }
		public string eleveUserName { get; set; }


		[Required(ErrorMessage = "Le nom du père est obligatoire", AllowEmptyStrings = false)]
		public string eleveDadName { get; set; }
		[Required(ErrorMessage = "Le prénom du père est obligatoire", AllowEmptyStrings = false)]
		public string eleveDadFirstname { get; set; }
		public string eleveDadCinNum { get; set; }
		public string eleveDadProfession { get; set; }
		[Required(ErrorMessage = "La résidence du père est obligatoire", AllowEmptyStrings = false)]
		public string eleveDadResidence { get; set; }
		
		public string eleveDadPhoneNum { get; set; }
		[Required]
		public string eleveMomName { get; set; }
		[Required]
		public string eleveMomFirstname { get; set; }
		public string eleveMomCinNum { get; set; }
		public string eleveMomProfession { get; set; }
		public string eleveMomResidence { get; set; }
		public string eleveMomPhoneNum { get; set; }

		[Required]
		public string eleveTutorName { get; set; }
		[Required]
		public string eleveTutorFirstname { get; set; }
		public string eleveTutorCinNum { get; set; }
		[Required]
		public string eleveTutorProfession { get; set; }
		[Required]
		public string eleveTutorResidence { get; set; }
		[Required]
		public string eleveTutorPhoneNum { get; set; }

		public List<Paiements> paiements {

			get; set;
		}
		public List<Fratrie> fratrie { get; set; }
	}

	
}