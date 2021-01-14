﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LoginDemo.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the LoginDemoUser class
    public class LoginDemoUser : IdentityUser
    {
      
            [PersonalData]
            [Column(TypeName = "nvarchar(100)")]
            public string FirstName { get; set; }

            [PersonalData]
            [Column(TypeName = "nvarchar(100)")]
            public string LirstName { get; set; }

         
    }
}
