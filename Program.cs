
namespace YouTubeDownloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // адрес видео
            Console.WriteLine("Дайте ссылку видео на YouTube, которое хочется скачать. Например, такую: https://www.youtube.com/watch?v=DURvbAK1cAY");
            string url = Console.ReadLine();
            Console.WriteLine();

            // папка для скачивания
            string path = "D:/Repositories/FirstApplication.ConsoleApp/YouTubeDownloader/YouTubeDownloader/bin/Debug/net7.0";  

            var sender = new Sender();
            var receiver = new Receiver();

            // Получаем инфо о видео
            var getInfo = new GetInfo(receiver);
            sender.SetCommand(getInfo);
            sender.Run(url, path);

            // Скачиваем видео
            var download = new Download(receiver);
            sender.SetCommand(download);
            sender.Run(url, path);

            Console.ReadKey();
        }
    }
}