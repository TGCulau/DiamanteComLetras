namespace DiamanteComLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabecalho();
            Console.Write("Digite uma letra para gerar o diamante: ");
            char letradomeio = Convert.ToChar(Console.ReadLine());
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
            Console.ReadLine();
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
    }
}
