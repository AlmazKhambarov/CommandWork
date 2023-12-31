﻿using TestProject.Domains;

namespace TestProject.Services.Interfaces;

public interface IProductRepository
{
    Task<Product> GetProductByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> CreateProductAsync(Product entity);
    Task<Product> UpdateProductAsync(Product entity);
    Task<Product> DeleteProductAsync(int Id);
    Task<Product> GetOldValueAsync(int id);
    Task<Product> CreateAudit(Product entity, Product oldValue, string actionType, User user);
}