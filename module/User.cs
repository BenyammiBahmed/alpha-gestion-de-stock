using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alpha.module
{
    class User
    {
        private int id;
        private String nom;
        private String pronom;
        private String userName;
        private String passWord;
        private String type;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Pronom { get => pronom; set => pronom = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Type { get => type; set => type = value; }
    }
}
