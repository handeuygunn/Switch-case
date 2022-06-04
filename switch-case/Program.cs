internal class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;
        switch(month)
        {
            case 1 :
            Console.WriteLine("Ocak ayındasınız");
            break;
            case 2: 
            Console.WriteLine("şubat ayındasınız");
            break;
            case 3: 
            Console.WriteLine("mart ayındasınız");
            break;
            case 4: 
            Console.WriteLine("nisan ayındasınız");
            break;
            case 5: 
            Console.WriteLine("mayıs ayındasınız");
            break;
            case 6:
            Console.WriteLine("haziran ayındasınız");
            break;

        }
        switch(month)
        {
            case 12:
            case 1:
            case 2:
            Console.WriteLine("Kış ayındasınız");
            break;

            case 3:
            case 4:
            case 5:
            Console.WriteLine("ilkbahar ayındasınız");
            break;

            case 6:
            case 7:
            case 8:
            Console.WriteLine("yaz ayındasınız");
            break;




            default:
            break;
        }

    }
}