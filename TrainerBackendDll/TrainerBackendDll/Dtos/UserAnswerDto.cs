﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerBackendDll.Dtos
{
    public class UserAnswerDto
    {
        public int QuestionId { get; set; }
        public string SelectedOption { get; set; }
    }
}
