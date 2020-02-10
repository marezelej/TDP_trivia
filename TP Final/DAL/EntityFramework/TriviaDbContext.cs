using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;
using TP_Final.DAL.EntityFramework.Migrations;

namespace TP_Final.DAL.EntityFramework
{
    class TriviaDbContext : DbContext
    {
        /// <summary>
        /// Construye el DbContext con nombre AccountManager
        /// </summary>
        public TriviaDbContext() : base("TriviaConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TriviaDbContext, Configuration>());
        }

        /// <summary>
        /// Constructor que permite inyectar la conexión, utilizado por Effort
        /// </summary>
        public TriviaDbContext(DbConnection pConnection) : base(pConnection, true)
        {

        }

        /// <summary>
        /// Inicia el DbContext con la opción de migración activada
        /// </summary>
        internal static void Migrate()
        {
            new TriviaDbContext();
        }

        /// <summary>
        /// El conjunto de usuarios
        /// </summary>
        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
