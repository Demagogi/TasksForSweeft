using EFTask;
using EFTask.Models;

using (var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();

    // Create teachers and pupils
    var teacher1 = new Teacher { Name = "Dato" };
    var teacher2 = new Teacher { Name = "Germana" };
    var pupil1 = new Pupil { Name = "Giorgi" };
    var pupil2 = new Pupil { Name = "Lado" };

    // Add teacher-pupil relationships
    context.TeacherPupils.Add(new TeacherPupil { Teacher = teacher1, Pupil = pupil1 });
    context.TeacherPupils.Add(new TeacherPupil { Teacher = teacher1, Pupil = pupil2 });
    context.TeacherPupils.Add(new TeacherPupil { Teacher = teacher2, Pupil = pupil2 });

    context.SaveChanges();

    var teachers = SearchFactory.GetAllTeachersByStudent(context, pupil1.Name);
}