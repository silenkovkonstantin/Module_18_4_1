using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Module_18_4_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ссылку на  Youtube-видео");

            string videoUrl = VideoId.Parse(Console.ReadLine() ?? "");

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var youtube = new YoutubeClient();

            // создадим команду получение информации о видео
            var getVideoInfo = new GetVideoInfo(youtube, videoUrl);

            // инициализация команды
            sender.SetCommand(getVideoInfo);

            //  выполнение
            sender.Run();

            // создадим команду на скачивание видео
            var downloadVideo = new DownloadVideo(youtube, videoUrl);

            // инициализация команды
            sender.SetCommand(downloadVideo);

            // выполнение
            sender.Run();
        }
    }

}