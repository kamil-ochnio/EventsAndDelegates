using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {



        // 1 define a delegate
        // 2 define an event based on that delegate
        // 3 raise the event

       // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // eventHandler
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Enoding Video..");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }

     
    }
}
