﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KtabiTest.Model
{
    public partial class CourseAppointment
    {
        public CourseAppointment()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public int AppointmentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Day1 { get; set; }
        public string Day2 { get; set; }
        public string Day3 { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public decimal? Price { get; set; }
        public int? TeacherId { get; set; }
        public int? ClassId { get; set; }
        public int? CourseId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Courses Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}