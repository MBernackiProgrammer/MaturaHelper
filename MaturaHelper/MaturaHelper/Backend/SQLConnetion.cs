using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturaHelper.SQLconnetionNames
{
    internal class SQLConnetion
    {
        //server = localhost; userid = root; password = ; database = maturahelper
        static public string Server = "localhost";
        static public string UserID = "root";
        static public string PassWord = "";
        static public string DataBase = "maturahelper";

        //Nazwy tabeli 

        static public string Scopes = "zakresy";
        static public string SubScopes = "podzakresy";

        //Nazwa tabeli do logowania
        static public string LoginTable = "userdata";

        static public string SectionName = "NazwaZakresu";
    }
}
