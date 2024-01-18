namespace MenuMatematic;

class Program
{
    //Menu
    static void Menu()
    {
        int numeroMenu;

        Console.WriteLine("1. Maxim");
        Console.WriteLine("2. MCD");
        Console.WriteLine("3. MCM");
        Console.WriteLine("4. Factorial");
        Console.WriteLine("5. Combinatori");
        Console.WriteLine("6. Major Divisor");
        Console.WriteLine("7. Comprovar Primer");
        Console.WriteLine("8. Num Primers");
        Console.WriteLine("Clica la q per sortir");

        Console.WriteLine("Fica un numero");
        numeroMenu = Console.ReadLine(ValorsEntrada(numeroMenu));
    }

   static int ComprovarNum()
    {
        if (num)
    }

    //ValorsEntrada
    static int ValorsEntrada(int numeroMenu)
    {
        int numero1, numero2;

        switch (numeroMenu)
        {
            case 1:
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                Maxim(ref numero1, ref numero2);
                Console.WriteLine($"El numero", numero1, "és el mes gran");
                break;

            case 2:
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case 3:
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case 4:
                numero1 = DemanarValors();

            case 5:
                numero1 = DemanarValors();
                numero2 = DemanarValors();

            case 6:
                numero1 = DemanarValors();
                numero2 = DemanarValors();

            case 7:
                numero1 = DemanarValors();
                numero2 = DemanarValors();

            case 8:
                numero1 = DemanarValors();
                numero2 = DemanarValors();

            case 9:
                numero1 = DemanarValors();
                numero2 = DemanarValors();

            default:

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

    //Console.WriteLine(Metode(Variable));

    //Maxim
    static void Maxim(ref int numero1, ref int numero2)
    {
        if (numero2 > numero1)
        {
            (numero1, numero2) = (numero2, numero1);
        }
    }

    //mcd
    static int Mcd(int num1)
    {

    }

    //mcm
    static int Mcm(int num1)
    {

    }

    //Factorial
    static int Factorial(int num1)
    {

    }

    //Combinatori
    static int Combinatori(int num1)
    {

    }

    //MostrarDivisorMajor
    static int MostrarDivisorMajor(int num1)
    {

    }

    //EsPrimer
    static int EsPrimer(int num1)
    {

    }

    //NPrimerPrimers
    static int NPrimerPrimers(int num1)
    {

    }
}

static int IntroduirValor()
{
    Console.Clear();
    Console.Write("Escriu un Valor");
    
}


static void return()
    {
        int i = 5;
        while(i!=0)
        {
            Console.Write("\r")
            Console.Write($"Tornant al menu: {i}s")
            Thread.Sleep(1000);
            i--
        }
        Menu();
    }




static void Main(string[] args)
{

}
