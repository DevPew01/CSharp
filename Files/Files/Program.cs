using System;
using System.Text;
using System.IO;

namespace Files
{
    class Program
    {
        static void Save(FileStream file, ref double[,] arrayDob, ref int[,] arrayInt, ref int rows, ref int cols)
        {
            string Data = $"Ераносян Георгий Погосович {new DateTime(1997, 9, 14, 7, 32, 12).ToString()}";

            using (StreamWriter writer = new StreamWriter(file, Encoding.Default))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(arrayDob[i, j].ToString());
                        writer.Write(' ');
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(arrayInt[i, j].ToString());
                        writer.Write(' ');
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        writer.Write(arrayDob[i, j].ToString());

                writer.WriteLine();
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(arrayInt[i, j].ToString());
                        writer.Write(' ');
                    }
                writer.WriteLine();

                writer.WriteLine($"Строки: {rows}, столбцы {cols}");
                writer.WriteLine();
                writer.Write(Data);
            }
        }

        static void Load()
        {
            string Data = $"Ераносян Георгий Погосович {new DateTime(1997, 9, 14, 7, 32, 12).ToString()}";
            using (StreamReader reader = new StreamReader("Day18.txt"))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }

        static void Main(string[] args)
        {
            if (!File.Exists("Day18.txt"))
                File.Create("Day18.txt");
            else
                Console.WriteLine("Такой файл уже существует.");
            int rows = 5;
            int cols = 5;
            double[,] arrayDob = new double[rows, cols];

            Random random = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    arrayDob[i, j] = random.Next(1, 15) * 0.1;

            int[,] arrayInt = new int[5, 5];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    arrayInt[i, j] = random.Next(1, 15);
            FileStream file = new FileStream("Day18.txt", FileMode.OpenOrCreate);
            Save(file, ref arrayDob,ref arrayInt, ref rows, ref cols);
            Load();
        }
    }
}