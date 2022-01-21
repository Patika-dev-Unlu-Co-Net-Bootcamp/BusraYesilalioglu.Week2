using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.DBOperations
{
    public class CatStoreDbContext: DbContext  //Db'sin kurulumu
    {
        public CatStoreDbContext(DbContextOptions<CatStoreDbContext> options):base(options)
        { }

        public DbSet<Cats> Catz { get; set; }



    }
}
