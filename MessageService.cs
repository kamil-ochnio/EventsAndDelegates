using System;

namespace EventsAndDelegates
{
    partial class Program
    {
        public class MessageService
        {
            public void OnVideoEncoded(object source, VideoEventArgs args)
            {
                System.Console.WriteLine($"MessageService: sending a text message {args.Video.Title}");
            }
        }


    }
}
