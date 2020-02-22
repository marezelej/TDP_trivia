using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.DAL.EntityFramework;
using TriviaGame.Controller;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[INFO] Realizando migraciones...");
            TriviaDbContext.Migrate();
            Console.WriteLine("[OK] La base de datos fué migrada correctamente");

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
