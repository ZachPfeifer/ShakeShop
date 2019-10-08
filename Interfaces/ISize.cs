namespace Jugs.Interfaces
{
  public interface ISize
  {
    double SizeModifier { get; set; }

    double GetPrice(Size s);
  }
  public enum Size
  {
    small = 3, //Can Set enum minimum here EX: small = 10
    medium = 4,
    large = 5,
    xlarge = 6,
    supersize = 8
  }
}