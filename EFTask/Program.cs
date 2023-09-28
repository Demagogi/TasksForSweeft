/*დაწერეთ აპლიკაცია EntityFramework-ის (Code-First) გამოყენებით დავალება 6-
ის მოცემულობით. დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა
მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომლის სახელია: „გიორგი“.*/

using EFTask;
using EFTask.Models;

using (var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();

    // Create teachers and pupils
    var teacher1 = new Teacher { Name = "დათო" };
    var teacher2 = new Teacher { Name = "ელიზბარი" };
    var pupil1 = new Pupil { Name = "გიორგი" };
    var pupil2 = new Pupil { Name = "ლადო" };

    // Add teacher-pupil relationships
    context.TeacherPupils.Add(new TeacherPupil { Teacher = teacher1, Pupil = pupil1 });
    context.TeacherPupils.Add(new TeacherPupil { Teacher = teacher1, Pupil = pupil2 });
    context.TeacherPupils.Add(new TeacherPupil { Teacher = teacher2, Pupil = pupil2 });

    context.SaveChanges();

    var teachers = SearchFactory.GetAllTeachersByStudent(context, pupil1.Name);
}