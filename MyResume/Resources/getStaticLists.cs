using MyResume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Resources
{
    public static class getStaticLists
    {
        public static List<BlogPostModels> getBlogPostList()
        {
            List<BlogPostModels> list = new List<BlogPostModels>();

            BlogPostModels blog1 = new BlogPostModels("Title 1", "Content 1", DateTime.UtcNow, new List<JobTechnology>() { JobTechnology.iOS });
            BlogPostModels blog2 = new BlogPostModels("Title 2", "Content 2", DateTime.UtcNow, new List<JobTechnology>() { JobTechnology.CSharp });

            list.Add(blog1);
            list.Add(blog2);

            return list;
        }

        public static List<CourseModels> getCourseList()
        {
            List<CourseModels> list = new List<CourseModels>();

            CourseModels course1 = new CourseModels("School 1", "City 1", "Title 1", "Comment 1", DateTime.UtcNow.AddMonths(-5), DateTime.UtcNow, new List<JobTechnology>() { JobTechnology.iOS });
            CourseModels course2 = new CourseModels("School 2", "City 2", "Title 2", "Comment 2", DateTime.UtcNow.AddMonths(-5), DateTime.UtcNow, new List<JobTechnology>() { JobTechnology.CSharp });

            list.Add(course1);
            list.Add(course2);

            return list;
        }

        public static List<JobModels> getJobList()
        {
            List<JobModels> list = new List<JobModels>();

            JobModels job1 = new JobModels("Company 1", "City 1", "Title 1", "Comment 1", DateTime.UtcNow.AddMonths(-5), DateTime.UtcNow, new List<JobTechnology>() { JobTechnology.iOS });
            JobModels job2 = new JobModels("Company 2", "City 2", "Title 2", "Comment 2", DateTime.UtcNow.AddMonths(-5), DateTime.UtcNow, new List<JobTechnology>() { JobTechnology.CSharp });

            list.Add(job1);
            list.Add(job2);

            return list;
        }

        public static List<ProjectModels> getProjectList()
        {
            List<ProjectModels> list = new List<ProjectModels>();

            ProjectModels project1 = new ProjectModels("Title 1", "Comment 1", "GitHub 1", null, new List<JobTechnology>() { JobTechnology.iOS, JobTechnology.HTML, JobTechnology.CSS });
            ProjectModels project2 = new ProjectModels("Title 2", "Comment 2", null, "Link 2", new List<JobTechnology>() { JobTechnology.CSharp });

            list.Add(project1);
            list.Add(project2);

            return list;
        }
    }
}