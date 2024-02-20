using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;
using Lesson_47_property_services.MyPattern;

namespace Lesson_47_property_services.Services.StudentServices
{
    public class StudentService :IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string CreateStudent(StudentDTO studentDTO)
        {
            var result = _studentRepository.CreateStudent(studentDTO);

            return result;
        }

        public string DeleteStudent(int id)
        {
            var result = _studentRepository.DeleteStudent(id);
            return result;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var result = _studentRepository.GetAllStudents();
            return result;
        }

        public Student GetByIdStudent(int id)
        {
            var result = _studentRepository.GetByIdStudent(id);
            return result;
        }

        public string UpdateStudent(int id, StudentDTO studentDTO)
        {
            var result = _studentRepository.UpdateStudent(id, studentDTO);
            return result;
        }
    }
}
