﻿using System;
using System.ComponentModel.DataAnnotations;
using Resunet.DAL.Models;

namespace Resunet.DAL.Auth
{
    public interface IAuthDAL
    {
        Task<UserModel> GetUser(string email);
        Task<UserModel> GetUser(int id);
        Task<int> CreateUser(UserModel model);
    }
}
