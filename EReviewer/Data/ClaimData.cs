﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EReviewer.Data
{
    public class ClaimData
    {
        public List<string> UserClaims { get; set; } = new List<string>
        {
            "Add User",
            "Edit User",
            "Delete User"
        };
    }
}
