using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.UpdateCat
{
    public class UpdateCatNameCommand
    {
        public UpdateCatNameModel Model { get; set; }

        private readonly CatStoreDbContext _dbContext;
        public int CatId { get; set; }
        public UpdateCatNameCommand(CatStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Handle()
        {
            var cat = _dbContext.Catz.SingleOrDefault(x => x.Id == CatId);
            if (cat == null)
            {
                throw new InvalidOperationException("İsimde değişiklik yapılamadı.Id yanlış");
            }

            cat.Name = Model.Name != default ? Model.Name : cat.Name; // Eğer cat.Name, Model.Name'ten farklı ise
                                                                      // cat.Name'ı Model.Name ile değiştir.
           
            _dbContext.SaveChanges(); // Database'e değişikliğin uygulanması için zorunlu!!!



        }

    }

    public class UpdateCatNameModel
    {
        public string Name { get; set; }
       
    }
}
