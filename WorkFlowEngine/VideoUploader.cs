using System;

namespace WorkFlowEngine
{
    public class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video!");
        }
    }
}
