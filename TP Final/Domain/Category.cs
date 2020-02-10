using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    /// <summary>
    /// Una categoría de preguntas
    /// </summary>
    class Category
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal Set Set { get; set; }
    }
}
