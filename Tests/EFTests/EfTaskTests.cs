using EFTask;
using EFTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Tests.EFTask
{
    [TestFixture]
    public class EfTaskTests
    {
        private string _connectionString;

        [Test]
        public void Test()
        {
            var options = SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), _connectionString).Options;

            using (var context = new ApplicationDbContext(options))
            {
                context.Database.EnsureCreated();

                // Create teachers and pupils
                var teacher1 = new Teacher { Name = "დათო" };
                var teacher2 = new Teacher { Name = "ელიზბარი" };
                var pupil1 = new Pupil { Name = "გიორგი" };
                var pupil2 = new Pupil { Name = "ლადო" };


                // Add teacher-pupil relationships
                teacher1.Pupils.Add(pupil1);
                teacher1.Pupils.Add(pupil2);
                teacher2.Pupils.Add(pupil2);


                context.SaveChanges();

                var repository = new TeacherRepository(context);

                var teachers = repository.GetAllTeachersByStudent(pupil1.Name);
            }
        }

        [SetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: true)
                .Build();

            var _connectionString = config.GetRequiredSection("ConnectionStrings:EFTask").Value;
        }
    }
}
