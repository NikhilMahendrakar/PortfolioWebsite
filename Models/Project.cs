// Models/Project.cs
namespace PortfolioWebsite.Models
{
    public class Project
    {
        // Unique identifier for the project
        public int Id { get; set; }

        // Title of the project
        public string Title { get; set; }

        // Short description of the project
        public string Description { get; set; }

        // URL of the project image for display on the website
        public string ImageUrl { get; set; }

        // URL to the project repository or live demo
        public string ProjectUrl { get; set; }

        // Technologies used in the project
        public string Technologies { get; set; }

        public bool IsWebsite{ get; set;}

        public string WebsiteLink {get; set;}
    }
}
