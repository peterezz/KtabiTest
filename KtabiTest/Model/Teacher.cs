﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KtabiTest.Model
{
    public partial class Teacher
    {
        public Teacher()
        {
            CourseAppointment = new HashSet<CourseAppointment>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherPhoneNumber { get; set; }

        public virtual ICollection<CourseAppointment> CourseAppointment { get; set; }
    }
}