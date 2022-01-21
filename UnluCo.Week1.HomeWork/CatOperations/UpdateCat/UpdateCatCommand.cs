using System;
using System.Linq;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.UpdateCat
{
    public class UpdateCatCommand
    {

        public UpdateCatModel Model { get; set; }

        private readonly CatStoreDbContext _dbContext;
        public int CatId { get; set; }
        public UpdateCatCommand(CatStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var cat = _dbContext.Catz.SingleOrDefault(x => x.Id == CatId);
            if (cat == null)
            {
                throw new InvalidOperationException("Değişiklik yapmadınız"); //Hata olduğundaki mesajımız
            }

            cat.Name = Model.Name != default ? Model.Name : cat.Name; // Eğer cat.Name, Model.Name'ten farklı ise
            cat.Age = Model.Age != default ? Model.Age : cat.Age;     // cat.Name'ı Model.Name ile değiştir.
            cat.GenderId = Model.GenderId != default ? Model.GenderId : cat.GenderId;
            cat.Color = Model.Color != default ? Model.Color : cat.Color;
            _dbContext.SaveChanges(); // Database'e değişikliğin uygulanması için zorunlu!!!

        }

    }

    public class UpdateCatModel
    {
        public string Name { get; set; }
        public int GenderId { get; set; }
        public double Age { get; set; }
        public string Color { get; set; }

    }
}
