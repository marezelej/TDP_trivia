﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.IO
{
    public class QuestionDTO
    {
        public string Question { get; set; }
        public IList<AnswerDTO> Answers { get; set; }
    }
}
