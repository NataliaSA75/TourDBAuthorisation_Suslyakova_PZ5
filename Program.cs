using db3.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPassword1;
using System.Data.Entity.Validation;
using System.Runtime.Remoting.Contexts;

namespace db3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            tour1Entities db = Helper.GetContext();
            Helper helper = new Helper();
            Console.WriteLine("Введите свой логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите свой пароль: ");
            string password = Class1.getHashedPassword(Console.ReadLine());
            Console.WriteLine($"Хэшированный пароль: {password}");
            authorisation auth = new authorisation();
            auth.login = login;
            auth.password = password.ToString();
            authorisation auth2 = new authorisation();
            auth2.login = login;
            auth2.password = password.ToString();
            helper.CreateUser(auth2);
        }
    }
}
