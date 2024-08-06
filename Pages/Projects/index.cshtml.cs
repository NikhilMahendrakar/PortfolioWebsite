// Pages/Projects/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Pages.Projects
{
    public class ProjectsModel : PageModel
    {
        // List of projects to display
        public List<Project> Projects { get; set; }

        // Called on HTTP GET requests
        public void OnGet()
        {
            // Sample project data (replace with real data source, e.g., a database)
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "SEO Recommender",
                    Description = "This project leverages OpenAI's API to provide SEO recommendations based on the analysis of a given webpage's content. The recommender extracts key information from the webpage and generates suggestions to improve its SEO performance.",
                    ImageUrl = "project1.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/SEORecommender.git",
                    Technologies = "Javascript, NodeJS, HTML, CSS",
                    WebsiteLink = "https://seorecommender-production.up.railway.app/",
                    IsWebsite = true,
                    
                },
                new Project
                {
                    Id = 2,
                    Title = "Csv Comparator",
                    Description = "A web application built with C# and .NET Core to find differences between two CSV files. The application checks for discrepancies in rows and columns, identifying missing rows and columns between the two files.",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/CsvComparator.git",
                    Technologies = "C#, .NET Core, HTML, CSS, Azure",
                    WebsiteLink = "https://csvcomparator.azurewebsites.net/",
                    IsWebsite =true
                },
                new Project{
                    Id = 3,
                    Title = "Web search and indexing Platform",
                    Description = "Developed a specialized search engine for computer science, utilizing a web crawler to scrape websites. Integrated PyLucene for page ranking within a Docker container, featuring a ReactJS frontend and a Python/Flask backend.",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/ansg191/CS172-Project.git",
                    Technologies = "Javascript, Python, ReactJS, Pylucene, Flask",
                    WebsiteLink = "https://cs172.anshulg.com/index.html",
                    IsWebsite =true
                },
                new Project {Id = 4,
                    Title = "Corner the Queen Game",
                    Description = "A web-based strategy game implementing AI with adjustable difficulty using the Minimax algorithm and alpha-beta pruning for optimal moves. Designed a dynamic grid-based UI to facilitate player interactions and highlight possible moves",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/CornertheQueen.git",
                    Technologies = "Javascript, Algorithms",
                    WebsiteLink = "https://nikhilmahendrakar.github.io/CornertheQueen/",
                    IsWebsite =true
                },
                  new Project {Id = 5,
                    Title = "Sorting Application",
                    Description = "A web application built with C# and .NET Core to upload, sort, and display student data using various sorting algorithms. The application allows users to upload a CSV file, select a column to sort by, and view the sorted results using different sorting algorithms.",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/SortingApplication.git",
                    Technologies = "C#, .NET Core, HTML, CSS, Azure",
                    WebsiteLink = "https://csvsorter.azurewebsites.net/",
                    IsWebsite =true
                },
                  new Project {Id = 6,
                    Title = "Numerical Pattern in Sentiments",
                    Description = "This paper aims to find numerical patterns in various sentences. This project aims to provide a range of numerical values given a sentence containing complex emotions. These numerical values can then be used for various other data analytics.",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/NumericalPatterninSentimentAnalysis.git",
                    Technologies = "C#, .NET Core, HTML, CSS, Azure",
                    
                    IsWebsite =false
                },
                   new Project {Id = 7,
                    Title = "Software Testing Project",
                    Description = "Streamlined testing by strategically applying branch and statement coverage principles, significantly reducing the test suite from thousands to just tens of cases while maintaining thorough bug detection capabilities. Reduces testing time by 80%.",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/SoftwareTestingProject.git",
                    Technologies = "C, Python",
                    
                    IsWebsite =false
                },


                   new Project {Id = 8,
                    Title = "Banking Ether Project",
                    Description = "Developed a full stack application to replicate the process of transferring Ether currency, making it as simple as online banking transactions. leveraging the use of Ganache and Truffle for mimicking the virtual Ethereum network.",
                    ImageUrl = "project2.jpg",  // Ensure the image exists in the wwwroot/images directory
                    ProjectUrl = "https://github.com/NikhilMahendrakar/BankingEtherProject.git",
                    Technologies = "Javascript, Solidity, HTML, CSS, Ethereum, Metamaks, Ganache",
                    
                    IsWebsite =false
                },
                
            };
        }
    }
}
