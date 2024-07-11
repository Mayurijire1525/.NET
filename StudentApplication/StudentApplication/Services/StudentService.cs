using StudentApplication.Models;
using StudentApplication.Repositories;

namespace StudentApplication.Services
{
    public class StudentService : IStudentService
    {
        IStudentManager studentManager=new StudentManager();

        public void Insert(Students students)
        {
            studentManager.Insert(students);
        }
        public List<Students> GetAll()
        {
            return studentManager.GetAll();
        }
        public Students GetById(int id)
        {
            return studentManager.GetById(id);
        }
        public void Delete(int id)
        {
            studentManager.Delete(id);
        }


    }

    
}
