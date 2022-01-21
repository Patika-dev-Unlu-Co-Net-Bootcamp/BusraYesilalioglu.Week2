using AutoMapper;
using System;
using System.Linq;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.CreateCat
{
    public class AddCatCommand
    {
        public AddCatModel Model { get; set; }

        private readonly CatStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public AddCatCommand(CatStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var cat = _dbContext.Catz.SingleOrDefault(x => x.Name == Model.Name); /*SingleOrDefault: Sorgulama sonunda kalan tek veriyi geri döndürür.
                                                                                   * Eğer listede birden fazla eleman varsa hata döndürür.
                                                                                   * Listede hiç eleman yoksa geriye null döndürür.*/

            if (cat != null)
            {
                throw new InvalidOperationException("Kedi zaten eklenmiş durumda");
            }


            cat = _mapper.Map<Cats>(Model);   

            _dbContext.Catz.Add(cat);
            _dbContext.SaveChanges();
        }
        public class AddCatModel
        {
            public string Name { get; set; }
            public string Breed { get; set; }
            public int GenderId { get; set; }
            public double Age { get; set; }
            public string Color { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    }
}
