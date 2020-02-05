namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workFlow = new Workflow();
            workFlow.AddTask(new VideoUploader());
            workFlow.AddTask(new ChangeStatus());

            WorkFlowEngine engine = new WorkFlowEngine();
            engine.Run(workFlow);
            
        }
    }
}
