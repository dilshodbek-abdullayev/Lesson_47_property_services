using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;
using Lesson_47_property_services.MyPattern;

namespace Lesson_47_property_services.Services.CourseService
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository course)
        {
            _courseRepository = course;
        }
        public string CreateCourse(CourseDTO courseDTO)
        {
            var result = _courseRepository.CreateCourse(courseDTO);
            return result;
        }

        public string DeleteCourse(int id)
        {
            var result = _courseRepository.DeleteCourse(id);
            return result;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            var result = _courseRepository.GetAllCourses();
            return result;
        }

        public Course GetByIdCourse(int id)
        {
            var result = _courseRepository.GetByIdCourse(id);
            return result;
        }
        public string UpdateCourse(int id, CourseDTO courseDTO)
        {
            var result = _courseRepository.UpdateCourse(id, courseDTO);
            return result;
        }
    }
}
