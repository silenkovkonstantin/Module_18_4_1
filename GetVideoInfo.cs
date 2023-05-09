using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Module_18_4_1
{
    class GetVideoInfo : Command
    {
        YoutubeClient youtube;
        string videourl;

        public GetVideoInfo(YoutubeClient youtube, string videourl)
        {
            this.youtube = youtube;
            this.videourl = videourl;
        }

        // Выполнить
        public override async void Run()
        {
            Video videoInfo = await youtube.Videos.GetAsync(videourl);
            
            Console.WriteLine($"Название видео: {videoInfo.Title}\nОписание: {videoInfo.Description}");
        }
    }
}
