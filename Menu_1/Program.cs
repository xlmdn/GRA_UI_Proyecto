using System.Diagnostics;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        bool menu = true;
        while (menu)
        {
            Console.SetCursorPosition(42, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú principal\n");
            Console.SetCursorPosition(42, 10);
            Console.WriteLine("(1)\t Menú 1: Programas de introducción");
            Console.SetCursorPosition(42, 11);
            Console.WriteLine("(2)\t Menú 2: Programas de localización");
            Console.SetCursorPosition(42, 12);
            Console.WriteLine("(0)\t Salir");
            Console.SetCursorPosition(42, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    menu1();
                    return;
                case 2:
                    Console.Clear();
                    menu2();
                    return;
                case 0:
                    Environment.Exit(0);
                    return;
                default:

                    break;
            }
        }
    }

    private static void menu1() {
        bool menu = true;
        while (menu)
        {
            Console.Clear();
            Console.SetCursorPosition(42, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú uno\n");
            Console.SetCursorPosition(42, 10);
            Console.WriteLine("(1)\t Generar barras con asteriscos");
            Console.SetCursorPosition(42, 11);
            Console.WriteLine("(2)\t Generar espiral con asteriscos");
            Console.SetCursorPosition(42, 12);
            Console.WriteLine("(3)\t Generar rectangulos con asteriscos");
            Console.SetCursorPosition(42, 13);
            Console.WriteLine("(0)\t regresar al menú principal");
            Console.SetCursorPosition(42, 14);
            Console.ForegroundColor = ConsoleColor.Yellow;
            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    Uno();
                    return;
                case 2:
                    Console.Clear();
                    Dos();
                    break;
                case 3:
                    Console.Clear();
                    tres();
                    break;
                case 0:
                    Console.Clear();
                    Main(null);
                    return;
                default:

                    break;
            }
        }
    }

    private static void menu2() {
        Console.Clear();
        bool menu = true;
        while (menu)
        {
            Console.SetCursorPosition(42, 9);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menú Dos\n");
            Console.SetCursorPosition(42, 10);
            Console.WriteLine("(1)\t  Mostrar la tabla de senos del 0 al 90.");
            Console.SetCursorPosition(42, 11);
            Console.WriteLine("(2)\t Mostrar la tabla de cosenos del 0 al 90.");
            Console.SetCursorPosition(42, 12);
            Console.WriteLine("(3)\t Triangulo rectangulo");
            Console.SetCursorPosition(42, 13); 
            Console.WriteLine("(4)\t Calcular pedniente de una recta");
            Console.SetCursorPosition(42, 14);
            Console.WriteLine("(5)\t Trayectoria de un proyectil");
            Console.SetCursorPosition(42, 15);
            Console.WriteLine("(0)\t Regresar al menú principal");
            Console.SetCursorPosition(42, 16);
            Console.ForegroundColor = ConsoleColor.Yellow;
            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    Senos();
                    return;
                case 2:
                    Console.Clear();
                    Cosenos();
                    return;
                case 3:
                    Console.Clear();
                    triangulo();
                    return;
                case 4:
                    Console.Clear();
                    cuatro();
                    return;
                case 5:
                    Console.Clear();
                    cinco();
                    return;
                case 0:
                    Console.Clear();
                    Main(null);
                    return;
                default:

                    break;
            }
        }
    }

    private static void Uno()
    {
        Console.Clear();
        int horizontal = 0;
        int vertical = 0;
        int col = 24;
        int fil = 95;
        bool arriba = true;
        Console.SetCursorPosition(42, 2);
        Console.WriteLine("Generador de barras");
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
        Console.WriteLine("Presiona -> para ir al siguiente programa o espacio para regresar");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            Dos();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar) {
            menu1();
        }

    }

    
    private static void Dos()
    {
        Console.Clear();
        int x =Console.WindowWidth/2;
        int y = Console.WindowHeight/2;
        Console.SetCursorPosition(x, y);
        int cont = 0;
        string dir = "izq";
        int hor = 4;
        int vert = 2;
        int color = 1;
        Console.SetCursorPosition(42, 2);
        Console.WriteLine("Generador de Espiral");

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
        Console.WriteLine("Presiona -> o <- para ir al siguiente programa o al anterior. Espacio para ir al menú");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            tres();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            menu1();
        }
        else if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Uno();
        }
    }

    public static void tres()
    {
        Console.Clear();
        int centerX = Console.WindowWidth / 2;
        int centerY = Console.WindowHeight / 2;
        int delay = 20;

        // 1. Primer figura: 3 asteriscos verdes en línea, separados por espacios.
        Console.ForegroundColor = ConsoleColor.Green;
        int firstStartX = centerX - 2;
        Console.SetCursorPosition(firstStartX, centerY);
        Console.Write("* * *");
        Thread.Sleep(500);

        // 2. Segundo rectángulo: Amarillo, 15 asteriscos horizontales x 5 verticales.
        Console.ForegroundColor = ConsoleColor.Yellow;
        int width = 15, height = 5;
        int startX = centerX - width / 2;
        int startY = centerY - height / 2;

        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(startX + i, startY);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = 1; i < height; i++)
        {
            Console.SetCursorPosition(startX + width - 1, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = width - 2; i >= 0; i--)
        {
            Console.SetCursorPosition(startX + i, startY + height - 1);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = height - 2; i > 0; i--)
        {
            Console.SetCursorPosition(startX, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        Thread.Sleep(500);

        // 3. Tercer rectángulo: Rojo, 24 horizontales x 9 verticales.
        Console.ForegroundColor = ConsoleColor.Red;
        width = 24;
        height = 9;
        startX = centerX - width / 2;
        startY = centerY - height / 2;

        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(startX + i, startY);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = 1; i < height; i++)
        {
            Console.SetCursorPosition(startX + width - 1, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = width - 2; i >= 0; i--)
        {
            Console.SetCursorPosition(startX + i, startY + height - 1);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = height - 2; i > 0; i--)
        {
            Console.SetCursorPosition(startX, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        Thread.Sleep(500);

        // 4. Cuarto rectángulo: Azul, 35 horizontales x 13 verticales.
        Console.ForegroundColor = ConsoleColor.Blue;
        width = 35;
        height = 13;
        startX = centerX - width / 2;
        startY = centerY - height / 2;

        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(startX + i, startY);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = 1; i < height; i++)
        {
            Console.SetCursorPosition(startX + width - 1, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = width - 2; i >= 0; i--)
        {
            Console.SetCursorPosition(startX + i, startY + height - 1);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = height - 2; i > 0; i--)
        {
            Console.SetCursorPosition(startX, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Cyan;
        width = 43;
        height = 17;
        startX = centerX - width / 2;
        startY = centerY - height / 2;

        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(startX + i, startY);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = 1; i < height; i++)
        {
            Console.SetCursorPosition(startX + width - 1, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = width - 2; i >= 0; i--)
        {
            Console.SetCursorPosition(startX + i, startY + height - 1);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        for (int i = height - 2; i > 0; i--)
        {
            Console.SetCursorPosition(startX, startY + i);
            Console.Write("*");
            Thread.Sleep(delay);
        }
        Thread.Sleep(500);

        Console.ResetColor();
        Console.SetCursorPosition(35, 27);
        Console.WriteLine("Presiona  <- para ir al programa anterior. Espacio para ir al menú");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Dos();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            menu1();
        }
    }

    private static void Senos()
    {
        Console.Clear();
        double Factorial(int n)
        {
            double fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

        double GradosARadianes(double grados)
        {
            return grados * (22.0 / 7.0) / 180.0; 
        }

        double Seno(double x)
        {
            double sum = 0;
            x = GradosARadianes(x); 
            for (int i = 0; i < 10; i++) 
            {
                double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
                sum += term;
            }
            return sum;
        }

        int columnas = 6;
        int filas = 15;
        int espacioX = 15;
        int espacioY = 1; 
        int contador = 0;

        Console.Clear();
        string titulo = "Tabla del Seno de 0° a 90°";
        int anchoConsola = Console.WindowWidth;
        int altoConsola = Console.WindowHeight;
        int posicionTituloX = (anchoConsola - titulo.Length) / 2;
        int posicionTituloY = 2;
        Console.SetCursorPosition(posicionTituloX, posicionTituloY);
        Console.WriteLine(titulo);

        int inicioY = (altoConsola - filas) / 2;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int angulo = contador;
                if (angulo > 90) continue;
                double seno = Seno(angulo);

                int posY = inicioY + (i * espacioY);
                if (posY >= Console.BufferHeight) break;

                int posX = (anchoConsola - (columnas * espacioX)) / 2 + (j * espacioX);
                Console.SetCursorPosition(posX, posY);
                Console.Write($"{angulo,2}°: {seno:F2}");

                contador += filas;
            }
            contador = i + 1;
        }

        Console.SetCursorPosition(0, Console.BufferHeight - 1); 
        Console.SetCursorPosition(35, 27);
        Console.WriteLine("Presiona -> para ir al siguiente programa o espacio para regresar");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            Cosenos();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            menu2();
        }
    }

    private static void Cosenos()
    {
        Console.Clear();
        double Factorial(int n)
        {
            double fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

        double GradosARadianes(double grados)
        {
            return grados * (22.0 / 7.0) / 180.0; 
        }

        double Coseno(double x)
        {
            x = GradosARadianes(x); 
            double sum = 0;
            for (int i = 0; i < 10; i++) 
            {
                double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
                sum += term;
            }
            return sum;
        }

        int columnas = 6;
        int filas = 15;
        int espacioX = 15;
        int espacioY = 1; 
        int contador = 0;

        Console.Clear();
        string titulo = "Tabla del Coseno de 0° a 90°";
        int anchoConsola = Console.WindowWidth;
        int altoConsola = Console.WindowHeight;
        int posicionTituloX = (anchoConsola - titulo.Length) / 2;
        int posicionTituloY = 2;
        Console.SetCursorPosition(posicionTituloX, posicionTituloY);
        Console.WriteLine(titulo);

        int inicioY = (altoConsola - filas) / 2;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int angulo = contador;
                if (angulo > 90) continue;
                double coseno = Coseno(angulo);

                int posY = inicioY + (i * espacioY);
                if (posY >= Console.BufferHeight) break; 

                int posX = (anchoConsola - (columnas * espacioX)) / 2 + (j * espacioX);
                Console.SetCursorPosition(posX, posY);
                Console.Write($"{angulo,2}°: {coseno:F2}");

                contador += filas;
            }
            contador = i + 1;
        }

        Console.SetCursorPosition(0, Console.BufferHeight - 1);
        Console.SetCursorPosition(26, 27);
        Console.WriteLine("Presiona -> o <- para ir al siguiente programa o al anterior. Espacio para ir al menú");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            triangulo();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            menu2();
        }
        else if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Senos();
        }
    }


    private static void triangulo() {
        Console.Clear();
        Console.WriteLine("Cálculo del Triángulo Rectángulo");
        Console.Write("Ingrese el primer cateto: ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo cateto: ");
        double cateto2 = Convert.ToDouble(Console.ReadLine());

        double hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
        double angulo1 = Math.Asin(cateto1 / hipotenusa) * 180.0 / Math.PI;
        double angulo2 = Math.Asin(cateto2 / hipotenusa) * 180.0 / Math.PI;

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Hipotenusa: {0:F2}", hipotenusa);
        Console.WriteLine("Ángulo opuesto al primer cateto: {0:F2}°", angulo1);
        Console.WriteLine("Ángulo opuesto al segundo cateto: {0:F2}°", angulo2);
        dibujarTriangulo();
        Console.SetCursorPosition(26, 27);
        Console.WriteLine("Presiona -> o <- para ir al siguiente programa o al anterior. Espacio para ir al menú");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            cuatro();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            menu2();
        }
        else if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Cosenos();
        }

    }


    public static void cuatro()
    {
        Console.Clear();
        Console.WriteLine("Cálculo de la Recta a partir de Dos Puntos");
        Console.Write("Ingrese la coordenada x del primer punto: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la coordenada y del primer punto: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la coordenada x del segundo punto: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la coordenada y del segundo punto: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        if (x2 - x1 == 0)
        {
            Console.WriteLine("\nLa pendiente es indefinida (recta vertical).");
        }
        else
        {
            double pendiente = (y2 - y1) / (x2 - x1);
            double anguloInclinacion = Math.Atan(pendiente) * 180.0 / Math.PI;
            double puntoMedioX = (x1 + x2) / 2.0;
            double puntoMedioY = (y1 + y2) / 2.0;

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Pendiente: {0:F2}", pendiente);
            Console.WriteLine("Ángulo de inclinación: {0:F2}°", anguloInclinacion);
            Console.WriteLine("Punto medio: ({0:F2}, {1:F2})", puntoMedioX, puntoMedioY);

            if (x2 > x1 && y2 > y1)
                Console.WriteLine("La recta sube hacia la derecha.");
            else if (x2 > x1 && y2 < y1)
                Console.WriteLine("La recta baja hacia la derecha.");
            else if (x2 < x1 && y2 > y1)
                Console.WriteLine("La recta sube hacia la izquierda.");
            else if (x2 < x1 && y2 < y1)
                Console.WriteLine("La recta baja hacia la izquierda.");
            else if (x1 == x2)
                Console.WriteLine("La recta es vertical.");
            else if (y1 == y2)
                Console.WriteLine("La recta es horizontal.");

            Console.WriteLine("\nDibujo de la recta:");

            int ancho = 20;
            int alto = 20;
            char[,] plano = new char[alto, ancho];

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    plano[i, j] = ' ';
                }
            }

            int xInicio = (int)Math.Round(x1);
            int yInicio = (int)Math.Round(y1);
            int xFin = (int)Math.Round(x2);
            int yFin = (int)Math.Round(y2);

            int dx = Math.Abs(xFin - xInicio);
            int dy = Math.Abs(yFin - yInicio);
            int sx = xInicio < xFin ? 1 : -1;
            int sy = yInicio < yFin ? 1 : -1;
            int err = dx - dy;

            int xActual = xInicio;
            int yActual = yInicio;

            while (true)
            {
                if (xActual >= 0 && xActual < ancho && yActual >= 0 && yActual < alto)
                {
                    plano[yActual, xActual] = '*';
                }

                if (xActual == xFin && yActual == yFin)
                {
                    break;
                }

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    xActual += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    yActual += sy;
                }
            }

            for (int i = alto - 1; i >= 0; i--)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(plano[i, j]);
                }
                Console.WriteLine();
            }
        }

        Console.SetCursorPosition(26, 27);
        Console.WriteLine("Presiona -> o <- para ir al siguiente programa o al anterior. Espacio para ir al menú");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        Console.Clear();
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            Console.Clear();
            cinco();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            Console.Clear();
            menu2();
        }
        else if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();    
            triangulo();
        }
    }


    public static void cinco()
    {
        Console.Clear();
        Console.WriteLine("Simulación del Movimiento de un Proyectil");
        Console.Write("Ingrese la velocidad inicial (m/s): ");
        double velocidadInicial = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el ángulo de lanzamiento (grados): ");
        double anguloGrados = Convert.ToDouble(Console.ReadLine());
        double rad = anguloGrados * Math.PI / 180.0;
        double g = 9.81;
        double t_total = (2 * velocidadInicial * Math.Sin(rad)) / g;

        Console.WriteLine("\nTiempo(s)\tDistancia(m)\tAltura(m)\tVelocidad(m/s)");

        double t = 0.0;
        double maxAltura = 0.0;
        double maxVelocidad = velocidadInicial; 
        double maxDistancia = 0.0;

        while (t <= t_total)
        {
            double x = velocidadInicial * Math.Cos(rad) * t;
            double y = velocidadInicial * Math.Sin(rad) * t - 0.5 * g * t * t;
            double vx = velocidadInicial * Math.Cos(rad);
            double vy = velocidadInicial * Math.Sin(rad) - g * t;
            double velocidad = Math.Sqrt(vx * vx + vy * vy);

            if (y > maxAltura)
                maxAltura = y;
            if (x > maxDistancia)
                maxDistancia = x;
            if (velocidad > maxVelocidad)
                maxVelocidad = velocidad;

            Console.WriteLine("{0:F1}\t\t{1:F2}\t\t{2:F2}\t\t{3:F2}", t, x, y, velocidad);
            t += 0.1;
        }

        Console.WriteLine("\nResultados finales:");
        Console.WriteLine("Altura máxima: {0:F2} m", maxAltura);
        Console.WriteLine("Velocidad máxima: {0:F2} m/s", maxVelocidad);
        Console.WriteLine("Distancia máxima: {0:F2} m", maxDistancia);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Presiona   <- para ir al programa anterior. Espacio para ir al menú");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            cuatro();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            Console.Clear();
            menu2();
        }
        
    }

    public static void dibujarTriangulo()
    {
        // Definimos la esquina inferior izquierda del triángulo
        int startX = 45;
        int startY = 25; // Debe ser lo suficientemente grande para poder dibujar hacia arriba
        int vertical = 10;    // 10 asteriscos en la altura (hacia arriba)
        int horizontal = 20;  // 20 asteriscos en la base (hacia la derecha)

        // Dibujar la base horizontal (lado inferior)
        for (int i = 0; i < horizontal; i++)
        {
            Console.SetCursorPosition(startX + i, startY);
            Console.Write("*");
            Thread.Sleep(50);
        }

        // Dibujar la altura vertical (lado izquierdo)
        for (int i = 0; i < vertical; i++)
        {
            Console.SetCursorPosition(startX, startY - i);
            Console.Write("*");
            Thread.Sleep(50);
        }

        // Dibujar la hipotenusa, que une:
        // - el extremo derecho de la base: (startX + horizontal - 1, startY)
        // - con el extremo superior de la altura: (startX, startY - vertical + 1)
        int x1 = startX + horizontal - 1;
        int y1 = startY;
        int x2 = startX;
        int y2 = startY - vertical + 1;

        // Usamos el algoritmo de Bresenham para dibujar la línea (hipotenusa)
        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);
        int sx = (x1 < x2) ? 1 : -1;
        int sy = (y1 < y2) ? 1 : -1;
        int err = dx - dy;

        while (true)
        {
            Thread.Sleep(50);
            Console.SetCursorPosition(x1, y1);
            Console.Write("*");
            if (x1 == x2 && y1 == y2)
                break;
            int e2 = 2 * err;
            if (e2 > -dy)
            {
                err -= dy;
                x1 += sx;
            }
            if (e2 < dx)
            {
                err += dx;
                y1 += sy;
            }
        }
    }


}
