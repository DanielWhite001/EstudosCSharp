namespace ProjetoOsceola;

class Program
{
    static void Main(string[] args)
    { 
        int vida = 7;
         Console.WriteLine("a vida atual de Osceola é de: " + vida + "HP");

        if(vida <= 10){
            Console.WriteLine("Osceola está morrendo, se cure IMEDIATAMENTE!!!");
        }
        else if(vida <= 40){
            Console.WriteLine("Osceola está gravemente ferido, procure uma forma de se curar, rápido!");
        }
        else if(vida <= 70){
            Console.WriteLine("Osceola está ferido, se cure.");
        }
    }
}
