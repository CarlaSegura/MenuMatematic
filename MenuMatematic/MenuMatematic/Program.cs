using System;

namespace MenuMatematic;

class Program
{
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
    }

    //Per comprovar si es una lletra o no
    static char ComprovarNum(char numeroMenu)
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
    static int ValorsEntrada(char numeroMenu)
    {
        int numero1, numero2;

        switch (numeroMenu)
        {
            case '1':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                Maxim(ref numero1, ref numero2);
                Console.WriteLine($"El numero", numero1, "és el mes gran");
                break;

            case '2':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                Mcd(ref numero1, ref numero2);
                Console.WriteLine()
                break;

            case '3':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case '4':
                numero1 = DemanarValors();
                break;

            case '5':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case '6':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case '7':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case '8':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
                break;

            case '9':
                numero1 = DemanarValors();
                numero2 = DemanarValors();
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
    static void Mcd(ref int numero1, ref int numero2)
    {
        while (numero1 != 0)
        {
            int temp = numero2;
            numero2 = numero1 % numero2;
            numero1 = temp;
        }
    }

    //mcm
    static int Mcm(int num1)
    {
        //Debes de utilizar si o si el mcd
        if (a == 0 || b == 0)
        {
            return 0;
        }

        return (a * b) / CalcularMCD(a, b);
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
    static int NPrimerPrimers(int num1) //Poses un numero i ha de dir-te tots els numeros primers avans que aquell numero
    {

    }
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

static void Main(string[] args)
{

}
