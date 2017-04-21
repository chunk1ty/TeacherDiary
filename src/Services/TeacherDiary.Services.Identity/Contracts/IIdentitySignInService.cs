﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using TeacherDiary.Data.Ef;

namespace TeacherDiary.Services.Identity.Contracts
{
    public interface IIdentitySignInService : IDisposable
    {
        Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout);

        Task SignInAsync(ApplicationUser user, bool isPersistent, bool rememberBrowser);
    }
}