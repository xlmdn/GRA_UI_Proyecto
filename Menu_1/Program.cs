using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int horizontal = 0;
        int vertical = 0;
        int col = 24; 
        int fil = 115; 
        bool arriba = true;

        for (int i = 0; i < 234; i++)
        {
            Console.SetCursorPosition(fil, col);

            if (horizontal < 6)
            {
                if (horizontal == 0) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*");
                fil--; 
                horizontal++;
                if (horizontal == 6)
                {
                    vertical = 0; 
                }
                System.Threading.Thread.Sleep(100);
            }
            
            else if (vertical < 13 && arriba == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*");
                col--; 
                vertical++;
                if (vertical == 13)
                {
                    horizontal = 0; 
                    arriba = false; 
                }
                System.Threading.Thread.Sleep(100);
            }
           
            else if (vertical < 13 && arriba == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*");
                col++;
                vertical++;
                if (vertical == 13)
                {
                    horizontal = 0;
                    arriba = true; 
                }
                System.Threading.Thread.Sleep(100);
            }
        }
        // Pausa para observar el resultado
        Console.ReadKey();
    }
}
