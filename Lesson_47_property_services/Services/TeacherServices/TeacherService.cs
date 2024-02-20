using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;
using Lesson_47_property_services.MyPattern;

namespace Lesson_47_property_services.Services.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        private ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public string CreateTeacher(TeacherDTO teacher)
        {
            var result = _teacherRepository.CreateTeacher(teacher);

            return result;
        }

        public string DeleteTeacher(int id)
        {
            var result = _teacherRepository.DeleteTeacher(id);
            return result;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            IEnumerable<Teacher>? result = _teacherRepository.GetAllTeachers();
            return result;
        }

        public Teacher GetByIdTeacher(int id)
        {
            Teacher? result = _teacherRepository.GetByIdTeacher(id);
            return result;
        }

        public string UpdateTeacher(int id, TeacherDTO teacher)
        {
            var result = _teacherRepository.UpdateTeacher(id, teacher);
            return result;
        }
    }
}
