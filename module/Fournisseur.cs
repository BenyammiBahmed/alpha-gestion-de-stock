using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alpha.module
{
    class fournisseur
    {
        private int id_fournisseur;
        private String nom;
        private String prenom;
        private String nb_tele1;
        private String nb_tele2;
        private String nb_teleFix;
        private String email;
        private String societe;

        public int Id_fournisseur { get => id_fournisseur; set => id_fournisseur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nb_tele1 { get => nb_tele1; set => nb_tele1 = value; }
        public string Nb_tele2 { get => nb_tele2; set => nb_tele2 = value; }
        public string Nb_teleFix { get => nb_teleFix; set => nb_teleFix = value; }
        public string Email { get => email; set => email = value; }
        public string Societe { get => societe; set => societe = value; }
    }
}
