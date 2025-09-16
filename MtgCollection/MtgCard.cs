// See https://aka.ms/new-console-template for more information
public class MtgCard
{
  public string Name { get; set; }
  public int PsaGrade { get; set; }
  public int EbayValue { get; set; }

  public MtgCard(string name, int psaGrade, int ebayValue)
  {
    Name = name;
    PsaGrade = psaGrade;
    EbayValue = ebayValue;
  }

  public override string ToString()
  {
    return $"{Name}: PSA {PsaGrade}, ${EbayValue}";
  }
}