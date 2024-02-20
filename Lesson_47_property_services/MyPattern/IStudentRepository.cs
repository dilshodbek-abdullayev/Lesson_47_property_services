using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;

namespace Lesson_47_property_services.MyPattern
{
    public interface IStudentRepository
    {
        public string CreateStudent(StudentDTO studentDTO);
        public IEnumerable<Student> GetAllStudents();
        public Student GetByIdStudent(int id);
        public string DeleteStudent(int id);
        public string UpdateStudent(int id, StudentDTO studentDTO);

    }
}
