namespace AmeacaHXH;

class Program
{
    static void Main(string[] args)
    {

        bool rodando = true;
        int rankA = 50;
        int rankB = 40;
        int rankC = 20;
        int rankD = 10;
        int rankE = 5;

while (rodando)
{
    Console.WriteLine("\n==== MENU PRINCIPAL ====");
    Console.WriteLine("1 - Classificar nova espécie");
    Console.WriteLine("2 - Sobre o sistema");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    
    string opcao = Console.ReadLine() ?? "";

    if (opcao == "1")
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("              ASSOCIAÇÃO HUNTER - HXH             ");
        Console.WriteLine("==================================================");
        
        Console.WriteLine("Você está utilizando um sistema da associação hunter que tem como principal objetivo catalogar espécies descobertas e seus niveis de perigo, classifique a ameaça de acordo com os seguintes critérios:");
        Console.WriteLine("Agressividade contra humanos");
        Console.WriteLine("População atual");
        Console.WriteLine("Fecundidade / Reprodução");
        Console.WriteLine("Capacidade de dano corporal");   
        Console.WriteLine("As classificações são de A, B, C, D e E, onde A é o maior indice e E o menor indice");
        
        //AGRESSIVIDADE
        string agressividade = "";
        do{
                Console.WriteLine("Qual o nível de agressividade da espécie? (A, B, C, D, E)");
                agressividade = Console.ReadLine()?.ToUpper() ?? "";
                if (agressividade != "A" && agressividade != "B" && agressividade != "C" && agressividade != "D" && agressividade != "E")
                {
                        Console.WriteLine("Rank inválido! Digite apenas letras dispostas.");
                        agressividade = "";
                }     

                if (agressividade == "A")
                {
                Console.WriteLine("1) Ataques sem provocação \n2)Ecologia ou comportamento colocam muitas vidas em risco");
                }
                else if (agressividade == "B")
                {
                Console.WriteLine("A espécie pode receber classificação A sob certas condições (clima, fonte de alimento, exposição a produtos químicos).");
                }
                else if (agressividade == "C")
                {
                Console.WriteLine("1) Diferenças individuais. \n 2)Indivíduos podem receber classificação A sob certas condições (cheiro de sangue, ameaça, época de reprodução, defesa dos filhotes)");
                }
                else if (agressividade == "D")
                {
                Console.WriteLine("Passivo: encontros repentinos podem provocar um ataque defensivo ou evasivo (emissão de gás, líquido, agulhos, pancada no corpo).");
                }
                else if (agressividade == "E")
                {
                Console.WriteLine("Não é agressivo.");
                }

        } while (agressividade == "");
         int pontosAgressividade = agressividade switch
         {
                "A" => rankA,
                "B" => rankB,
                "C" => rankC,
                "D" => rankD,
                "E" => rankE,
                _ => 0
         };

//====================================================================================================================================================
        //POPULAÇÃO
        string populacao = "";
        do{
                Console.WriteLine("\n\n\nQual o tamanho da população da espécie? (A, B, C, D, E)");
                populacao = Console.ReadLine()?.ToUpper() ?? "";
                if (populacao != "A" && populacao != "B" && populacao != "C" && populacao != "D" && populacao != "E")
                {
                        Console.WriteLine("Rank inválido! Digite apenas letras dispostas.");
                        populacao = "";
                }

                if (populacao == "A")
                {
                Console.WriteLine("Um ninho, hospedeiro ou rebanho conta com 10.000 ou mais indivíduos.");
                }
                else if (populacao == "B")
                {
                Console.WriteLine("Centenas a milhares.");
                }
                else if (populacao == "C")
                {
                Console.WriteLine("menor que 100 indivíduos.");
                }
                else if (populacao == "D")
                {
                Console.WriteLine("menor que 10 individuos.");
                }
                else if (populacao == "E")
                {
                Console.WriteLine("somente 1 individuo ou existência não confirmada. ");
                }
     
        } while (populacao == "");
         int pontosPopulacao = populacao switch
         {
                "A" => rankA,
                "B" => rankB,
                "C" => rankC,
                "D" => rankD,
                "E" => rankE,
                _ => 0
         };
//=============================================================================================================================================================
       //FECUNDIDADE
       string fecundidade = "";
        do{
                Console.WriteLine("\n\n\nQual o nível de fecundidade da espécie? (A, B, C, D, E)");
                fecundidade = Console.ReadLine()?.ToUpper() ?? "";
                if (fecundidade != "A" && fecundidade != "B" && fecundidade != "C" && fecundidade != "D" && fecundidade != "E")
                {
                        Console.WriteLine("Rank inválido! Digite apenas letras dispostas.");
                        fecundidade = "";
                }  

                if (fecundidade == "A")
                {
                Console.WriteLine("Crescimento explosivo quando a reprodução começa.");
                }
                else if (fecundidade == "B")
                {
                Console.WriteLine("1)Reproduz-se várias vezes ao ano, com mais de 10 filhotes. \n 2)As condições podem aproximar a espécie de A.");
                }
                else if (fecundidade == "C")
                {
                Console.WriteLine("Comparável a reprodução humana.");
                }
                else if (fecundidade == "D")
                {
                Console.WriteLine("Longos intervalos entre acasalamentos, com poucos filhotes.");
                }
                else if (fecundidade == "E")
                {
                Console.WriteLine("Não se reproduz ou a frequência é baixa o suficiente para ser insignificante.");
                }
   
        } while (fecundidade == "");
         int pontosFecundidade = fecundidade switch
         {
                "A" => rankA,
                "B" => rankB,
                "C" => rankC,
                "D" => rankD,
                "E" => rankE,
                _ => 0
         };
//==========================================================================================================================================================
        //CAPACIDADE DE DANO
        string capacidadeDano = "";
        do{
                Console.WriteLine("\n\n\nQual o nível de capacidade de dano da espécie? (A, B, C, D, E)");
                capacidadeDano = Console.ReadLine()?.ToUpper() ?? "";
                if (capacidadeDano != "A" && capacidadeDano != "B" && capacidadeDano != "C" && capacidadeDano != "D" && capacidadeDano != "E")
                {
                        Console.WriteLine("Rank inválido! Digite apenas letras dispostas.");
                        capacidadeDano = "";
                }     

                if (capacidadeDano == "A")
                {
                Console.WriteLine("1) Alta probabilidade de morte. \n 2)Lesões afetam a vida diária, recuperação completa difícil, sequelas para toda a vida.");
                }
                else if (capacidadeDano == "B")
                {
                Console.WriteLine("1) Sabe-se com evitá-los, mas a falha pode levar a ferimentos graves ou morte. \n 2)Recuperação completa difícil, com consequências para o resto da vida.");
                }
                else if (capacidadeDano == "C")
                {
                Console.WriteLine("1) Repouso e tratamento prolongados são necessários. A morte também é possível. \n 2)Afeta indiretamente muitas vidas(danos a plantações e gado.)");
                }
                else if (capacidadeDano == "D")
                {
                Console.WriteLine("1) Não afeta a vida diária, mas permanecem leves sequelas ou cicatrizes.\n 2)A recuperação é possível com algumas semanas de tratamento.");
                }
                else if (capacidadeDano == "E")
                {
                Console.WriteLine("1)Recuperação em dias com medicamento ou tratamento.\n 2)Efeitos adversos indiretos limitados(contaminação limitada, evacuação temporária).");
                }

        } while (capacidadeDano == "");
         int pontosCapacidadeDano = capacidadeDano switch
         {
                "A" => rankA,
                "B" => rankB,
                "C" => rankC,
                "D" => rankD,
                "E" => rankE,
                _ => 0
         };
//==============================================================================================================================================================

    int total = pontosAgressividade + pontosPopulacao + pontosFecundidade + pontosCapacidadeDano;
    
    if(total >=150){
        Console.WriteLine("\n\nNivel de ameaça: A. A erradicação imediata é necessária, mas o método é incerto; a cooperação global é essencial.");
    }
    else if(total >=100){
        Console.WriteLine("\n\nNivel de ameaça: B. A erradicação imediata é necessária, com alto custo e alto risco; uma respostas internacional é necessária.");
    }
    else if(total >=70){
        Console.WriteLine("\n\nNivel de ameaça: C. Medidas imediatas são necessárias, mas uma respostas local é suficiente.");
    }
    else if(total >=50){
        Console.WriteLine("\n\nNivel de ameaça: D. Resposta a casos indíviduais necessária, mas não urgente ou perigosa.");
    }
    else if(total >=20){
        Console.WriteLine("\n\nNivel de ameaça: E. Um aviso aos civis é necessário, mas a situação não é grave.");
    }
    else{
        Console.WriteLine("\n\nAMENÇA INSIGNIFICANTE!");
    }

    }
    else if (opcao == "2")
    {
        Console.WriteLine("Sistema da Associação Hunter - HxH");
    }
    else if (opcao == "0")
    {
        Console.WriteLine("Encerrando o sistema...");
        rodando = false; 
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}

        
    }

 
}
