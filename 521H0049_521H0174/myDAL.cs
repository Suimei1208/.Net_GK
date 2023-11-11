﻿using _521H0049_521H0174.Models;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    internal class myDAL
    {
        private Model1 dbcontext;

        public myDAL()
        {
            dbcontext = new Model1();
        }

        // myDAL.UserExists will return true if exist valid parameters, else return false
        public async Task<bool> UserExists(string username, string password)
        {
            User user = dbcontext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }

        public void dispose()
        {
            dbcontext.Dispose();
        }

        public async void updateAvatar(string username, string avatar) {
            User user = dbcontext.Users.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                user.Avatar = avatar;
                await dbcontext.SaveChangesAsync();
            }
        }

        public string GetAvatarPath(string username)
        { 
            User user = dbcontext.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                return user.Avatar;
            }
            return null;
        }

        public string GetRole(string username)
        {
            User user = dbcontext.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                return user.Role;
            }
            return null;
        }
    }
}
