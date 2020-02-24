using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Controller.REST.Service
{
    /// <summary>
    /// Un servicio web
    /// </summary>
    internal interface IWebService
    {
        /// <summary>
        /// Obtiene el contenido de una ruta determinada
        /// </summary>
        /// <param name="pUrl">La ruta a obtener</param>
        /// <returns>El contenido de la ruta</returns>
        string Get(string pUrl);
    }
}
