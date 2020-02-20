using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;


namespace alpha
{
    class CreationDataBase
    {
        public static void CreatBD()
        {

            String PathFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(!System.IO.Directory.Exists(PathFolder + "\\Alpha"))
            System.IO.Directory.CreateDirectory(PathFolder+"\\Alpha");
            Console.WriteLine(PathFolder);
            if (!SQLiteConnection.Equals(PathFolder + "\\Alpha\\MyDatabase.sqlite", null))
                SQLiteConnection.CreateFile(PathFolder + "\\Alpha\\MyDatabase.sqlite");
            //SQLiteConnection.

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
              "id_prod varchar(45) primary key"+
              "nom varchar(255)," +
              "marque varchar(255)," +
              "PD float ," +
              "PG float," +
              "unite int(10))";
            string boundc = "create table boundc(" +
              "id_bondc INTEGER AUTOINCREMENT" +
              "id_clint int " +
              "date date," +
              "prixv float ," +
              "primary key (id_bondc,id_client,date)" +
              "foreign key (id_cl) reference client(id_client))";
            string listBCP = "create table listbcp(" +
               "id_bc int," +
               "id_prod int," +
              "quan int (10)," +
              "typeAC varchar(5)," +
              "primary key (id_bc)" +
              "foreign key (id_prod) reference prod(id_prod)," +
              "foreign key (id_bc) reference boundc(id_bondc))";
            string factach = "create table facteurAch(" +
                "id_facteurAch INTEGER AUTOINCREMENT" +
                "date date " +
                "foreign key (id_f) reference fournisseur(id_fournisseur))";
            string lieu = "create tables lieu(" +
             "nom varchar (25) primary key)";
            string listach = "create table listach(" +
                "id_facteurAch int," +
                "id_prod varchar(45)," +
                "qoun int(10)," +
                "prixA float," +
                "typeA varchar(5)," +
                "foreign key (id_prod) reference prod(id_prod)," +
                "foreign key (id_facteurAch) reference factach(id_facteurAch)," +
                "primary key(id_facteurAch))";

            string stock = "create table stock(" +
                "id_prod int," +
                "id_fac int" +
                "qoun int(10)," +
                "id_lieu int," +
                "datem date," +
                "primary key (id_prod,datem,id_lieu)," +
                "foreign key (id_prod) reference prod(id_p)," +
                "foreign key (id_fac) reference factach(rowid)," +
                "foreign key (id_lieu) reference lieu(nom))";
            string user = "create tables user(" +
                "id int primary key auto_increment," +
                "nom varchar(25)," +
                "prenom varchar(25)," +
                "username varchr(25)," +
                "password varchar(25)," +
                "type varchar(4))";
               string feurnir = "create table feurnir(" +
                "id int primary key auto_increment," +
                "nom varchar(25)," +
                "prix float," +
                "comment(255)," +
                "id_user int ," +
                "foreign key (id_user) reference user(id))";
           

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
            command = new SQLiteCommand(listBCP, m_dbConnection);
            command.ExecuteNonQuery();





            m_dbConnection.Close();
        }
    }
}
