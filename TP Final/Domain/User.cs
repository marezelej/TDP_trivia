using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Domain
{
    /// <summary>
    /// Un usuario del sistema
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FileNumber { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public IList<Session> Sessions { get; set; }
    }
}
