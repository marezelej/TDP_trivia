using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Response
{
    /// <summary>
    /// Un objeto Response con la informacion del resultado y las preguntas
    /// </summary>
    internal interface IGetQuestionsResponse
    {
        /// <summary>
        /// El codigo de respuesta
        /// </summary>
        int ResponseCode { get; }

        /// <summary>
        /// Las preguntas obtenidas
        /// </summary>
        IEnumerable<IQuestion> Questions { get; }

        /// <summary>
        /// El error (si existe alguno)
        /// </summary>
        string Error { get; }

        /// <summary>
        /// Consulta si la respuesta posee algun error
        /// </summary>
        /// <returns>Verdadero si la respuesta posee errores</returns>
        bool HasError();
    }
}
