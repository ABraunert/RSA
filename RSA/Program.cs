

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Das hier ist eine RSA verschlüsselung");

        Console.WriteLine("Gibt 2 Primzahlen ein bitte");

        string val1 = Console.ReadLine();
        string val2 = Console.ReadLine();

        int prim1, prim2;

        prim1 = Convert.ToInt32(val1);
        prim2 = Convert.ToInt32(val2);

        Primcheck(prim1);
        Primcheck(prim2);

        int n =  prim1 * prim2;
        int m = (prim2 - 1) * (prim1 - 1);



        Console.WriteLine("Gib einer Zahl ein, die Teilerfremd zu " + m + "ist.");
        string val3 = Console.ReadLine();

        int e = Convert.ToInt32(val3);


        int[] pubkey = new int[] { n, e };




        Console.WriteLine("Die eingegebenen Primzahlen sind:" + prim1 + " und " +  prim2);





    }

    public static int Primcheck(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                Console.WriteLine("Das ist keine Primzahl...");
        }
        Console.WriteLine(true);

        return number;
    }



}