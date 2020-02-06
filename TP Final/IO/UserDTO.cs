using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    /// <summary>
    /// Contiene la información de un usuario específico
    /// </summary>
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FileNumber { get; set; }
        public string Password { get; set; }
    }
}
