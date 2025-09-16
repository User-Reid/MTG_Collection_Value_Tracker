// See https://aka.ms/new-console-template for more information
public class MtgCollection : IMtgCollection
{
  public List<MtgCard> Collection = new();

  public void AddCardToCollection()
  {
    System.Console.WriteLine("What is the name of the card you would like to add?");
    var cardName = Console.ReadLine();
    System.Console.WriteLine("What is the PSA grade on the card?");
    var psaGrade = Console.ReadLine();
    System.Console.WriteLine("What is the Ebay value of the card?");
    var ebayValue = Console.ReadLine();
    System.Console.WriteLine();

    Collection.Add(new MtgCard(cardName, int.Parse(psaGrade), int.Parse(ebayValue)));
    System.Console.WriteLine($"Awesome! {cardName} has been added to your collection! Your current collection is now worth {Collection.Sum(card => card.EbayValue)}\n");
  }

  public void SeeCollection()
  {
    foreach (var card in Collection)
    {
      System.Console.WriteLine(card);
    }
  }

  public void RemoveCardFromCollection()
  {
    System.Console.WriteLine("Which card would you like to remove?");
    SeeCollection();
    System.Console.WriteLine();
    var userInput = Console.ReadLine();

    if (Collection.Any(card => card.Name == userInput))
    {
      Collection.Remove(Collection.FirstOrDefault(card => card.Name == userInput));
      System.Console.WriteLine($"{userInput} has been removed from your collection.");
    }
    else
    {
      System.Console.WriteLine("Your card could not be found.");
    }
  }
}
