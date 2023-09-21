namespace TryParseExempel
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Vi börjar med att kolla på Exempel1
      Exempel1();


      //När du är färdig med den kan du ta bort kommentarerna
      //på Exempel2 och kommentera Exempel1 sen starta programmet igen
      //Exempel2();



      //När du är färdig med den kan du ta bort kommentarerna
      //på Exempel3 och kommentera Exempel2 sen starta programmet igen
      //Exempel3("Skriv ett heltal: ");



    }






    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/






    public static void Exempel1()
    {
      //Be användaren att skriva in ett heltal
      Console.Write("Skriv ett heltal: ");

      //Skapa en integer som våran TryParse kan ge ett värde om den lyckas
      int maybeCorrectValue;


      //Skapar en bool successfulParse som är:
      //  True om TryParse lyckas göra användarens input till en int
      //  False om TryParse inte lyckades
      bool successfulParse = int.TryParse(Console.ReadLine(), out maybeCorrectValue);

      // Beroende på om vi lyckades konvertera användarens input eller inte
      if (successfulParse)
      {
        // successfulParse var True, skriver till användaren att dens nummer var bra
        Console.WriteLine($"{maybeCorrectValue} är en bra siffra!");
      }
      else
      {
        // successfulParse var False, skriver till använder att den inte gav oss en siffra
        Console.WriteLine("Nä det där var ingen siffra!");
      }

    }






    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/






    public static void Exempel2()
    {

      //Be användaren att skriva in ett heltal
      Console.Write("Skriv ett heltal: ");

      //Skapar inte en integer denna gången! Vi löser det i TryParse metoden!

      //Skapar en bool successfulParse som är:
      //  True om TryParse lyckas göra användarens input till en int
      //  False om TryParse inte lyckades
      //    OM successfulParse är true och våran TryParse kan göra användarens 
      //    input till en integer så skapar vi en ny integer med namnet validInteger

      //                                                      out <--- notera syntaxen "out"
      bool successfulParse = int.TryParse(Console.ReadLine(), out int validInteger);
      //                                                     ----------------------


      // Beroende på om vi lyckades konvertera användarens input eller inte
      if (successfulParse)
      {
        // successfulParse var True, skriver till användaren att dens nummer var bra
        Console.WriteLine($"{validInteger} är en bra siffra!");
      }
      else
      {
        // successfulParse var False, skriver till använder att den inte gav oss en siffra
        Console.WriteLine("Nä det där var ingen siffra!");
      }
    }






    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/
    /***********************************************************************************************/





    //                                                  Den här gången har vi en input
    //                                                  i våran metod, vi kan använda den
    //                                                  i hela metoden!
    public static void Exempel3(string question)// <--- (string question)
    {

      //Ställer våran fråga till användaren med string question
      //som vi fick då vi kallade metoden
      Console.Write(question);

      //Skapar inte en bool denna gången!
      //Vi löser det direkt i våran if sats!
      //  True om TryParse lyckas göra användarens input till en int
      //  False om TryParse inte lyckades
      //    OM TryParse är true och våran TryParse kan göra användarens 
      //    input till en integer så skapar vi en ny integer med namnet validInteger
      if (int.TryParse(Console.ReadLine(), out int validInteger))
      {
        Console.WriteLine($"{validInteger} är en bra siffra!");
      }
      else
      {
        Console.WriteLine("Nä det där var ingen siffra!");
      }
    }
  }
}