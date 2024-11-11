using db3.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db3
{
    internal class Helper
    {
        private static tour1Entities _context;

        public static tour1Entities GetContext()
        {
            if(_context == null)
            {
                _context = new tour1Entities();
            }
            return _context;
        }

        public void CreateUser(authorisation client)
        {
            _context.authorisation.Add(client);
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var validationErrors in e.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                    }
                }
            }
            Console.WriteLine("Ваши логин и пароль сохранены успешно!");
        }

        public void UpdateUser(authorisation client)
        {
            _context.Entry(client).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteUser(int client_id)
        {
            var clients = _context.authorisation.Find(client_id);
            _context.authorisation.Remove(clients);
            _context.SaveChanges(); 
        }
    }
}
