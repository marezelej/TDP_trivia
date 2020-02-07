using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    class UserRole
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<UserAction> AllowedActions {get; set;}
    }
}
