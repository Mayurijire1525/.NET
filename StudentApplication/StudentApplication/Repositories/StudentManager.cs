using StudentApplication.Models;
using System.ComponentModel;
namespace StudentApplication.Repositories

{
    public class StudentManager : IStudentManager
    {
        public void Insert(Students students)
        {
            using (var context = new CollectionContext())
            {
                context.Students.Add(students);
                context.SaveChanges();
            }
        }
        public List<Students> GetAll()
        {
            using (var context = new CollectionContext())
            {
                var Students = from s
                               in context.Students
                               select s;
                return Students.ToList<Students>();

            }
        }
        public Students GetById(int id)
        {
            using(var context = new CollectionContext())
            {
               return  context.Students.Find(id);
            }
        }
        public void Delete(int id)
        {
            using(var context=new CollectionContext())
            {
                context.Students.Remove(context.Students.Find(id));
                context.SaveChanges();
            }
        }

    }
}

