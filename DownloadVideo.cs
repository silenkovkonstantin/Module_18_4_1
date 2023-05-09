using YoutubeExplode.Videos;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module_18_4_1
{
    class DownloadVideo : Command
    {
        YoutubeClient youtube;
        string videourl;

        public DownloadVideo(YoutubeClient youtube, string videourl)
        {
            this.youtube = youtube;
            this.videourl = videourl;
        }

        // Выполнить
        public override async void Run()
        {
            Video videoInfo = await youtube.Videos.GetAsync(videourl);

            await youtube.Videos.DownloadAsync(videourl, $"{videoInfo.Title}");
        }
    }
}
