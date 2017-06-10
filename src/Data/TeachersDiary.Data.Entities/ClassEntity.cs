﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using TeachersDiary.Common.Constants;

namespace TeachersDiary.Data.Entities
{
    [Table("Classes")]
    public class ClassEntity
    {
        public ClassEntity()
        {
            Students = new HashSet<StudentEntity>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(DbEntitesValidationConstants.ClassNameMinLength)]
        [MaxLength(DbEntitesValidationConstants.ClassNameMaxLength)]
        public string Name { get; set; }

        public int SchoolId { get; set; }
        public virtual SchoolEntity School { get; set; }

        public string CreatedBy { get; set; }

        public ICollection<StudentEntity> Students { get; set; }
    }
}
