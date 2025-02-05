﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Proj1.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        public int GradeId { get; set; }
        [Required]
        public string GradeName { get; set; }

        [InverseProperty("Grade")]
        public virtual ICollection<Student> Students { get; set; }
    }
}