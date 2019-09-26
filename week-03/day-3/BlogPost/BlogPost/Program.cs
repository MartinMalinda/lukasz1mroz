using System;
using System.Collections.Generic;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            string loremText = "Lorem ipsum dolor sit amet.";
            string waitText = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            string engineerText = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";

            BlogPost lorem = new BlogPost("Jon Doe", "Lorem ipsum", loremText, "2000.05.04");
            BlogPost wait = new BlogPost("Tim Urban", "Wait and why", waitText, "2010.10.10.");
            BlogPost engineer = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", engineerText, "2017.03.28");

            //lorem.Blog();
            //wait.Blog();
            //engineer.Blog();
            
            List<BlogPost> blogPosts = new List<BlogPost>() { lorem, wait, engineer };

            foreach (var blogPost in blogPosts)
            {
                blogPost.Blog();
            }
        }
    }
}
