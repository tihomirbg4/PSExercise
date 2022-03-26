using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        private static List<User> _newTestUser;
        static private void ResetTestUserData()
        {
            if (_newTestUser == null)
            {
                _newTestUser = new List<User>(3);
            }
            _newTestUser.Add(new User
            {
                Username = "Tisho",
                Password = "12345",
                FacNum = "121219096",
                Role = UserRoles.ADMIN,
                Created = DateTime.Now,
                Valid = DateTime.MaxValue
            });

            _newTestUser.Add(new User
            {
                Username = "Pesho",
                Password = "12345",
                FacNum = "121219097",
                Role = UserRoles.STUDENT,
                Created = DateTime.Now,
                Valid = DateTime.MaxValue
            });

            _newTestUser.Add(new User
            {
                Username = "Gosho",
                Password = "12345",
                FacNum = "121219098",
                Role = UserRoles.STUDENT,
                Created = DateTime.Now,
                Valid = DateTime.MaxValue
            });

        }

        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _newTestUser;
            }

            set
            {

            }
        }

        static public User isUserPassCorrect(string username, string password)
        {
            User user = (from u in TestUsers where u.Password.Equals(password) select u).First();


            return user;

        }

        static public void SetUserActiveTo(string username, DateTime newDateActiveTo)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username.Equals(username))
                {
                    user.Valid = newDateActiveTo;
                    Logger.LogActivity("Промяна на активност на потребител " + username + " на " + newDateActiveTo);
                }
            }
        }

        static public void AssignUserRole(string username, UserRoles newRole)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username.Equals(username))
                {
                    user.Role = newRole;
                    Logger.LogActivity("Промяна на роля на " + username + ", нова роля " + newRole);
                }
            }
        }

        public static void UserList()
        {
            foreach (User user in _newTestUser)
            {
                Console.WriteLine(user.Username);
            }
        }

    }
}
