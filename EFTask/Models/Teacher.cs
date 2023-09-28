namespace EFTask.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Subject { get; set; }
        public ICollection<Pupil> Pupils { get; set; }
    }
}
