using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {



            double altura, PesoIdeal;
            string sexo;
            DateTime agora = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"|Olá            {agora}");
            Console.WriteLine("|");
            Console.WriteLine("|------PesoIdeal-------");
            Console.WriteLine("|");
            Console.WriteLine("|- Cálculo de peso ideal com base na altura e no sexo.");
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("|--> Insira sua Altura: "); 
            altura = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("|");

            if (altura > 2.15 || altura < 1.25)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"- Atenção!! Altura {altura} inválida, favor inserir altura entre 1,25 M e 2,15 M.");
                Console.ResetColor();
                Environment.Exit(0);
            }

                        
            Console.Write("|--> Insira seu sexo (Somente Masculino ou Feminino): ");
            sexo = Console.ReadLine() .ToUpper();
            Console.WriteLine();

            if (sexo == "MASCULINO")
            {
                PesoIdeal = altura * 72.2 - 58;
                Console.WriteLine($"- Peso Ideal: {PesoIdeal:N1} kg.");
            }

            else if (sexo == "FEMININO")
            {
                PesoIdeal = altura *62.1 - 44.7;
                Console.WriteLine($"- Peso Ideal: {PesoIdeal:N1} kg.");
            }

            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"- Atenção!! Sexo {sexo} não válido, favor inserir conforme orientado: Somente Masculino ou Feminino.");
                Console.ResetColor();
                Environment.Exit(0);
            }









        }
    }
}
