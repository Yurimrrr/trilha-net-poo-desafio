namespace DesafioPOO.Models
{
  // TODO: Herdar da classe "Smartphone"
  public class Nokia : Smartphone
  {
    public Nokia(string numero, string modelo, string _IMEI, int memoria) : base(numero, modelo, _IMEI, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine("Instalando " + nomeApp + " no Nokia!");
    }
  }
}