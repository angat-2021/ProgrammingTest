using System;
using System.Collections.Generic;

namespace Exercise2Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>();
            var post1 = new Post();
            post1.Title = "Nepal is the best country in the world.";
            post1.Description = "Nepal , officially the Federal Democratic Republic of Nepal, is a sovereign country in South Asia. " +
                "It is mainly in the Himalayas, but also includes parts of the Indo-Gangetic Plain. " +
                "It is the 49th largest country by population and 93rd largest country by area. " +
                "It is landlocked and borders Tibet in the north and India in the south, east and west.";

            var post2 = new Post("MIS 3013", "MIS 3013 was one of the best class this semester.");
            var post3 = new Post("Thank you note to Adam", "You have taught me some cool shortcuts, " +
                "So I would like to thank you for teaching me cool stuffs.");
            var post4 = new Post("See you again Professor", "I am enrolled in another MIS class for which you are the insstructor. " +
                "I hope we will enjoy more in that class. " +
                "See you again next semester.");


            posts.Add(post1);
            posts.Add(post2);
            posts.Add(post3);
            posts.Add(post4);

            foreach (var post in posts)
            {
                if (post.WordLimitExceed()==true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your post titled as \"{post.Title}\" exceeds the word limit of 20 words by {post.WordCount()-20} words. Please reduce the word and repost it.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                var dateCreated = post.CreatePost();
                Console.WriteLine($"Title: {post.Title}\nDescription: {post.Description}\nPost creation date: {dateCreated}");
                post.CreateRandomLikes();
                post.CreateRandomDislikes();
                Console.WriteLine($"Current votes for this post: Likes: {post.UpVote()} | Dislikes: {post.DownVote()} ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your post titled as \"{post.Title}\" has been posted successfully.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
            }

            
        }
    }
}
