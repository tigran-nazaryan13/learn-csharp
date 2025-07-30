namespace StudentDashboard.Models
{
    public class HonorsStudent : Student
    {
        public override string GetStatus()
        {
            if (Grade > 85)
            {
                return "Honors Student";
            }
            else
            {
                return base.GetStatus();
            }
        }
    }
}