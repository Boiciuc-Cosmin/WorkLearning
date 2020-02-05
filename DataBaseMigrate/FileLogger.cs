using System.IO;

namespace DataBaseMigrate
{
    public class FileLogger : ILogger
    {
        public readonly string Path;
        public FileLogger(string path)
        {
            Path = path;
        }           

        public void LogError(string message)
        {
            Log(message, "ERROR");          
          
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(Path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
