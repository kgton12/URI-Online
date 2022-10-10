using System.Globalization;

namespace URIONLINE
{
    class Uri
    {
        static void Main(string[] args)
        {
            uri1042();
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

            double massa = (4.0 / 3.0) * 3.14159 * Math.Pow(double.Parse(raio, CultureInfo.InvariantCulture), 3);

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
        public static void uri1014()
        {
            int km = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double gas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = Math.Round(km / gas, 3);

            Console.WriteLine($"{media:f3} km/l");



        }
        public static void uri1015()
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            string[] linha2 = Console.ReadLine().Split(' ');

            double x1, x2, y1, y2;

            x1 = double.Parse(linha1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(linha1[1], CultureInfo.InvariantCulture);

            x2 = double.Parse(linha2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(linha2[1], CultureInfo.InvariantCulture);

            double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);

            Console.WriteLine($"{result:f4}");
        }
        public static void uri1016()
        {
            string y = Console.ReadLine();

            Console.WriteLine($"{int.Parse(y) * 2} minutos");
        }
        public static void uri1017()
        {
            int tempoGasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            double litros = tempoGasto * velocidadeMedia / 12.0;

            Console.WriteLine($"{litros:f3}");

        }
        public static void uri1018()
        {
            int valor = int.Parse(Console.ReadLine());
            int troco, cem, cinquenta, vinte, dez, cinco, dois;

            troco = valor;

            cem = troco / 100;

            troco = troco - (cem * 100);

            cinquenta = troco / 50;

            troco = troco - (cinquenta * 50);

            vinte = troco / 20;

            troco = troco - (vinte * 20);

            dez = troco / 10;

            troco = troco - (dez * 10);

            cinco = troco / 5;

            troco = troco - (cinco * 5);

            dois = troco / 2;

            troco = troco - (dois * 2);

            Console.WriteLine($"{valor}");
            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{troco} nota(s) de R$ 1,00");


        }
        public static void uri1019()
        {
            int segundos = int.Parse(Console.ReadLine());

            int hor = (int)(segundos / (60 * 60));

            int min = (int)((segundos - (hor * 60 * 60)) / 60);

            int seg = (int)(segundos - (hor * 60 * 60) - (min * 60));

            Console.WriteLine($"{hor}:{min}:{seg}");
        }
        public static void uri1020()
        {
            int dias = int.Parse(Console.ReadLine());

            int ano = (int)(dias / 365);
            dias = dias - (ano * 365);

            int mes = (int)(dias / 30);
            dias = dias - (mes * 30);

            int dia = dias;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
        public static void uri1021()
        {
            int dinheiro1, cem, cinquenta, cinquenta1, vinte, vinte1, dez, dez1, cinco, cinco1, dois, dois1;

            int moedas, um, um1, cinquentacen, vintecen, dezcen, cincocen, umcen;

            double dinheiro;

            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dinheiro1 = (int)dinheiro;
            dinheiro -= dinheiro1;

            moedas = (int)(dinheiro * 100);

            cem = dinheiro1 / 100;
            cinquenta = dinheiro1 % 100;
            cinquenta1 = cinquenta / 50;
            vinte = cinquenta % 50;
            vinte1 = vinte / 20;
            dez = vinte % 20;
            dez1 = dez / 10;
            cinco = dez % 10;
            cinco1 = cinco / 5;
            dois = cinco % 5;
            dois1 = dois / 2;

            um = dois % 2;
            um1 = um / 1;


            Console.WriteLine($"NOTAS:");
            Console.WriteLine($"{cem} nota(s) de R$ 100.00");
            Console.WriteLine($"{cinquenta1} nota(s) de R$ 50.00");
            Console.WriteLine($"{vinte1} nota(s) de R$ 20.00");
            Console.WriteLine($"{dez1} nota(s) de R$ 10.00");
            Console.WriteLine($"{cinco1} nota(s) de R$ 5.00");
            Console.WriteLine($"{dois1} nota(s) de R$ 2.00");

            cinquentacen = moedas / 50;
            vintecen = (moedas % 50) / 25;
            dezcen = (((moedas % 50) % 25) / 10);
            cincocen = ((((moedas % 50) % 25) % 10) / 5);
            umcen = ((((moedas % 50) % 25) % 10) % 5) / 1;

            Console.WriteLine($"MOEDAS:");
            Console.WriteLine($"{um1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{cinquentacen} moeda(s) de R$ 0.50");
            Console.WriteLine($"{vintecen} moeda(s) de R$ 0.25");
            Console.WriteLine($"{dezcen} moeda(s) de R$ 0.10");
            Console.WriteLine($"{cincocen} moeda(s) de R$ 0.05");
            Console.WriteLine($"{umcen} moeda(s) de R$ 0.01");
        }
        public static void uri1022()
        {
            string[] linha = Console.ReadLine().Split(' ');
            int A = int.Parse(linha[0]);
            int B = int.Parse(linha[1]);
            int C = int.Parse(linha[2]);
            int D = int.Parse(linha[3]);

            if (B > C && D > A && (C + D) > (A + B) && C >= 0 && D >= 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
        public static void uri1036()
        {
            double A, B, C, T;
            string[] linha = Console.ReadLine().Split(' ');

            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            C = double.Parse(linha[2], CultureInfo.InvariantCulture);


            if (((B * B) - 4 * A * C) < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                T = Math.Sqrt((B * B) - 4 * A * C);
                Console.WriteLine($"R1 = {((-B + T) / (2 * A)):f5}");
                Console.WriteLine($"R2 = {((-B - T) / (2 * A)):f5}");
            }
        }
        public static void uri1037()
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string msg;

            if (valor >= 0 && valor <= 25)
            {
                msg = "Intervalo [0,25]";
            }
            else if (valor >= 25 && valor <= 50)
            {
                msg = "Intervalo (25,50]";
            }
            else if (valor >= 50 && valor <= 75)
            {
                msg = "Intervalo (50,75]";
            }
            else if (valor >= 75 && valor <= 100)
            {
                msg = "Intervalo (75,100]";
            }
            else
            {
                msg = "Fora de intervalo";
            }
            Console.WriteLine(msg);
        }
        public static void uri1038()
        {
            string[] linha = Console.ReadLine().Split(' ');
            int cod = int.Parse(linha[0]);
            int qtd = int.Parse(linha[1]);
            double[] val = new double[] { 0.00, 4.00, 4.50, 5.00, 2.00, 1.50 };

            Console.WriteLine($"Total: R$ {(qtd * val[cod]):f2}");
        }
        public static void uri1040()
        {
            double a, b, c, d, last, m;
            string[] linha = Console.ReadLine().Split(' ');
            a = double.Parse(linha[0], CultureInfo.InvariantCulture);
            b = double.Parse(linha[1], CultureInfo.InvariantCulture);
            c = double.Parse(linha[2], CultureInfo.InvariantCulture);
            d = double.Parse(linha[3], CultureInfo.InvariantCulture);
            /*
             m = Math.Round((a * 2 + b * 3 + c * 4 + d),1) / 10;

             Console.WriteLine($"Media: {m.ToString("F1", CultureInfo.InvariantCulture)}");

             if (m >= 7.0)
             {
                 Console.WriteLine($"Aluno aprovado.");
             }
             else if (m >= 5.0)
             {
                 Console.WriteLine($"Aluno em exame.");
                 last = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 Console.WriteLine($"Nota do exame: {last.ToString("F1", CultureInfo.InvariantCulture)}");
                 if (last + m / 2.0 > 5.0)
                 {
                     Console.WriteLine($"Aluno aprovado.");
                 }
                 else
                 {
                     Console.WriteLine($"Aluno reprovado.");
                 }
                 Console.WriteLine($"Media final: { Math.Round(((last + m) / 2.0),1).ToString("F1", CultureInfo.InvariantCulture)}");
             }
             else
             {
                 Console.WriteLine($"Aluno reprovado.");
             }*/

            m = Math.Round((((a * 2) + (b * 3) + (c * 4) + d) / 10), 1);
            if (m < 5)
            {
                Console.WriteLine($"Media: {m.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Aluno reprovado.");
            }
            else if (m > 7)
            {
                Console.WriteLine($"Media: {m.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Aluno aprovado.");
            }
            else
            {
                double g;
                Console.WriteLine($"Media: {m.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Aluno em exame.");
                last = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {last.ToString("F1", CultureInfo.InvariantCulture)}");
                g = ((m + last) / 2);
                if (g < 5)
                {
                    Console.WriteLine($"Aluno reprovado.");
                    Console.WriteLine($"Media: {g.ToString("F1", CultureInfo.InvariantCulture)}");
                }
                else if (g > 5)
                {
                    Console.WriteLine($"Aluno aprovado.");
                    Console.WriteLine($"Media final: { Math.Round(g).ToString("F1", CultureInfo.InvariantCulture)}");
                }

            }
        }
        public static void uri1041()
        {
            double y, x;
            string[] linha = Console.ReadLine().Split(' ');
            x = double.Parse(linha[0], CultureInfo.InvariantCulture);
            y = double.Parse(linha[1], CultureInfo.InvariantCulture);

            if (x + y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
        }
        public static void uri1042()
        {            
            string[] linha = Console.ReadLine().Split(' ');
            int[] linhaordenada = new int[3];

            for (int i = 0; i < linha.Length; i++)
            {
                linhaordenada[i] = Convert.ToInt16(linha[i]);                
            }

            Array.Sort(linhaordenada);

            foreach (var item in linhaordenada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            foreach (var item in linha)
            {
                Console.WriteLine(item);
            }
        }
    }
}





