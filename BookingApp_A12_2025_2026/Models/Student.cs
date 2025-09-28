namespace BookingApp_A12_2025_2026.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Sora { get; set; }

        public override string ToString()
        {
            return "ID:" + Id + ", Name:" + Name;
        }

        public static List<Student> GetDemoStudents()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student { Id = 1, Name = "Kareem", Sora = "Photos/a1.png" });
            students.Add(new Student { Id = 2, Name = "Hoda", Sora = "Photos/a2.png" });
            students.Add(new Student { Id = 3, Name = "Hosni", Sora = "Photos/a3.png" });
            students.Add(new Student { Id = 4, Name = "Aya", Sora = "Photos/a4.png" });
            students.Add(new Student { Id = 5, Name = "Montaha", Sora = "Photos/a5.png" });
            students.Add(new Student { Id = 6, Name = "Mohamed", Sora = "Photos/a1.png" });
            students.Add(new Student { Id = 7, Name = "Wa3d", Sora = "Photos/a2.png" });
            students.Add(new Student { Id = 8, Name = "Zohdi", Sora = "Photos/a3.png" });
            students.Add(new Student { Id = 9, Name = "Noor", Sora = "Photos/a4.png" });
            students.Add(new Student { Id = 10, Name = "Fairoz", Sora = "Photos/a5.png" });
            return students;
        }
    }
}
