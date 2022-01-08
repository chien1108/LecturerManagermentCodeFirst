﻿using LecturerManagement.Core.Modules.Enums;
using System;

namespace LecturerManagement.DTOS.LecturerDTO
{
    public class AddLecturerDto
    {
        //[Key]
        //public string ID { get; set; }
        public string StandardTimeID { get; set; }

        public string SubjectDepartmentID { get; set; }
        //public Status Status { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string IdentityCardNumber { get; set; }
        public string Portrait { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        public string PositionID { get; set; }
        public string YearStartWork { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; } = null;

        //public SubjectDepartment SubjectDepartment { get; set; }
        //public StandardTime StandardTime { get; set; }
        //public Position Position { get; set; }
        //public ICollection<GraduationThesis> GraduationTheses { get; set; } = new HashSet<GraduationThesis>();
        //public ICollection<Teaching> Teaches { get; set; } = new HashSet<Teaching>();
        //public ICollection<LecturerScientificResearch> LecturerScientificResearches { get; set; } = new HashSet<LecturerScientificResearch>();
        //public ICollection<AdvancedLearning> AdvancedLearnings { get; set; } = new HashSet<AdvancedLearning>();
        //public ICollection<ScientificResearchGuide> ScientificResearchGuides { get; set; } = new HashSet<ScientificResearchGuide>();
        //public ICollection<MachineRoom> MachineRooms { get; set; } = new HashSet<MachineRoom>();
        //public Account Account { get; set; }
    }
}
