using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;

namespace Lesson_47_property_services.Services.TeacherServices
{
    public interface ITeacherService
    {
        public IEnumerable<Teacher> GetAllTeachers();
        public Teacher GetByIdTeacher(int id);
        public string CreateTeacher(TeacherDTO teacher);
        public string UpdateTeacher(int id, TeacherDTO teacher);
        public string DeleteTeacher(int id);
    }
}
