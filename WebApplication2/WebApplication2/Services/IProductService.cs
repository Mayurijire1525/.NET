using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IProductService
    {
        void Insert(Products product);
        List<Products> GetAll();

        Products GetById(int id);
        void Delete(int id);
        void Update(Products product);
    }
}
