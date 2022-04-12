﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model.UserModel
{
    public class AppUser
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int GroupRoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool UseYN { get; set; }
        public int RoleId { get; set; }

        public AppUser(string id = "", string fname = "", string lname = "", string email = "", string uname = "", string pass = "", int rid = 0)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Lastname = lname;
            this.Email = email;
            this.Username = uname;
            this.Password = pass;
            this.RoleId = rid;
        }
        public AppUser()
        {

        }
    }
}
