using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        
        Random random = new Random();

        
        TextWriterTraceListener listener = new TextWriterTraceListener(File.CreateText("log.txt"));
        Trace.Listeners.Add(listener);

        
        Trace.WriteLine("Программа запущена", "Информация");

        char exitChar = 'q';

        while (true)
        {
           
            int a = random.Next(100);
            int b = random.Next(100);

           
            string operation = random.Next(4) switch
            {
                0 => "+",
                1 => "-",
                2 => "*",
                _ => "/"
            };

           
            double result = CalculateResult(a, b, operation);

           
            Trace.Write($"Пример: {a} {operation} {b} = ", TraceEventType.Information);

           
            Console.Write("Ответ: ");
            string answer = Console.ReadLine();

            
            if (!double.TryParse(answer, out double userAnswer))
            {
                
                Trace.WriteLine("Неверный формат ответа!", TraceEventType.Warning);
                continue;
            }

            if (Math.Abs(result - double.Parse(answer)) > 0.0001)
            {
                
                Trace.WriteLine($"Неверный ответ! Правильный ответ: {result}", TraceEventType.Warning);
            }
            else
            {
                
                Trace.WriteLine("Правильно!", TraceEventType.Information);
            }

            
            if (Console.ReadKey().KeyChar == exitChar)
            {
                break; 
            }
        }

        
        Trace.WriteLine("Программа завершена", "Информация");
    }

    private static double CalculateResult(int a, int b, string operation)
    {
        switch (operation)
        {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/": return a / (double)b; // Деление может дать дробь
        }

        throw new ArgumentException("Неизвестная операция!");
    }
}