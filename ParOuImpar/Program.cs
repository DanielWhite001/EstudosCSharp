namespace ParOuImpar;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        bool numeroValido = false;
        

        while(!numeroValido){
            Console.Write("olá, por favor digite um número!: ");
            string digito = Console.ReadLine();
            numeroValido = int.TryParse(digito, out numero);

        if (!numeroValido) {
         Console.WriteLine("Número inválido!");
       }
        }
       
       
       if (numero % 2 == 0)
        {
            Console.WriteLine("O número digitado é par!");
        }
        else
        {
            Console.WriteLine("O número digitado é ímpar!");
        }
    }
}