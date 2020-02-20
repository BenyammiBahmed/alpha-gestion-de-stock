using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alpha.module
{
    class client
    {
        private int id_client;
        private String nom;
        private String prenom;
        private String nb_tele1;
        private String nb_tele2;
        private String nb_teleFix;
        private String email;

        public int Id_client { get => id_client; set => id_client = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nb_tele1 { get => nb_tele1; set => nb_tele1 = value; }
        public string Nb_tele2 { get => nb_tele2; set => nb_tele2 = value; }
        public string Nb_teleFix { get => nb_teleFix; set => nb_teleFix = value; }
        public string Email { get => email; set => email = value; }
    }
}
