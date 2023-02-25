
namespace YouTubeDownloader
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void Run(string url, string path);
    }
}
