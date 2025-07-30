namespace StudentDashboard.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public virtual string GetStatus()
        {
            if (Grade > 60 || Grade == 60)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
//Comment