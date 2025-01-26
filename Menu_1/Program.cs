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
            Console.WriteLine("(1)\tPrograma 1");
            Console.SetCursorPosition(42, 11);
            Console.WriteLine("(2)\tPrograma 2");
            Console.SetCursorPosition(42, 12);
            Console.ForegroundColor= ConsoleColor.Yellow;
            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    Uno();
                    break;
                case 2:
                    Console.Clear();
                    Dos();
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
        int fil = 115;
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
                if (i == 0) { Console.ForegroundColor = ConsoleColor.Black; }
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
        int x = 55;
        int y = 13;
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
}
