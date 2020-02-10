using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    /// <summary>
    /// Un usuario del sistema
    /// </summary>
    class User
    {
        public int Id { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FileNumber { get; set; }
        internal string Password { get; set; }
        internal IList<Session> Sessions { get; set; }
        internal bool IsAdmin { get; set; }
    }
}
