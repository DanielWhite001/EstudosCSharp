namespace ExercicioFuncoes;

class Program
{
    //exercicio 01

    /* static int vidaTotal = 100;
    
    static void dano(int danoRecebido){
        vidaTotal = vidaTotal - danoRecebido;

        if(vidaTotal <= 0){
            
            Console.WriteLine("Osceola morreu...");  
        }

        else{
                Console.WriteLine("Após receber dano, a vida de Osceola é de: " + vidaTotal + "HP");
        }
    }

    public static void Main(string[] args)
    {   
        Console.WriteLine("a vida atual de Osceola é de: " + vidaTotal + "HP");
    
        //dano(100);
        dano(30);
        
    } */


    //exercicio 02
    static int gastoFixo = 100;
    static int gastosVariaveis = 200;
   

    static void CalcularDespesaTotal() 
    {
         int somaGastos = gastosVariaveis + gastoFixo; 
        Console.WriteLine("o gasto total é de: " + somaGastos);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("o valor do gasto fixo é de:" + gastoFixo + "R$");
        Console.WriteLine("o valor do gasto variavel é de:" + gastosVariaveis + "R$");
        CalcularDespesaTotal();
    }
}
