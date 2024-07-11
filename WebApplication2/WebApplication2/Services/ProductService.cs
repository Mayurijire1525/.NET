using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Services
{
    public class ProductService : IProductService
    {
        private IProductManager productManager=new ProductManager();

        public void Insert(Products product)
        {
            productManager.Insert(product);
        }
        public List<Products> GetAll()
        {
            return productManager.GetAll();
        }
        public Products GetById(int id)
        {
            return productManager.GetById(id);
        }
        public void Update(Products product)
        {
            productManager.Update(product);
        }
        public void Delete(int id)
        {
            productManager.Delete(id);
        }

    }
}
