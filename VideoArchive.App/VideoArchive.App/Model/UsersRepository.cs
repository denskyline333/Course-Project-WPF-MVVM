using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VideoArchive.App.Model
{
    public class UsersRepository
    {
        private UsersEntities usersEntities;

        public UsersRepository()
        {
            usersEntities = new UsersEntities();
        }

        public void AddUser(User user)
        {
            usersEntities.Users.Add(user);
            usersEntities.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            usersEntities.Users.Remove(user);
            usersEntities.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return usersEntities.Users.ToList();
        }

        public User GetUsersByLogin(string login)
        {
            return usersEntities.Users.FirstOrDefault(x => x.login == login);
        }

        public User GetUser(User user)
        {
            User tmp = usersEntities.Users.FirstOrDefault(x => x.login == user.login && x.password == user.password);
            if (tmp != null)
                return tmp;
            else
                return null;
        }

        public User IsUser(string login, string password)
        {
            User tmp = usersEntities.Users.FirstOrDefault(x => x.login == login && x.password == password);
            if (tmp != null)
                return tmp;
            else
                return null;
        }
        public User IsExist(string login)
        {
            User tmp = usersEntities.Users.FirstOrDefault(x => x.login == login);
            if (tmp != null)
                return tmp;
            else
                return null;
        }
        public static string getHash(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                return "-1";
            }
            else
            {
                var md5 = MD5.Create();
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
