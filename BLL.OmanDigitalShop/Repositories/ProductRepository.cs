using BLL.OmanDigitalShop.Context;
using DAL.OmanDigitalShop.Interfaces;
using DAL.OmanDigitalShop.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace BLL.OmanDigitalShop.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public Product filter(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
