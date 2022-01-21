using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using UnluCo.Week1.HomeWork.Common;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.GetCats
{
    public class GetCatsQuery
    {
        private readonly IMapper _mapper;
        private readonly CatStoreDbContext _dbContext;
        public GetCatsQuery(CatStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<CatsViewModel> Handle()
        {
            var catlist = _dbContext.Catz.OrderBy(x => x.Id).ToList<Cats>();  /*OrderBy() bir listeyi sıralamak için kullanılır.*/
            List<CatsViewModel> vm = _mapper.Map<List<CatsViewModel>>(catlist);
           
            return vm;
        }

    }

    public class CatsViewModel
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public double Age { get; set; }
        public string Color { get; set; }
        public string DateOfBirth { get; set; }
    }
}
