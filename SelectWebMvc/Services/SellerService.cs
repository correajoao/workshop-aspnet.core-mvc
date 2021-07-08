﻿using SelectWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SelectWebMvc.Services
{
    public class SellerService
    {
        private readonly SelectWebMvcContext _context;

        public SellerService(SelectWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
