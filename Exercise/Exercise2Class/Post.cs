using System;

namespace Exercise2Class
{
    public class Post
    {
        
        private DateTime _dateCreated;
        public string Title { get; set; }
        public string Description { get; set; }
        private int Like { get; set; }
        private int Dislike { get; set; }
        public Post()
        {

        }
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public int WordCount()
        {
            string[] words = Description.Split(' ');
            int count=0;
            foreach (var word in words)
            {
                count++;

                if (word=="."||word=="!"||word=="?"||word==",")
                {
                    count--;
                }
            }
            return count;
        }
        public DateTime CreatePost()
        {
            _dateCreated = DateTime.Now;
            return _dateCreated;
        }
        public int UpVote()
        {
            
            return Like++;
        }
        public int DownVote()
        {
            return Dislike++;
        }

        public int CreateRandomLikes()
        {
            Random rand = new Random();
            int randomLikes = rand.Next(1, 20);
            for (int i = 0; i < randomLikes; i++)
            {
                UpVote();
            }
            return UpVote();
        }

        public int CreateRandomDislikes()
        {
            Random rand = new Random();
            int randomLikes = rand.Next(1, 20);
            for (int i = 0; i < randomLikes; i++)
            {
                DownVote();
            }
            return DownVote();
        }

        public bool WordLimitExceed()
        {
            bool restrictPosting= false;
            if (WordCount()>20)
            {
                restrictPosting = true;
            }
            return restrictPosting;
        }
    }
}
