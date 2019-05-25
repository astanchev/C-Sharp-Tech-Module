using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MeTube_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoViews = new Dictionary<string, int>();
            var videoLikes = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stats time")
                {
                    break;
                }

                if (input.Contains('-'))
                {
                    string video = input.Split('-')[0];
                    int views = int.Parse(input.Split('-')[1]);

                    if (!videoViews.ContainsKey(video) && !videoLikes.ContainsKey(video))
                    {
                        videoViews[video] = views;
                        videoLikes[video] = 0;
                    }
                    else
                    {
                        videoViews[video] += views;
                    }

                }
                else if (input.Contains(':'))
                {
                    string command = input.Split(':')[0];
                    string video = input.Split(':')[1];

                    if (command == "like")
                    {
                        if (videoViews.ContainsKey(video)
                            && !videoLikes.ContainsKey(video))
                        {
                            videoLikes[video] = 1;
                        }
                        else if (videoViews.ContainsKey(video)
                                 && videoLikes.ContainsKey(video))
                        {
                            videoLikes[video]++;
                        }
                    }
                    else if (command == "dislike")
                    {
                        if (videoLikes.ContainsKey(video))
                        {
                            videoLikes[video] -= 1;
                        }
                    }
                }
            }

            string printCommand = Console.ReadLine();
            if (printCommand == "by views")
            {
                foreach (var video in videoViews.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"{video.Key} - {video.Value} views - {videoLikes[video.Key]} likes");
                }
            }
            else if (printCommand == "by likes")
            {
                foreach (var video in videoLikes.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"{video.Key} - {videoViews[video.Key]} views - {video.Value} likes");
                }
            }

        }
    }
}
