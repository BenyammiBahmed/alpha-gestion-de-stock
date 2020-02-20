using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alpha.module
{
    class boundcommond
    {
        private int id;
        private float prixTotal;
        private float prixVerse;
        private DateTime date;
        private client client;

        public int Id { get => id; set => id = value; }
        public float PrixTotal { get => prixTotal; set => prixTotal = value; }
        public float PrixVerse { get => prixVerse; set => prixVerse = value; }
        public DateTime Date { get => date; set => date = value; }
        internal client Client { get => client; set => client = value; }
    }
}
