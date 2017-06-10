﻿using AutoMapper;

using TeachersDiary.Common.Extensions;
using TeachersDiary.Data.Entities;
using TeachersDiary.Services.Encrypting;
using TeachersDiary.Services.Mapping.Contracts;

namespace TeachersDiary.Domain
{
   public class AbsenceDomain : IMap<AbsenceEntity>, ICustomMappings
    {
        public string EncodedId { get; set; }

        public string EncodedStudentId { get; set; }

        public int MonthId { get; set; }

        public double Excused { get; set; }

        public double NotExcused { get; set; }

        public string NotExcusedAsFractionNumber
        {
            get { return NotExcused.ToFractionNumber(); }
        }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            IEncryptingService encryptingService = new EncryptingService();

            configuration.CreateMap<AbsenceEntity, AbsenceDomain>()
                .ForMember(domain => domain.EncodedId, x => x.MapFrom(entity => encryptingService.EncodeId(entity.Id)))
                .ForMember(domain => domain.EncodedStudentId,
                    x => x.MapFrom(entity => encryptingService.EncodeId(entity.StudentId)));

            configuration.CreateMap<AbsenceDomain, AbsenceEntity>()
                .ForMember(entity => entity.Id, x => x.MapFrom(domain => encryptingService.DecodeId(domain.EncodedId)))
                .ForMember(entity => entity.StudentId, x => x.MapFrom(domain => encryptingService.DecodeId(domain.EncodedStudentId)));
        }
    }
}
