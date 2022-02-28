﻿using LecturerManagement.Core.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LecturerManagement.Core.Models.Entities
{
    /// <summary>
    /// lớp
    /// </summary>
    public class Class : BaseEntity<string>
    {
        //[Key]
        //public string ID { get; set; } // VD 69DCHT21

        [ForeignKey("TrainingSystem")]
        public string TrainingSystemId { get; set; }


        [Required]
        public string Name { get; set; }
        public int? NumberOfStudent { get; set; }
        public string FormsOfTraining { get; set; }
        public string Description { get; set; } = null;

        public TrainingSystem TrainingSystem { get; set; }
        public ICollection<Teaching> Teachings { get; set; } = new HashSet<Teaching>();
        public ICollection<GraduationThesis> GraduationTheses { get; set; } = new HashSet<GraduationThesis>();
    }
}