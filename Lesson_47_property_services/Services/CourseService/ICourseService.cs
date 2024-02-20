using Lesson_47_property_services.Entities;
using Lesson_47_property_services.Models;

namespace Lesson_47_property_services.Services.CourseService
{
    public interface ICourseService
    {
        public string CreateCourse(CourseDTO courseDTO);
        public IEnumerable<Course> GetAllCourses();
        public Course GetByIdCourse(int id);
        public string DeleteCourse(int id);
        public string UpdateCourse(int id, CourseDTO courseDTO);
    }
}
