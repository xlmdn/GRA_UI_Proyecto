using System.Diagnostics;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        bool menu = true;
        while (menu) {
            Console.SetCursorPosition(42, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Selecciona una opción del menú\n");
            Console.SetCursorPosition(42, 10);
            Console.WriteLine("(1)\t Gráfica de barra con asteriscos");
            Console.SetCursorPosition(42, 11);
            Console.WriteLine("(2)\t Espiral con asteriscos");
            Console.SetCursorPosition(42, 12);
            Console.ForegroundColor= ConsoleColor.Yellow;
            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    Senos();
                    return;
                case 2:
                    Console.Clear();
                    Dos();
                    break;
                case 3:
                    triangulo();
                    break;
                default:

                    break;
            }
        }
        
    }
    private static void Uno()
    {
        int horizontal = 0;
        int vertical = 0;
        int col = 24;
        int fil = 95;
        bool arriba = true;

        for (int i = 0; i < 234; i++)
        {
            if (i == 0) { Console.ForegroundColor = ConsoleColor.Cyan; }
            Console.SetCursorPosition(fil, col);

            if (horizontal < 6)
            {
                if (horizontal == 0)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (i == 0) { Console.ForegroundColor = ConsoleColor.Cyan; }
                if (i == 233) { Console.ForegroundColor = ConsoleColor.Cyan; }
                Console.WriteLine("*");
                fil--;
                horizontal++;
                if (horizontal == 6)
                {
                    vertical = 0;
                }
                System.Threading.Thread.Sleep(30);
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
                System.Threading.Thread.Sleep(30);
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
                System.Threading.Thread.Sleep(30);
            }
        }
        Console.SetCursorPosition(35, 27);
        Console.WriteLine("Presiona espacio para continuar");
        Console.ReadKey();
        Console.Clear();

    }


    private static void Dos()
    {
        int x =Console.WindowWidth/2;
        int y = Console.WindowHeight/2;
        Console.SetCursorPosition(x, y);
        int cont = 0;
        string dir = "izq";
        int hor = 4;
        int vert = 2;
        int color = 1;

        for (int i = 1; i < 452; i++)
        {
            if (color == 1) { 
                Console.ForegroundColor= ConsoleColor.Green;
                color =2;
            }
            else if (color == 2) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                color =3;
            }
            else if (color == 3) { 
                Console.ForegroundColor = ConsoleColor.Blue;
                color =4;
            }
            else if (color == 4) { 
                Console.ForegroundColor = ConsoleColor.Red;
                color =5;
            }
            else if (color == 5) { 
                Console.ForegroundColor = ConsoleColor.Cyan;
                color =1;
            }
            if (dir == "izq" && cont < hor)
            {
                Console.WriteLine("*");
                x--;
                Console.SetCursorPosition(x, y);
                cont++;
                System.Threading.Thread.Sleep(30);
                if (cont == hor)
                {
                    hor = hor +5;
                    dir = "arr";
                    cont = 0;
                }
            }
            else if (dir == "arr" && cont < vert)
            {
                Console.WriteLine("*");
                y--;
                Console.SetCursorPosition(x, y);
                
                cont++;
                System.Threading.Thread.Sleep(30);
                if (cont == vert)
                {
                    vert = vert + 2;
                    dir = "der";
                    cont = 0;
                }
            }
            else if (dir == "der" && cont < hor)
            {
                Console.WriteLine("*");
                x++;
                Console.SetCursorPosition(x, y);
                
                cont++;
                System.Threading.Thread.Sleep(30);
                if (cont == hor)
                {
                    hor = hor +5;
                    dir = "aba";
                    cont = 0;
                }
            }
            else if (dir == "aba" && cont < vert)
            {
                Console.WriteLine("*");
                y++;
                Console.SetCursorPosition(x, y);
               
                cont++;
                System.Threading.Thread.Sleep(30);
                if (cont == vert)
                {
                    dir = "izq";
                    vert = vert + 2; ;
                    cont = 0;
                }
            }
        }
        Console.SetCursorPosition(35, 27);
        Console.WriteLine("Presiona espacio para continuar"); 
        Console.ReadKey();
        Console.Clear();
    }


    private static void tres() { 

    }
    private static void Senos()
    {
        // Método para calcular el factorial de un número
        double Factorial(int n)
        {
            double fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

        // Método para calcular el seno usando la serie de Taylor
        double Seno(double x)
        {
            x = x * Math.PI / 180; // Convertimos grados a radianes
            double sum = 0;
            for (int i = 0; i < 10; i++) // 10 términos de la serie de Taylor
            {
                double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
                sum += term;
            }
            return sum;
        }

        int columnas = 6;
        int filas = 15;
        int espacioX = 15;
        int espacioY = 1; // Reducimos el espacio vertical para evitar salir del buffer
        int contador = 0;

        Console.Clear();
        Console.WriteLine("Tabla del Seno de 0° a 90°");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int angulo = contador;
                if (angulo > 90) continue;
                double seno = Seno(angulo);

                int posY = (i + 1) * espacioY;
                if (posY >= Console.BufferHeight) break; // Evita exceder el tamaño del buffer

                Console.SetCursorPosition(j * espacioX, posY);
                Console.Write($"{angulo,2}°: {seno:F2}");

                contador += filas;
            }
            contador = i + 1;
        }

        Console.SetCursorPosition(0, Console.BufferHeight - 1); // Evita error al salir
    }
    private static void triangulo() {
        Console.Write("Ingresa el primer cateto: ");
        double c1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo cateto");
        double c2 = double.Parse(Console.ReadLine());
        double h = Math.Sqrt(c1 * c1 + c2 * c2);
        Console.WriteLine($"La hipotenusa del triángulo con catetos {c1} y {c2} es: {h:F2}");
    }
}