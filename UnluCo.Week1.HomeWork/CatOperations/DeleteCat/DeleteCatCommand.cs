using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.DeleteCat
{
    public class DeleteCatCommand
    {
        private readonly CatStoreDbContext _dbContext;
        public int CatId { get; set; }
        public DeleteCatCommand(CatStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var cat = _dbContext.Catz.SingleOrDefault(x => x.Id == CatId);
            if (cat == null)
            {
                throw new InvalidOperationException("Silinecek öge bulunamadı");
            }
            _dbContext.Catz.Remove(cat);
            _dbContext.SaveChanges(); // Database'e değişikliğin uygulanması için zorunlu!!!
            

        }
    }



}
