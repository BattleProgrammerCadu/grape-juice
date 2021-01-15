using System;

namespace grapeJuice
{
    class Program
    {
            // Função do dado, returna um numero aleatorio de 1 a 6
            private static int Dado(){
                Random rnd = new Random();
                return rnd.Next(1,6);  
            }
            //Função Combat, retorna o resultado do opção escolhida
            public static void Combat(int opcao,Personagem atacante, Personagem defensor){
                int dadoDef, dadoAtk,dadoEvs;
                Console.WriteLine($"O {atacante.GETname()} está atacando..\nAções Disponiveis:\n1- Atacar");
                int opAtk = Convert.ToInt32(Console.ReadLine());
                if(opAtk==1){
                    dadoAtk = atacante.GETatk() + Dado();
                    Console.WriteLine($"Valor de ataque do {atacante.GETname()} = {dadoAtk}");
                    int teste = 3;
                }
                    //1-ATAQUE
                    
                    
                    
                    //2- Utilizar Carta
                    /*case 2:
                    {   

                    }*/                
                  
                Console.WriteLine($"O {defensor.GETname()} está escolhendo uma ação..\nAções Disponiveis:\n1- Defender\n2- Evasiva");
                int opDef = Convert.ToInt32(Console.ReadLine());
                switch(opDef){
                    case 1:
                        dadoDef = defensor.GETdef() + Dado();
                        Console.WriteLine($"Valor de defesa do {defensor.GETname()} = {dadoDef}");
                    break;
                    case 2:
                        dadoEvs = defensor.GETevs() + Dado();
                        Console.WriteLine($"Valor de evasão do {defensor.GETname()} = {dadoEvs}");
                    break;
                }
                  
                     
                     int dmg = dadoAtk - dadoDef - teste;
                    Console.WriteLine($"Dano sofrido = {}");
            }
            //Função para exibir o menu
            public static string  Menu_Combat(){
                string _menu;
                _menu = "-----------MENU COMBAT--------------\n1-Atacar\n2-Defender\n3-Evasiva\n------------------------------------";
                return _menu;
            }
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem("Wallace",5,1,1,1);
            Personagem p2 = new Personagem("Eu", 3,2,1,2);
           /* Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");
            Console.WriteLine("Personagem 2 atacando Personagem 1....");
            /*Console.WriteLine($"-----------MENU COMBAT--------------");
            Console.WriteLine($"1-Atacar");
            Console.WriteLine($"2-Defender");
            Console.WriteLine($"3-Evasiva");
            Console.WriteLine($"------------------------------------");
            */
            Console.WriteLine(Menu_Combat());
            string[] escolha = Console.ReadLine().Split(" ");
            int _op = int.Parse(escolha[0]);
            int resposta = Combat(_op,p2,p1);
            Console.WriteLine(resposta);
            Console.WriteLine("-----------------------------------------");
            /* 
               P1   |  P2
            hp=5    |hp=3
            atk=1   |atk=2
            def=1   |def=1
            evs=1   |evs=2
            */
            Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Personagem 1 atacando Personagem 2....");

            /* 
               P1   |  P2
            hp=4    |hp=3
            atk=1   |atk=2
            def=1   |def=1
            evs=1   |evs=2
            */
            //p2.SEThp(p1.GETatk() - p2.GETdef());
            //Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            //Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");

             
        }    
    }
}
