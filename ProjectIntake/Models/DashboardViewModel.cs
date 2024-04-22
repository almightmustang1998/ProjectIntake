namespace ProjectIntake.Models
{
    public class ProjectViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SubmittedBy { get; set; }

    }

    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }

    }

    public class DashboardViewModel
    {
        public List<ProjectViewModel> ProjectsToReview { get; set; }
        public List<ProfileViewModel> ProfilesToReview { get; set; }
    }

}
