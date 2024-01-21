namespace MenuMatematic;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void retornar()
    {
        int i = 5;
        while (i != 0)
        {
            Console.Write("\r");
            Console.Write($"Tornant al menu: {i}s");
            Thread.Sleep(1000);
            i--;
        }
        Menu();
    }

    //Menu
    static void Menu()
    {
        char numeroMenu;
        string menu =
        "|==============================|\n" +
        "|             Menu             |\n" +
        "|------------------------------|\n" +
        "|     1. Maxim                 |\n" +
        "|     2. MCD                   |\n" +
        "|     3. MCM                   |\n" +
        "|     4. Factorial             |\n" +
        "|     5. Combinatori           |\n" +
        "|     6. Major Divisor         |\n" +
        "|     7. Comprovar Primer      |\n" +
        "|     8. Num Primers           |\n" +
        "|     Clica la q per sortir    |\n" +
        "|==============================|\n";

        Console.WriteLine("Fica un numero");
        numeroMenu = Convert.ToChar(Console.ReadLine());
        ComprovarNum(numeroMenu);
        retornar();
    }

    //Per comprovar si es una lletra o no
    static void ComprovarNum(char numeroMenu)
    {
        do
        {
            ValorsEntrada(numeroMenu);
        } while (numeroMenu > 1 && numeroMenu < 8);

        if (numeroMenu == 'q')
        {
            //Finalitzar
        }
        else
        {
            Console.WriteLine("El numero no es correcte");
            Menu();
        }
    }

    //ValorsEntrada
    static void ValorsEntrada(char numeroMenu)
    {
        int numero1, numero2;

        switch (numeroMenu)
        {
            case '1':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                Maxim(ref numero1, ref numero2);
                Console.WriteLine($"El numero {numero1} és el mes gran");
                break;

            case '2':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                int mcd = Mcd(numero1, numero2);
                Console.WriteLine($"El MCD de {numero1} i {numero2} és: {mcd}");
                break;

            case '3':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                int mcm = Mcm(numero1, numero2);
                Console.WriteLine($"El MCM de {numero1} i {numero2} és: {mcm}");
                break;

            case '4':
                numero1 = DemanarValors();
                int factorial = Factorial(numero1);
                Console.WriteLine($"El Factorial de {numero1} és: {factorial}");
                break;

            case '5':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                int combinatori = Combinatori(numero1, numero2);
                Console.WriteLine($"El combinatori de {numero1} i {numero2} és: {combinatori}");
                break;

            case '6':
                numero1 = DemanarValors();
                int divisorMajor = MostrarDivisorMajor(numero1);
                Console.WriteLine($"El divisor major de {numero1} és: {divisorMajor}");
                break;

            case '7':
                numero1 = DemanarValors();
                bool primer = EsPrimer(numero1);
                if (primer) Console.WriteLine($"{numero1} és un numero primer");
                else Console.WriteLine($"{numero1} no és un numero primer");
                break;

            case '8':
                numero1 = DemanarValors();
                NPrimerPrimers(numero1);
                break;
        }
    }

    static int DemanarValors()
    {
        int numero;
        Console.Clear();
        Console.Write("Fica un valor");
        numero = Console.Read();
        return numero;
    }

    //Maxim
    static void Maxim (ref int numero1, ref int numero2)
    {
        if (numero2 > numero1)
        {
            (numero1, numero2) = (numero2, numero1);
        }
    }

    //mcd
    static int Mcd(int numero1, int numero2)
    {
        while (numero1 != 0)
        {
            int temp = numero2;
            numero2 = numero1 % numero2;
            numero1 = temp;
        }
        return numero1;
    }

    //mcm
    static int Mcm(int numero1, int numero2)
    {
        if (numero1 == 0 || numero2 == 0)
        {
            return 0;
        }
        return (numero1 * numero2) / Mcd(numero1, numero2);
    }

    //Factorial
    static int Factorial(int numero1)
    {
        int res = 1;
        for (int i = 1; i <= numero1; i++)
        {
            res = res * i;
        }
        return res;
    }

    //Combinatori
    static int Combinatori(int numero1, int numero2)
    {
        if (numero1 <= 0 || numero2 <= 0 || numero2 > numero1)
        {
            Console.WriteLine("Els valors posats no poden ser menors o iguals que 0 i el segon numero ha de ser mes petit");
            Menu();
        }
        int res = Factorial(numero1) / (Factorial(numero2) * Factorial(numero1 - numero2));
        return res;
    }

    //MostrarDivisorMajor
    static int MostrarDivisorMajor(int numero1)
    {
        if (numero1 <= 0)
        {
            Console.WriteLine("Els valors posats no poden ser menors o iguals que 0");
            Menu();
        }

        int divisorMajor = 1;
        for (int i = 2; i <= Math.Sqrt(numero1); i++)
        {
            if (numero1 % i == 0)
            {
                divisorMajor = i;
            }
        }

        return divisorMajor;
    }

    //EsPrimer
    static bool EsPrimer(int numero1)
    {
        int cont2 = 1;

        for (int i = 1; i <= numero1; i++)
        {
            if (numero1 % cont2 == 0)
            {
                cont2++;
            }
        }

        if (cont2 == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //NPrimerPrimers
    static void NPrimerPrimers(int numero1)
    {
        for (int i = 2; i < numero1; i++)
        {
            if (EsPrimer(i))
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}
