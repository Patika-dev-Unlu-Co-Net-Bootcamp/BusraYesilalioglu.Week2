using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.CatOperations.OrderByCat
{
    public class OrderByCatQuery
    {
        public string colon { get; set; }
        public string orderby { get; set; }
        private readonly IMapper _mapper;
        private readonly CatStoreDbContext _dbContext;

        public OrderByCatQuery(CatStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<OrderByCatViewModel> Handle()
        {

            
            
            if (colon == "Name" && orderby == "asc")
            {
               var catlist = _dbContext.Catz.OrderBy(x => x.Name).ToList();

                List<OrderByCatViewModel> vm = _mapper.Map<List<OrderByCatViewModel>>(catlist);
                return vm;
            }

            else if (colon == "Name" && orderby == "desc")
            {
               var catlist = _dbContext.Catz.OrderByDescending(x => x.Name).ToList();

                List<OrderByCatViewModel> vm = _mapper.Map<List<OrderByCatViewModel>>(catlist);
                return vm;
            }
           
            _dbContext.SaveChanges(); // Database'e değişikliğin uygulanması için zorunlu!!!
            return Handle() ;
        }

    }
    public class OrderByCatViewModel
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public double Age { get; set; }
        public string Color { get; set; }
        public string DateOfBirth { get; set; }
    }
}
