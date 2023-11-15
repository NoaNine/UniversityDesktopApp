﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.WPF.Models.Base;

namespace University.WPF.Models
{
    internal class StudentDTO : PersonBaseModelDTO
    {
        public int GroupId { get; set; }
        public GroupDTO Group { get; set; }
    }
}
