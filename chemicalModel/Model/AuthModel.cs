using System;
using MySql.Data.MySqlClient;
namespace chemicalModel.Model
{
    class AuthModel
    {
        DB usersDB = new DB("authmodel","localhost","root","root");
        
        private bool Auth(string login, string password)
        {
            usersDB.Connection();
            MySqlDataReader resp =  usersDB.Get("select password from users where login = '" + login + "';");
            if(!resp.Read())
            {
                return false;
            }
            Console.WriteLine(resp[0]);
            return (string)resp[0] == password;
        }

        private string Validation(string login, string password)
        {
            if(login == "" || password == "")
            {
                return "Логин и пароль не могут быть пустатой";
            }
            return "";
        }

        public string Entry(string login, string password)
        {
            string valid = Validation(login, password);
            if (valid != "")
                return valid;
            if (Auth(login, password))
                return "";
            else
                return "Неверно введен логин или пароль";           
        }


    }
}
