using StudentApplication.Models;
namespace StudentApplication.Services
{
    public interface IStudentService
    {
        void Insert(Students student);
        List<Students> GetAll();
        Students GetById(int id);
        void Delete(int id);
    }
}
