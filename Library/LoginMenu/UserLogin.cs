﻿using LibraryCorner.Models;
using System.Text;

namespace LibraryCorner.LoginMenu
{
    public class UserLogin:Menu
    {
        public UserLogin(DataContext dataContext) : base(dataContext) { }
        public  string ComputeSha256Hash(string rawData)
        {
            using (System.Security.Cryptography.SHA256 sha256Hash = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public override void Register(User user)
        {
            user.Password = ComputeSha256Hash(user.Password + user.Salt);
        }

        public override string Login(string email, string password)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Email == email);
            var userPass = ComputeSha256Hash(password + user.Salt);

            if (user == null)
            {
                return "User not found";
            }

            if (userPass == user.Password)
            {
                return "Authentication Successful";
            }
            else
            {
                return "Invalid password";
            }
        }
    }
}

