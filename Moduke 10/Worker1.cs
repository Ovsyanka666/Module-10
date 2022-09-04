namespace Moduke_10
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }        
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 1 started to work");
            Thread.Sleep(3000);
            Logger.Event("Worker 1 stopped working");
        }

    }

    public class Worker2 : IWorker
    {
        ILogger Logger { get; }        
        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 2 started to work");
            Thread.Sleep(3000);
            Logger.Event("Worker 2 stopped working");
        }

    }

    public class Worker3 : IWorker
    {
        ILogger Logger { get; }        
        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 3 started to work");
            Thread.Sleep(3000);
            Logger.Event("Worker 3 stopped working");
        }

    }



}