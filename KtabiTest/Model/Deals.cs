﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KtabiTest.Model
{
    public partial class Deals
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string RequestUserId { get; set; }
        public string BookName { get; set; }
        public string BookPhoto { get; set; }
        public int CopyYear { get; set; }

        public virtual Book Book { get; set; }
        public virtual AspNetUsers RequestUser { get; set; }
    }
}