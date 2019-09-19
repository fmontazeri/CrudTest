using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmCrudTest.Data.Context;

namespace FmCrudTest.Data.Configuratins
{

    public class ApplicationDbConfiguration : CreateDatabaseIfNotExists<TestDbContext>
    {
        public override void InitializeDatabase(TestDbContext context)
        {
            context.Database.ExecuteSqlCommand("CREATE DATABASE {0} COLLATE Latin1_General_CI_AS", "FatemehMontazeriDb");
        }
    }


}
