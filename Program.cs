namespace EventsAndDelegates
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //Video Encoder jest delegatorem wiec funkcja do wywolywania innych funkcji o których nie mamy pojęcia ze istnieją, dodajemy je w pozniejszym etapie kodowania
            //dzięki czemu nasze aplikacje będą elastyczne na roszerzanie
            


            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();//publisher
            MailService mailService = new MailService();//subscriber
            MessageService messageService = new MessageService();


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }


    }
}
