﻿using MyBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.BLL.Interfaces
{
    public interface IUserServices
    {
        User GetUserById(int id);
        User GetUserByUserName(string username);
        List<User> GetAllUsers();
        void AddUser(User user, string password);
        void UpdateUser(User user);
        void UpdatePassword(int userId, string password);
        void DeleteUser(int id);
        bool VerifyPassword(User user, string password);
        bool UserExists(string username);

    }
}
