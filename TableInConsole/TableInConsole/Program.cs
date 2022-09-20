using System;

namespace TableInConsole
{
    class Program
    {
        static int tableWidth = 73;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            PrintLine();
            PrintRow("Nombre", "Apellido", "Materia", "Nota", "Estado");

            PrintLine();
            PrintRow("Tomás", "Di Leo", "Matemática", "8", "Aprobada");

            PrintLine();
            PrintRow("Atty", "Quirino", "Programación", "8", "Aprobada");

            PrintLine();
            PrintRow("Lucca", "Quirino", "Codigología", "8", "Aprobada");

            PrintLine();
            PrintRow("Claudio", "Pedalino", "Profesor", "9", "Aprobada");

            PrintLine();
            Console.ReadLine();
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach(string column in columns)
            {
                row += Aligncenter(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string Aligncenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if(string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }

            else
            {
                return text.PadRight(width - (width - text.Length)/2).PadLeft(width);
            }
        }
    }
}
