﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string SkillLevel { get; set; }
        public double Tuition { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
