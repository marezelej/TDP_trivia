using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Contract
{
    public interface IQuestionsSetController
    {
        IEnumerable<QuestionsSetDTO> GetAll();
    }
}
