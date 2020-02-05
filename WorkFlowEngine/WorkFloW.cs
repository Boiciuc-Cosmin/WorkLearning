using System;

namespace WorkFlowEngine
{
    public class WorkFlowEngine
    {       
        public void Run(IWorkflow workflow)
        {
            foreach (ITask task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception)
                {
                    throw new InvalidCastException();                   
                }
                
            }
        }
    }
}
