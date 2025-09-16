// See https://aka.ms/new-console-template for more information
public struct MtgCard
{
  public string Name { get; }
  public int PsaGrade { get; }
  public int EbayValue { get; }

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