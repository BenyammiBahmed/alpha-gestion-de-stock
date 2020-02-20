using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alpha.module
{
    class feurnir
    {
        private int id;
        private String nom;
        private float prix;
        private String comment;
        private User user;

        public string Nom { get => nom; set => nom = value; }
        public float Prix { get => prix; set => prix = value; }
        public string Comment { get => comment; set => comment = value; }
        public int Id { get => id; set => id = value; }
        internal User User { get => user; set => user = value; }
    }
}
