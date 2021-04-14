using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.IO
{
    public class QuestionDTO
    {
        public string Description { get; set; }
        public IList<AnswerDTO> Answers { get; set; }
        public AnswerDTO SelectedAnswer { get; set; }
        public bool IsSelected(AnswerDTO answer)
        {
            return SelectedAnswer != null && SelectedAnswer.Equals(answer);
        }
    }
}
