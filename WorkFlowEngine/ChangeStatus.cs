using System;

namespace WorkFlowEngine
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing status");
        }
    }
}
