using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== YouTube Video Program ===\n");

            // Create a list to hold all videos
            List<Video> videos = new List<Video>();

            // Create Video 1 - Programming Tutorial
            Video video1 = new Video("Learn C# in 1 Hour", "CodeMaster Pro", 3600);
            video1.AddComment(new Comment("Alice Johnson", "This tutorial saved me! So clear and concise."));
            video1.AddComment(new Comment("Bob Smith", "Great examples, but could use more practice exercises."));
            video1.AddComment(new Comment("Charlie Davis", "Perfect for beginners. Thank you!"));
            video1.AddComment(new Comment("Diana Miller", "The section on LINQ was especially helpful."));
            videos.Add(video1);

            // Create Video 2 - Cooking
            Video video2 = new Video("Authentic Italian Pasta", "Chef Giovanni", 1740);
            video2.AddComment(new Comment("Ethan Wilson", "My family loved this recipe!"));
            video2.AddComment(new Comment("Fiona Garcia", "Can I use gluten-free pasta?"));
            video2.AddComment(new Comment("George Brown", "The sauce was a bit too salty for my taste."));
            video2.AddComment(new Comment("Hannah Lee", "Made this for date night - huge success!"));
            videos.Add(video2);

            // Create Video 3 - Fitness
            Video video3 = new Video("Full Body Workout at Home", "FitLife Coach", 2520);
            video3.AddComment(new Comment("Ian Taylor", "Killer workout! Feeling it the next day."));
            video3.AddComment(new Comment("Julia Chen", "No equipment needed - perfect for my apartment."));
            video3.AddComment(new Comment("Kevin Martinez", "The burpees section was brutal but effective."));
            videos.Add(video3);

            // Create Video 4 - Music (4th video as requested)
            Video video4 = new Video("Guitar Basics for Beginners", "Music Mentor", 2880);
            video4.AddComment(new Comment("Lisa Anderson", "Finally learned my first chord!"));
            video4.AddComment(new Comment("Mike Thompson", "Wish there was more on fingerpicking techniques."));
            video4.AddComment(new Comment("Nancy White", "Your teaching style is so patient and encouraging."));
            video4.AddComment(new Comment("Oliver Harris", "Perfect pace for absolute beginners like me."));
            videos.Add(video4);

            // Display all videos with their comments
            DisplayAllVideos(videos);
        }

        static void DisplayAllVideos(List<Video> videos)
        {
            Console.WriteLine($"Total Videos in Collection: {videos.Count}\n");

            for (int i = 0; i < videos.Count; i++)
            {
                Video video = videos[i];
                
                Console.WriteLine($"═══════════════════════════════════════════════════");
                Console.WriteLine($"VIDEO #{i + 1}");
                Console.WriteLine($"═══════════════════════════════════════════════════");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetFormattedLength()}");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine();

                Console.WriteLine("Comments:");
                Console.WriteLine("---------");
                
                List<Comment> comments = video.GetComments();
                for (int j = 0; j < comments.Count; j++)
                {
                    Console.WriteLine($"  {j + 1}. {comments[j].ToString()}");
                }
                
                Console.WriteLine();
            }

            // Display summary statistics
            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine("SUMMARY STATISTICS");
            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine($"Total videos processed: {videos.Count}");
            
            int totalComments = 0;
            foreach (Video video in videos)
            {
                totalComments += video.GetCommentCount();
            }
            Console.WriteLine($"Total comments across all videos: {totalComments}");
            Console.WriteLine($"Average comments per video: {totalComments / (double)videos.Count:F1}");
        }
    }
}