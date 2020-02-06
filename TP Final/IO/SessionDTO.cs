using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    public class SessionDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public int Quantity { get; set; }
        public TimeSpan Time { get; set; }

    }
}
