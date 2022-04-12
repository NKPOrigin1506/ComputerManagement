﻿using DevExpress.Xpo;
using System;

namespace ManagementStore.Model.UserModel
{
    public class GroupAccessMenu
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int MenuId { get; set; }
        public bool SearchYN { get; set; }
        public bool CreateYN { get; set; }
        public bool SaveYN { get; set; }
        public bool DeleteYN { get; set; }
        public bool EditYN { get; set; }
        public bool PrintYN { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}