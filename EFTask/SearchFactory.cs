using EFTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTask
{
    public static class SearchFactory
    {
        public static List<Teacher> GetAllTeachersByStudent(ApplicationDbContext context, string studentName)
        {
            var teachers = context.Teachers
               .Include(t => t.TeacherPupils)
               .ThenInclude(tp => tp.Pupil)
               .Where(t => t.TeacherPupils.Any(tp => tp.Pupil.Name == studentName))
               .ToList();

            return teachers;
        }
    }
}
