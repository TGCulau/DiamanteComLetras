namespace DiamanteComLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opm = 1;
            while (opm == 1)
            {
                Cabecalho();
                char letradomeio = Letra();
                char start = 'A';
                int meio = letradomeio - start;
                int bkpmeio = meio + 1;
                int aux = 1;
                for (int i = 0; i <= meio; i++)
                {
                    ImprimirCima(Convert.ToChar(start + i), meio - i, i, aux);
                    if (i >= 1)
                    {
                        aux = aux + 2;
                    }
                }

                int aux2 = 1, aux3 = 0;
                bkpmeio--;
                aux = aux - 2;
                for (int i = bkpmeio; i > 0; i--)
                {
                    aux3++;
                    aux = aux - 2;
                    ImprimirBaixo(Convert.ToChar(letradomeio - aux3), aux2, aux, i);
                    aux2++;
                }
                opm = Rexit();
            }
        }
        static void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                               Diamante de Letras                               ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################\n\n");
        }
        static char Letra()
        {
            Console.Write("Digite uma letra para gerar o diamante: ");
            char letradomeio = Convert.ToChar(Console.ReadLine());
            return letradomeio;
        }
        static int LerInt(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        static void ImprimirCima(char letra, int espacos, int i, int aux)
        {
            if (i == 0)
            {
                Console.Write(new string(' ', espacos));
                Console.WriteLine(letra);
            }
            else if (i == 1)
            {
                Console.Write(new string(' ', espacos));
                Console.Write(letra);
                Console.Write(new string(' ', i));
                Console.WriteLine(letra);
            }
            else
            {
                Console.Write(new string(' ', espacos));
                Console.Write(letra);
                Console.Write(new string(' ', aux));
                Console.WriteLine(letra);
            }
        }
        static void ImprimirBaixo(char letra, int espacos, int aux, int i)
        {
            if(i > 1)
            {
                Console.Write(new string(' ', espacos));
                Console.Write(letra);
                Console.Write(new string(' ', aux));
                Console.WriteLine(letra);
            }
            else if (i == 1)
            {
                Console.Write(new string(' ', espacos));
                Console.Write(letra);
            }
        }
        static int Rexit() //Rexit = Restart or Exit
        {
            int opm;
            while (true)
            {
                opm = LerInt("\n\n\nEscolha sua opção.\n\n1. Desenhar outro diamante\n2. Sair\n\nDigite sua opção: ");
                if (opm != 1 && opm != 2)
                {
                    Console.Write("\nPor favor escolha uma opção valida do menu.\n\nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return opm;
        }
    }
}
