﻿using BestFindsApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFindsApi.Data
{
    public interface IProductRepository
    {
        Task<Product[]> GetAllProductsAsync();
        Task<Product[]> GetAllProductsByCategory(int categoryId);
    }
}
