using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;

namespace Lesson_47_property_services.MyPattern
{
    public interface ITeacherRepository
    {
        public string CreateTeacher(TeacherDTO teacherDTO);
        public IEnumerable<Teacher> GetAllTeachers();
        public Teacher GetByIdTeacher(int id);
        public string DeleteTeacher(int id);
        public string UpdateTeacher(int id, TeacherDTO teacherDTO);

    }
}
