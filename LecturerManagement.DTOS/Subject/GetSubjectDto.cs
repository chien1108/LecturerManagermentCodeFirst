﻿using LecturerManagement.DTOS.Models.Base;
using LecturerManagement.DTOS.SubjectType;
using LecturerManagement.DTOS.Teaching;
using LecturerManagement.DTOS.TrainingSystem;
using System.Collections.Generic;

namespace LecturerManagement.DTOS.Subject
{
    public class GetSubjectDto : BaseEntity<string>
    {
        ////public string ID { get; set; }
        public string Name { get; set; }
        public int QuantityUnit { get; set; }
        public string Description { get; set; }

        public GetTrainingSystemDto TrainingSystem { get; set; }
        public GetSubjectTypeDto SubjectType { get; set; }
        public ICollection<GetTeachingDto> Teachings { get; set; } = new HashSet<GetTeachingDto>();
    }
}
