namespace Aventureiro;

class Program
{
    static void Main(string[] args)
    {
        string nome = "";
        do{
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome) ||  nome.Any(char.IsDigit)){
                        Console.WriteLine("Nome inválido! Digite apenas letras.");
                        nome = "";
                }     
        } while (nome == "");
        
        

        int idade = 0;
        do {
                Console.WriteLine("Qual a sua idade?");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0){
                        Console.WriteLine("Idade inválida! Digite um número válido.");
                        idade = 0;
                }
        } while (idade == 0);

        float altura = 0f;
        do {
            Console.WriteLine("Qual a sua altura?");
            if (!float.TryParse(Console.ReadLine(), out altura) || altura <= 0){
                Console.WriteLine("Altura inválida! Digite um número válido.");
                altura = 0f;
            }
        } while (altura == 0f);
 
        char rank = ' ';
        do {
            Console.WriteLine("Qual o seu rank? (S, A, B, C, D, E)");    
            string entrada = Console.ReadLine().ToUpper();

            if(entrada.Length == 1 && (entrada[0] == 'S' || entrada[0] == 'A' || entrada[0] == 'B' || entrada[0] == 'C' || entrada[0] == 'D' || entrada[0] == 'E'))
            {
                rank = entrada[0];
            }
            else
            {
                Console.WriteLine("Rank inválido!, digite apenas as letras: S, A, B, C, D ou E!");    
            }
        } while (rank == ' ');

        Console.WriteLine($"Seu nome é {nome}, é uma honra recebê-lo(a) nesta guilda!");
        Console.WriteLine($"Bem-vindo a guilda! Vi que você tem {idade} anos!");
        Console.WriteLine($"E com {altura:f2} m de altura, você certamente é uma pessoa muito forte!");
        Console.WriteLine($"Seu rank é {rank}");

        switch(rank){
                
                case 'E':
                    Console.WriteLine("Você deverá alertar os civis se for necessário, mas a missão não apresenta condições realmente sérias.");
                    break;
                
                case 'D':
                    Console.WriteLine("Contato com outros aventureiros pode ser necessário, mas não apresenta urgencia imediata.");
                    break;

                case 'C':
                    Console.WriteLine("Medidas imediatas serão necessárias, porém entidades locais são suficientes para auxiliar na missão.");
                    break;

                case 'B':
                    Console.WriteLine("A ameaça representa um sério risco. É crucial mobilizar recursos significativos e garantir suporte logístico adequado.");
                    break;

                case 'A':
                    Console.WriteLine("Erradicação imediata de ameaças significativas à população. Missão de extremo custo e alto risco. ");
                    break;

                case 'S':
                    Console.WriteLine("Erradicação imediata é necessária, porém não há quaisquer métodos conhecidos para prosseguir com a missão. Cooperação global é essecial.");
                    break;
                default:
                    Console.WriteLine("Rank inválido!");
                    break;
        }

        
    }
}
