using System.Globalization;

namespace URIONLINE
{
    class Uri
    {
        static void Main(string[] args)
        {
            //uri1010();
            //uri1011();
            //uri1012();
            //uri1013();
        }
        public static void uri1010()
        {

            string[] linha1 = Console.ReadLine().Split(' ');
            string[] linha2 = Console.ReadLine().Split(' ');

            Double vltotal = (Convert.ToInt32(linha1[1]) * double.Parse(linha1[2], CultureInfo.InvariantCulture)) +
                             (Convert.ToInt32(linha2[1]) * double.Parse(linha2[2], CultureInfo.InvariantCulture));

            Console.WriteLine($"VALOR A PAGAR: R$ {vltotal:f2}");
        }
        public static void uri1011()
        {

            string raio = Console.ReadLine();

            double massa = (4.0 / 3.0) * 3.14159 * Math.Pow(double.Parse(raio, CultureInfo.InvariantCulture),3);

            Console.WriteLine($"VOLUME = {massa:f3}");
        }
        public static void uri1012()
        {

            string[] linha = Console.ReadLine().Split(' ');
            double A, B, C;
            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            C = double.Parse(linha[2], CultureInfo.InvariantCulture);

            double quadrado = Math.Round((B * B), 3);
            double retangulo = Math.Round((A * B), 3);
            double trapezio = Math.Round((((A + B) * C) / 2), 3);
            double circulo = Math.Round((3.14159 * Math.Pow(C, 2)), 3);
            double triangulo = Math.Round(((A * C) / 2), 3);


            Console.WriteLine($"TRIANGULO: {triangulo:f3}");
            Console.WriteLine($"CIRCULO: {circulo:f3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:f3}");
            Console.WriteLine($"QUADRADO: {quadrado:f3}");
            Console.WriteLine($"RETANGULO: {retangulo:f3}");       
  
        }
        public static void uri1013()
        {
            string[] linha = Console.ReadLine().Split(' ');

            int A, B, C, maiorAB, maior;
            A = int.Parse(linha[0]);
            B = int.Parse(linha[1]);
            C = int.Parse(linha[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = maiorAB > C ? maiorAB : C;

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}




