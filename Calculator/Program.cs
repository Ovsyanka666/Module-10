namespace Calculator
{
    class Program
    {
        static void Main()
        {
            try
            {
                Logger logger = new Logger();
                Calculator calculator = new Calculator(logger);
                Console.Write("Введите первое число: ");
                calculator.a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                calculator.b = Convert.ToInt32(Console.ReadLine());

                calculator.Addition();
            }

            catch (System.FormatException)
            {
                Logger Logger = new Logger();
                Logger.Error("Введено неверное значение");
            }
            catch (System.OverflowException)
            {
                Logger Logger = new Logger();
                Logger.Error("Введено слишком большое число");                
            }
        }
    }

    public interface ICalculator
    {
        public void Addition();
    }

    public class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public int a, b;
        public void Addition()
        {
            Logger.Event("Калькулятор начал работу");
            int res = a + b; 
            Console.WriteLine("Сумма равна: " + res);
            Logger.Event("Калькулятор закончил работу");
        }
    }

    //логгер

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
