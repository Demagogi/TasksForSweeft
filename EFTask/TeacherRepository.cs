using EFTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTask
{
    public class TeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAllTeachersByStudent(string studentName)
        {
            var teachers = _context.Teachers
               .Include(tp => tp.Pupils)
               .Where(t => t.Pupils.Any(tp => tp.Name == studentName))
               .ToList();

            return teachers;
        }
    }
}
