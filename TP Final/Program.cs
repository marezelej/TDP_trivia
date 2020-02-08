using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Trivia;

namespace TP_Final
{
    class Program
    {
        static CFachadaConjuntos iCConjuntos = new CFachadaConjuntos();
        static CFachadaSesiones iCSesiones = new CFachadaSesiones();
        static void Main(string[] args)
        {
            /*
            El usuario deberá poder seleccionar el conjunto de preguntas que querrá utilizar, si
            solamente existe un conjunto, se seleccionará automáticamente el existente.

            El usuario deberá:
            1 Seleccionar la categoría de las preguntas.
            2 Elegir el nivel de dificultad de las preguntas.
            3 Seleccionar la cantidad de preguntas a contestar, que como mínimo deberán ser 10.*/

            UserFacade facade = new UserFacade();

            facade.Authenticate("14119550", "12345678");

            /*
            IList<Conjunto> conjuntos = iCConjuntos.GetConjuntosDisponibles();
            iCConjuntos.SetConjunto(conjuntos.First());
            foreach (Conjunto con in conjuntos)
            {
                Console.WriteLine(con.Nombre);
            }

            IList<Categoria> categorias = iCConjuntos.GetCategoriasDisponibles();
            iCConjuntos.SetCategoria(categorias.First());
            foreach (Categoria cat in categorias)
            {
                Console.WriteLine(cat.Name);
            }

            IList<Dificultad> dificultades = iCConjuntos.GetDificultadesDisponibles();
            iCConjuntos.SetDificultad(categorias.First());
            foreach (Dificultad dif in dificultades)
            {
                Console.WriteLine(dif.Name);
            }

            Pregunta pregunta = iCConjuntos.GetPregunta();
            IList<Respuesta> respuestas = pregunta.GetRespuestas();
            foreach(Respuesta res in respuestas)
            {
                Console.WriteLine(res.Name);
            }
            if (pregunta.EsCorrecta(respuestas.First()))
            {
                Console.WriteLine("correctooo");
            }
            else
            {
                Console.WriteLine("incorrectooo");
            }
            int tiempo = iCConjuntos.GetTiempoEstimado(10);
            Sesion sesion = new Sesion(new Usuario());
            */
        }
    }
}
