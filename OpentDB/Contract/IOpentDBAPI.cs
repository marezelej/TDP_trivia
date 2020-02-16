using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Contract
{
    interface IOpentDBAPI
    {
        IEnumerable<QuestionDTO> GetQuestionsList(int pNumber, QuestionCategory pCategory, QuestionDifficulty pDifficulty, QuestionType pType);
    }
}
