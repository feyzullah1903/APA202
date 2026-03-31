using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    using _08_StatiClassExtensionMethodsExceptions.Exceptions;
    using System;

    public class LoginSystem
    {
        private User[] userList;
        private const int maxAttempts = 3;

        public LoginSystem()
        {
            userList = new User[3];
            userList[0] = new User("admin", "admin123");
            userList[1] = new User("student", "student123");
            userList[2] = new User("teacher", "teacher123");
        }

        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            {
                throw new InvalidUsernameException("username is too short");
            }
        }

        public void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                throw new InvalidPasswordException("password too short");
            }
        }

        private User FindUser(string username)
        {
            for (int i = 0; i < userList.Length; i++)
            {
                if (userList[i].Username.ToLower() == username.ToLower())
                {
                    return userList[i];
                }
            }
            return null;
        }

        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);

            User user = FindUser(username);

            if (user == null)
                throw new UserNotFoundException(username);

            if (user.IsLocked)
                throw new AccountLockedException();

            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine("Login ok, welcome " + username);
                return true;
            }
            else
            {
                user.FailedAttempts++;

                int left = maxAttempts - user.FailedAttempts;

                if (left > 0)
                    throw new IncorrectPasswordException(left);
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException();
                }
            }
        }

        public void ShowUsers()
        {
            Console.WriteLine("users:");
            for (int i = 0; i < userList.Length; i++)
            {
                Console.WriteLine(userList[i].Username);
            }
        }
    }
}
