namespace DiamanteComLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            ImprimirMeio(letradomeio, bkpmeio);

            int aux2 = 1;
            bkpmeio--;
            for (int i = bkpmeio; i >= 0; i--)
            {
                aux = aux - 2;
                ImprimirBaixo(Convert.ToChar(letradomeio - aux2), aux, aux2, bkpmeio);
                aux2++;
            }
            Console.ReadLine();
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
        private static void ImprimirMeio(char letradomeio, int bkpmeio)
        {
            Console.WriteLine(letradomeio);
            Console.Write(new string(' ', bkpmeio));
            Console.WriteLine(letradomeio);
        }
        static void ImprimirBaixo(char letra, int espacos, int aux, int bkpmeio)
        {
            if(aux < bkpmeio)
            {
                Console.Write(new string(' ', espacos));
                Console.Write(letra);
                Console.Write(new string(' ', aux));
                Console.WriteLine(letra);
            }
            if (aux == bkpmeio)
            {
                Console.Write(new string(' ', espacos));
                Console.Write(letra);
            }
        }
    }
}
