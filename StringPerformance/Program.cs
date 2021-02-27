using System;
using System.Diagnostics;
using System.Text;

namespace StringPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hola Mundo";
            //var result = stringProcess(text, 1000);
            var result = stringBuilderProcess(text, 1000);

        }

        private static object stringBuilderProcess(string text, int quantity)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("stringBuilderProccess is processing...");
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    stringBuilder.Append(text[j]);
                }
                stringBuilder.Append("\n");
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("stringBuilder runTime: " + elapsedTime);
            return stringBuilder.ToString();
        }

        private static object stringProcess(string text, int quantity)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("stringProccess is processing...");
            String str = string.Empty;
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    str += text[j];
                }
                str += "\n";
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("string runTime: " + elapsedTime);
            return str;
        }



    }
}
