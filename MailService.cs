using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"mail Sservice: sending an email.. {args.Video.Title}" );
        }
    }
}
