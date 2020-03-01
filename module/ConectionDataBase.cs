using System;
using System.Data.SQLite;
using System.IO;

namespace alpha
{
    class ConectionDataBase
    {
        public static void CreatBD()
        {
            
            String PathFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(!System.IO.Directory.Exists(PathFolder + "\\Alpha"))
            System.IO.Directory.CreateDirectory(PathFolder+"\\Alpha");
            Console.WriteLine(PathFolder);
            if (!File.Exists(PathFolder + "\\Alpha\\MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile(PathFolder + "\\Alpha\\MyDatabase.sqlite");
                

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + PathFolder + "\\Alpha\\MyDatabase.sqlite");
                m_dbConnection.Open();

                string client = "create table client  (" +
                    "id_client INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nom varchar(255) NOT NULL," +
                    "prenom varchar(255) NOT NULL," +
                    "nb_tele1 varchar(25)," +
                    "nb_tele2 varchar(25)," +
                    "nb_teleFix varchar(25)," +
                    "email vsrchar(255))";
                string fournisseur = "create table fournisseur(" +
                 "id_fournisseur INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "nom varchar(255) NOT NULL," +
                 "prenom varchar(255) NOT NULL," +
                 "nb_tele1 varchar(25)," +
                 "nb_tele2 varchar(25)," +
                 "nb_teleFix varchar(25)," +
                 "email vsrchar(255)," +
                 "societe varchar(30))";
                string prod = "create table prod(" +
                  "id_prod varchar(45) primary key ," +
                  "nom varchar(255)," +
                  "marque varchar(255)," +
                  "PD float," +
                  "PG float," +
                  "unite int(10))";
                string boundc = "create table boundc(" +
                  "id_bondc INTEGER PRIMARY KEY AUTOINCREMENT," +
                  "id_client int," +
                  "date date," +
                  "prixv float," +
                  "foreign key (id_client) references client(id_client))";
                string listBC = "create table listbc(" +
                   "id_bc int," +
                   "id_prod int," +
                  "quan int (10)," +
                  "typeAC varchar(5)," +
                  "foreign key (id_prod) references prod(id_prod)," +
                  "foreign key (id_bc) references boundc(id_bondc)" +
                   "primary key(id_bc,id_prod,typeA))";
                string factach = "create table facteurAch(" +
                    "id_facteurAch INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "id_fournisseur INTEGER," +
                    "dateAchat date," +
                    "foreign key (id_fournisseur) references fournisseur(id_fournisseur))";
                string lieu = "create table lieu(" +
                    "id_lieu INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "nom varchar(25))";
                string listach = "create table listach(" +
                    "id_facteurAch int," +
                    "id_prod varchar(45)," +
                    "qoun int(10)," +
                    "prixA float," +
                    "typeA varchar(5)," +
                    "foreign key (id_prod) references prod(id_prod)," +
                    "foreign key (id_facteurAch) references factach(id_facteurAch)," +
                    "primary key(id_facteurAch,id_prod,typeA))";
                string stock = "create table stock(" +
                    "id_prod int," +
                    "id_fac int," +
                    "qoun int(10)," +
                    "id_lieu int," +
                    "datem date," +
                    "primary key (id_prod,datem,id_lieu)," +
                    "foreign key (id_prod) references prod(id_prod)," +
                    "foreign key (id_fac) references factach(id_facteurAch)," +
                    "foreign key (id_lieu) references lieu(id_lieu))";
                string user = "create table user(" +
                    "id_user INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nom varchar(25)," +
                    "prenom varchar(25)," +
                    "username varchr(25)," +
                    "password varchar(25)," +
                    "type varchar(4))";
                string feurnir = "create table feurnir(" +
                 "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "nom varchar(25)," +
                 "prix float," +
                 "comment varchar(255)," +
                 "id_user INTEGER," +
                 "foreign key (id_user) references user(id_user))";


                SQLiteCommand command = new SQLiteCommand(client, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(fournisseur, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(factach, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(boundc, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(prod, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(lieu, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(listach, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(user, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(feurnir, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(stock, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(listBC, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();
            }
        }
    }
}
