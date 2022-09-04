namespace Unit
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }

    public interface ICalculator
    {
        void Solve(int num);
        void Solve(int num1, int num2);
    }

    public class BaseCalculator : ICalculator, IWriter
    {
        void ICalculator.Solve(int num)
        {
            throw new NotImplementedException();
        }

        void ICalculator.Solve(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        void IWriter.Write()
        {

        }

    }
    public interface IWriter
    {
        void Write();
    }

    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            
        }
    }

}
