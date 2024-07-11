using StudentApplication.Models;

namespace StudentApplication.Repositories
{
    public interface IStudentManager
    {
        void Insert(Students students);

        List<Students> GetAll();

        Students GetById(int id);
        void Delete(int id);
    }
}
