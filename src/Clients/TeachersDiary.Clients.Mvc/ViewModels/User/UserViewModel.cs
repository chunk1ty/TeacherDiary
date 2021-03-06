﻿using TeachersDiary.Common.Enumerations;
using TeachersDiary.Domain;
using TeachersDiary.Services.Contracts.Mapping;

namespace TeachersDiary.Clients.Mvc.ViewModels.User
{
    public class UserViewModel : IMap<UserDomain>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Id { get; set; }

        public string UserName { get; set; }

        public int SchoolId { get; set; }

        public ApplicationRoles Role { get; set; }
    }
}