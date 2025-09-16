App.Run(new MtgCollection());

Console.ReadKey();

public static class App
{
  public static IMtgCollection ?_mtgCollection { get; set; }

  public static void Run(IMtgCollection MtgCollection)
  {
    _mtgCollection = MtgCollection;
    bool exitApplication = false;

    do
    {

      System.Console.WriteLine("What would you like to do?");
      System.Console.WriteLine("[A]dd a card to your collection.");
      System.Console.WriteLine("[S]ee your collection.");
      System.Console.WriteLine("[R]emove a card from your collection.");
      System.Console.WriteLine("[E]xit application");
      var userInput = Console.ReadLine();

      switch (userInput)
      {
        case "A":
        case "a":
          {
            _mtgCollection.AddCardToCollection();
            _mtgCollection.SaveCollection();
            break;
          }
        case "S":
        case "s":
          {
            _mtgCollection.SeeCollection();
            break;
          }
        case "R":
        case "r":
          {
            _mtgCollection.RemoveCardFromCollection();
            _mtgCollection.SaveCollection();
            break;
          }
        case "E":
        case "e":
          {
            _mtgCollection.SaveCollection();
            exitApplication = true;
            break;
          }
        default:
          {
            System.Console.WriteLine("Please choose a valid option.\n");
            break;
          }
      }
    } while (exitApplication == false);
  }
}