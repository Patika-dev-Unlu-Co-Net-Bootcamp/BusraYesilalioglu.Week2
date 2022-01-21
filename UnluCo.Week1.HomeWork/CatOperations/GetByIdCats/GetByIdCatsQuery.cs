using AutoMapper;
using System;
using System.Linq;
using UnluCo.Week1.HomeWork.Common;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.GetByIdCats
{
    public class GetByIdCatsQuery
    {
        private readonly IMapper _mapper;
        private readonly CatStoreDbContext _dbContext;
        public int CatId { get; set; }
        public GetByIdCatsQuery(CatStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public ByIdCatsViewModel Handle()
        {
            var cat = _dbContext.Catz.Where(cat => cat.Id == CatId).SingleOrDefault(); //Where sorgularda filtreleme için kullanılır.
            if (cat is null)
            {
                throw new InvalidOperationException("Kedi Bulunamadı");
            }

            ByIdCatsViewModel vm = _mapper.Map<ByIdCatsViewModel>(cat);
           
            return vm;
        }
    }

    public class ByIdCatsViewModel
    {

        public string Name { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public double Age { get; set; }
        public string Color { get; set; }
        public string DateOfBirth { get; set; }

    }
}

