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

  }

  public void RemoveCardFromCollection()
  {
    
  }
}
