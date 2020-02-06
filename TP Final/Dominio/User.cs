using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Dominio
{
    /// <summary>
    /// Representa un usuario del sistema
    /// </summary>
    class User
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string FileNumber { get; set; }
        string Password { get; set; }
        IList<Session> Sessions { get; set; }
    }
}
