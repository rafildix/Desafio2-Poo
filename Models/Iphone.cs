namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base (numero, modelo, IMEI, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no Iphone...");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
