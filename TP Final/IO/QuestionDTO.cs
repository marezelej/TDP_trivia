using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    public class QuestionDTO
    {
        public string Question { get; }
        public IList<string> Answers { get; }
        public int CorrectAnswerPosition { get; }
    }
}
