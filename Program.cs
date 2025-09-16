App.Run(new MtgCollection());

Console.ReadKey();

public static class App
{
  public static IMtgCollection ?_mtgCollection { get; set; }

  public static void Run(IMtgCollection MtgCollection)
  {
    _mtgCollection = MtgCollection;

    System.Console.WriteLine("What would you like to do?");
  }
}