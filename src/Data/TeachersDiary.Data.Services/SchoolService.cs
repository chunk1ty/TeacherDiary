﻿using System.Collections.Generic;
using System.Threading.Tasks;

using TeachersDiary.Data.Contracts;
using TeachersDiary.Data.Services.Contracts;
using TeachersDiary.Domain;
using TeachersDiary.Services.Mapping.Contracts;

namespace TeachersDiary.Data.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;
        private readonly IMappingService _mappingService;

        public SchoolService(ISchoolRepository schoolRepository, IMappingService mappingService)
        {
            _schoolRepository = schoolRepository;
            _mappingService = mappingService;
        }

        public async Task<IEnumerable<SchoolDomain>> GetAllSchoolNamesAsync()
        {
            var schoolEntities = await _schoolRepository.GetAllAsync();

            var schoolDomains = _mappingService.Map<IEnumerable<SchoolDomain>>(schoolEntities);

            return schoolDomains;
        }
    }
}
