namespace EFTask.Models
{
    public class Pupil
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
