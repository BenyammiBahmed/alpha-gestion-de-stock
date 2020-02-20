using System;

namespace alpha.module
{
    class prod
    {
        private String id_prod;
        private String nom;     
        private String marque;
        private float pD;
        private float pG;
        private int unite;
        public String Nom
        {
            get => nom;
            set => nom = value;
        }
        public string Id_prod { get => id_prod; set => id_prod = value; }
        public string Marque { get => marque; set => marque = value; }
        public float PD { get => pD; set => pD = value; }
        public float PG { get => pG; set => pG = value; }
        public int Unite { get => unite; set => unite = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
