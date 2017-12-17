﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PwdLess.Models.ManageViewModels
{
    public class EditUserInfoViewModel : AdditionalUserInfo
    {
        [Required]
        public IList<UserLoginInfo> Logins { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Main email")]
        public string CommunicationEmail { get; set; }
    }
}