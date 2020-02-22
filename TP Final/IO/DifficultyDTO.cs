using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.IO
{
    public class DiffucultyDTO
    {
        public int Id { get; internal set; }
        public string Description { get; internal set; }
        public float Weight { get; internal set; }
    }
}
